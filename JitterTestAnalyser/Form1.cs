using JitterTestAnalyser.Helpers;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JitterTestAnalyser
{
    public partial class MainForm : Form
    {
        private FileHelper fileHelper;
        private JitterTestResult jitterTestResult;
        private NewDbHelper newDbHelper;
        private delegate void SetButtonStateCallBack(bool btnState);
        private delegate void SetStateLabelCallback(string state);
        private delegate void SetProgressCallback(int progress);

        public MainForm()
        {
            InitializeComponent();
            fileHelper = new FileHelper();
            jitterTestResult = new JitterTestResult();
            newDbHelper = new NewDbHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var systems = newDbHelper.GetTestSystems(); //dataBaseHelper.GetTestSystems();


            foreach (Model.TestSystem system in systems)
            {
                cbSystem.Items.Add(system);
            }

            var novaVersions = newDbHelper.GetNovaVersions();//dataBaseHelper.GetNovaVersions();

            foreach (string novaVersion in novaVersions)
            {
                cbNovaVersion.Items.Add(novaVersion);
            }

            var mantaVersions = newDbHelper.GetMantaVersions(); //dataBaseHelper.GetMantaVersions();

            foreach (string mantaVersion in mantaVersions)
            {
                cbMantaVersion.Items.Add(mantaVersion);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            jitterTestResult.TestSystem = (Model.TestSystem)cbSystem.SelectedItem;
            jitterTestResult.NovaVersion = cbNovaVersion.Text;
            jitterTestResult.MantaVersion = cbMantaVersion.Text;
            jitterTestResult.Product = cbProduct.Text;
            jitterTestResult.ImageLength = int.Parse(cbImageLength.Text);
            jitterTestResult.RawDataEnabled = cbRawDataEnabled.Checked;
            jitterTestResult.FodEnabled = cbFODEnabled.Checked;
            jitterTestResult.SurveilanceEnabled = cbSurveilance.Checked;
            jitterTestResult.StatisticsEnabled = cbStatistics.Checked;
            jitterTestResult.MeasureFrom = cbMeasureFrom.Text;
            jitterTestResult.ConveyorSpeed = int.Parse(cbConveyorSpeed.Text);
            int dataBaseSize = 0;
            jitterTestResult.DataBaseSize = int.TryParse(tbDbSize.Text, out dataBaseSize) ? dataBaseSize : 0;
            jitterTestResult.OpcClient = cbOpcClient.Text;
            jitterTestResult.NlcpPoints = Convert.ToInt32(cbNlcpPoints.Text);
            jitterTestResult.Comment = rtbComment.Text;

            new Thread(this.AddData).Start();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Csv files (*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = dialog.FileName;
                jitterTestResult.CsvFileName = tbFile.Text;
            }
        }

        private void AddData()
        {
            SetButtonState(false);

            UpdateStatusLabel(string.Format("Adding data for {0}", jitterTestResult.TestSystem.Name));

            UpdateStatusLabel("Reading from file.");
            var newSetupId = newDbHelper.AddTestSetup(jitterTestResult);
            jitterTestResult.Delays = fileHelper.ReadFromFile(jitterTestResult, newSetupId).ToList();
            int numbreOfLines = jitterTestResult.Delays.Count();
            if (numbreOfLines > 0)
            {
                int addedLines = 0;
                int progress = 0;

                var batchSize = numbreOfLines/50;

                UpdateStatusLabel("Adding delays to database.");
                while (addedLines < numbreOfLines)
                {
                    var delaysBatch = jitterTestResult.Delays.Skip(addedLines).Take(batchSize).ToList();
                    newDbHelper.AddDelays(delaysBatch);
                    addedLines += delaysBatch.Count;
                    progress = (int)((double)addedLines / numbreOfLines * 100);
                    SetProgress(progress);
                    UpdateStatusLabel($"Added {addedLines} of {numbreOfLines} delays.");
                }

                SetProgress(0);
                UpdateStatusLabel($"{numbreOfLines} values added.");
                SetButtonState(true);
            }
        }


        private void SetButtonState(bool btnstate)
        {
            if (btnAdd.InvokeRequired)
            {
                SetButtonStateCallBack d = new SetButtonStateCallBack(SetButtonState);
                this.Invoke(d, new object[] { btnstate });
                return;
            }

            btnAdd.Enabled = btnstate;
        }

        private void SetProgress(int progress)
        {
            if (progressBarAdd.InvokeRequired)
            {
                SetProgressCallback d = new SetProgressCallback(SetProgress);
                this.Invoke(d, new object[] { progress });
                return;
            }

            progressBarAdd.Value = progress;
        }


        private void UpdateStatusLabel(string state)
        {
            if (lblState.InvokeRequired)
            {
                SetStateLabelCallback d = new SetStateLabelCallback(UpdateStatusLabel);
                this.Invoke(d, new object[] { state });
                return;
            }

            lblState.Text = state;
        }

        private void tbFile_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel("");
        }

        private void btnDeleteSetup_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
