using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JitterTestAnalyser
{
  public partial class MainForm : Form
  {
    private DataBaseGetData dataBaseHelper;
    private FileHelper fileHelper;
    private JitterTestResult jitterTestResult;
    private delegate void SetButtonStateCallBack(bool btnState);
    private delegate void SetStateLabelCallback(string state);
    private delegate void SetProgressCallback(int progress);

    public MainForm()
    {
      InitializeComponent();
      dataBaseHelper = new DataBaseGetData();
      fileHelper = new FileHelper();
      jitterTestResult = new JitterTestResult();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      var systems = dataBaseHelper.GetTestSystems();


      foreach (GetTestSystemsResult system in systems)
      {
        cbSystem.Items.Add(system);
      }

      var novaVersions = dataBaseHelper.GetNovaVersions();

      foreach (string novaVersion in novaVersions)
      {
        cbNovaVersion.Items.Add(novaVersion);
      }

      var mantaVersions = dataBaseHelper.GetMantaVersions();

      foreach (string mantaVersion in mantaVersions)
      {
        cbMantaVersion.Items.Add(mantaVersion);
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      jitterTestResult.TestSystem = (GetTestSystemsResult) cbSystem.SelectedItem;
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
      jitterTestResult.Delays = fileHelper.ReadFromFile(jitterTestResult.CsvFileName).ToList();
      int numbreOfLines = jitterTestResult.Delays.Count();
      if (numbreOfLines > 0)
      {
        int newSetupId = dataBaseHelper.AddTestSetup(jitterTestResult);
       
        int addedLines = 0;
        int progress = 0;
        foreach (var line in jitterTestResult.Delays)
        {
          dataBaseHelper.AddDelay(
            line.TimeStamp, line.SampleId, line.Delay, jitterTestResult.TestSystem.SystemID, newSetupId);
          addedLines++;
          if (addedLines*100/numbreOfLines > progress + 1)
          {
            progress = progress + 1;
            SetProgress(progress);
            UpdateStatusLabel(string.Format("{0} values of {1} added.", addedLines, numbreOfLines));
          }
        }

        SetProgress(0);
        UpdateStatusLabel(string.Format("{0} values added", numbreOfLines));
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
      int setupID = 0;
      if (int.TryParse(tbSetupID.Text, out setupID))
      {
        dataBaseHelper.DeleteSetupId(setupID);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      jitterTestResult.TestSystem = (GetTestSystemsResult)cbSystem.SelectedItem;
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
      jitterTestResult.Delays = fileHelper.ReadFromFile(jitterTestResult.CsvFileName).ToList();

     // fileHelper.SaveToBson(jitterTestResult, "Test.Bson");
    }

  }
}
