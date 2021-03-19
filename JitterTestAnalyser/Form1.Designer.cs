namespace JitterTestAnalyser
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label11 = new System.Windows.Forms.Label();
      this.cbNlcpPoints = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.cbOpcClient = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.tbDbSize = new System.Windows.Forms.TextBox();
      this.cbStatistics = new System.Windows.Forms.CheckBox();
      this.cbSurveilance = new System.Windows.Forms.CheckBox();
      this.lblState = new System.Windows.Forms.Label();
      this.progressBarAdd = new System.Windows.Forms.ProgressBar();
      this.btnFile = new System.Windows.Forms.Button();
      this.tbFile = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.cbMeasureFrom = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.cbConveyorSpeed = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cbImageLength = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cbProduct = new System.Windows.Forms.ComboBox();
      this.cbFODEnabled = new System.Windows.Forms.CheckBox();
      this.cbRawDataEnabled = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cbMantaVersion = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbNovaVersion = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cbSystem = new System.Windows.Forms.ComboBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnDeleteSetup = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.tbSetupID = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.rtbComment = new System.Windows.Forms.RichTextBox();
      this.testSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.testSystemBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(749, 492);
      this.tabControl1.TabIndex = 21;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.rtbComment);
      this.tabPage1.Controls.Add(this.label12);
      this.tabPage1.Controls.Add(this.label11);
      this.tabPage1.Controls.Add(this.cbNlcpPoints);
      this.tabPage1.Controls.Add(this.label10);
      this.tabPage1.Controls.Add(this.cbOpcClient);
      this.tabPage1.Controls.Add(this.label8);
      this.tabPage1.Controls.Add(this.tbDbSize);
      this.tabPage1.Controls.Add(this.cbStatistics);
      this.tabPage1.Controls.Add(this.cbSurveilance);
      this.tabPage1.Controls.Add(this.lblState);
      this.tabPage1.Controls.Add(this.progressBarAdd);
      this.tabPage1.Controls.Add(this.btnFile);
      this.tabPage1.Controls.Add(this.tbFile);
      this.tabPage1.Controls.Add(this.btnAdd);
      this.tabPage1.Controls.Add(this.label7);
      this.tabPage1.Controls.Add(this.cbMeasureFrom);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.cbConveyorSpeed);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.cbImageLength);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.cbProduct);
      this.tabPage1.Controls.Add(this.cbFODEnabled);
      this.tabPage1.Controls.Add(this.cbRawDataEnabled);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.cbMantaVersion);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.cbNovaVersion);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.cbSystem);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(741, 466);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Add New Data";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(285, 115);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(84, 13);
      this.label11.TabIndex = 49;
      this.label11.Text = "Lines in Nlcp file";
      // 
      // cbNlcpPoints
      // 
      this.cbNlcpPoints.FormattingEnabled = true;
      this.cbNlcpPoints.Items.AddRange(new object[] {
            "4",
            "24"});
      this.cbNlcpPoints.Location = new System.Drawing.Point(284, 131);
      this.cbNlcpPoints.Name = "cbNlcpPoints";
      this.cbNlcpPoints.Size = new System.Drawing.Size(121, 21);
      this.cbNlcpPoints.TabIndex = 48;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(281, 19);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(55, 13);
      this.label10.TabIndex = 47;
      this.label10.Text = "Opc client";
      // 
      // cbOpcClient
      // 
      this.cbOpcClient.FormattingEnabled = true;
      this.cbOpcClient.Items.AddRange(new object[] {
            "FossOpcServer",
            "PDx"});
      this.cbOpcClient.Location = new System.Drawing.Point(284, 35);
      this.cbOpcClient.Name = "cbOpcClient";
      this.cbOpcClient.Size = new System.Drawing.Size(167, 21);
      this.cbOpcClient.TabIndex = 46;
      this.cbOpcClient.Text = "PDx";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(281, 65);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(74, 13);
      this.label8.TabIndex = 45;
      this.label8.Text = "Database size";
      // 
      // tbDbSize
      // 
      this.tbDbSize.Location = new System.Drawing.Point(284, 81);
      this.tbDbSize.Name = "tbDbSize";
      this.tbDbSize.Size = new System.Drawing.Size(167, 20);
      this.tbDbSize.TabIndex = 44;
      // 
      // cbStatistics
      // 
      this.cbStatistics.AutoSize = true;
      this.cbStatistics.Checked = true;
      this.cbStatistics.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbStatistics.Location = new System.Drawing.Point(135, 195);
      this.cbStatistics.Name = "cbStatistics";
      this.cbStatistics.Size = new System.Drawing.Size(110, 17);
      this.cbStatistics.TabIndex = 43;
      this.cbStatistics.Text = "Statistics Enabled";
      this.cbStatistics.UseVisualStyleBackColor = true;
      // 
      // cbSurveilance
      // 
      this.cbSurveilance.AutoSize = true;
      this.cbSurveilance.Checked = true;
      this.cbSurveilance.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbSurveilance.Location = new System.Drawing.Point(135, 172);
      this.cbSurveilance.Name = "cbSurveilance";
      this.cbSurveilance.Size = new System.Drawing.Size(123, 17);
      this.cbSurveilance.TabIndex = 42;
      this.cbSurveilance.Text = "Surveilance enabled";
      this.cbSurveilance.UseVisualStyleBackColor = true;
      // 
      // lblState
      // 
      this.lblState.AutoSize = true;
      this.lblState.Location = new System.Drawing.Point(285, 398);
      this.lblState.Name = "lblState";
      this.lblState.Size = new System.Drawing.Size(0, 13);
      this.lblState.TabIndex = 41;
      // 
      // progressBarAdd
      // 
      this.progressBarAdd.Location = new System.Drawing.Point(288, 418);
      this.progressBarAdd.Name = "progressBarAdd";
      this.progressBarAdd.Size = new System.Drawing.Size(328, 23);
      this.progressBarAdd.TabIndex = 40;
      // 
      // btnFile
      // 
      this.btnFile.Location = new System.Drawing.Point(673, 318);
      this.btnFile.Name = "btnFile";
      this.btnFile.Size = new System.Drawing.Size(39, 23);
      this.btnFile.TabIndex = 39;
      this.btnFile.Text = "...";
      this.btnFile.UseVisualStyleBackColor = true;
      this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
      // 
      // tbFile
      // 
      this.tbFile.Location = new System.Drawing.Point(284, 320);
      this.tbFile.Name = "tbFile";
      this.tbFile.Size = new System.Drawing.Size(383, 20);
      this.tbFile.TabIndex = 38;
      this.tbFile.TextChanged += new System.EventHandler(this.tbFile_TextChanged);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(641, 418);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 37;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(14, 379);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(71, 13);
      this.label7.TabIndex = 36;
      this.label7.Text = "Measure from";
      // 
      // cbMeasureFrom
      // 
      this.cbMeasureFrom.FormattingEnabled = true;
      this.cbMeasureFrom.Items.AddRange(new object[] {
            "Nova",
            "Manta"});
      this.cbMeasureFrom.Location = new System.Drawing.Point(17, 395);
      this.cbMeasureFrom.Name = "cbMeasureFrom";
      this.cbMeasureFrom.Size = new System.Drawing.Size(125, 21);
      this.cbMeasureFrom.TabIndex = 35;
      this.cbMeasureFrom.Text = "Manta";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(14, 328);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(84, 13);
      this.label6.TabIndex = 34;
      this.label6.Text = "Conveyor speed";
      // 
      // cbConveyorSpeed
      // 
      this.cbConveyorSpeed.FormattingEnabled = true;
      this.cbConveyorSpeed.Items.AddRange(new object[] {
            "150",
            "250",
            "375",
            "750"});
      this.cbConveyorSpeed.Location = new System.Drawing.Point(17, 344);
      this.cbConveyorSpeed.Name = "cbConveyorSpeed";
      this.cbConveyorSpeed.Size = new System.Drawing.Size(123, 21);
      this.cbConveyorSpeed.TabIndex = 33;
      this.cbConveyorSpeed.Text = "375";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 279);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(68, 13);
      this.label5.TabIndex = 32;
      this.label5.Text = "Image length";
      // 
      // cbImageLength
      // 
      this.cbImageLength.FormattingEnabled = true;
      this.cbImageLength.Items.AddRange(new object[] {
            "300",
            "600",
            "900",
            "1200"});
      this.cbImageLength.Location = new System.Drawing.Point(17, 295);
      this.cbImageLength.Name = "cbImageLength";
      this.cbImageLength.Size = new System.Drawing.Size(196, 21);
      this.cbImageLength.TabIndex = 31;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 227);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 13);
      this.label4.TabIndex = 30;
      this.label4.Text = "Product";
      // 
      // cbProduct
      // 
      this.cbProduct.FormattingEnabled = true;
      this.cbProduct.Items.AddRange(new object[] {
            "Box",
            "Loose",
            "Morphometry"});
      this.cbProduct.Location = new System.Drawing.Point(17, 243);
      this.cbProduct.Name = "cbProduct";
      this.cbProduct.Size = new System.Drawing.Size(196, 21);
      this.cbProduct.TabIndex = 29;
      // 
      // cbFODEnabled
      // 
      this.cbFODEnabled.AutoSize = true;
      this.cbFODEnabled.Checked = true;
      this.cbFODEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbFODEnabled.Location = new System.Drawing.Point(17, 195);
      this.cbFODEnabled.Name = "cbFODEnabled";
      this.cbFODEnabled.Size = new System.Drawing.Size(89, 17);
      this.cbFODEnabled.TabIndex = 28;
      this.cbFODEnabled.Text = "FOD enabled";
      this.cbFODEnabled.UseVisualStyleBackColor = true;
      // 
      // cbRawDataEnabled
      // 
      this.cbRawDataEnabled.AutoSize = true;
      this.cbRawDataEnabled.Location = new System.Drawing.Point(17, 172);
      this.cbRawDataEnabled.Name = "cbRawDataEnabled";
      this.cbRawDataEnabled.Size = new System.Drawing.Size(110, 17);
      this.cbRawDataEnabled.TabIndex = 27;
      this.cbRawDataEnabled.Text = "Rawdata enabled";
      this.cbRawDataEnabled.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 115);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 26;
      this.label3.Text = "Manta version";
      // 
      // cbMantaVersion
      // 
      this.cbMantaVersion.FormattingEnabled = true;
      this.cbMantaVersion.Location = new System.Drawing.Point(17, 131);
      this.cbMantaVersion.Name = "cbMantaVersion";
      this.cbMantaVersion.Size = new System.Drawing.Size(196, 21);
      this.cbMantaVersion.TabIndex = 25;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 24;
      this.label2.Text = "Nova version";
      // 
      // cbNovaVersion
      // 
      this.cbNovaVersion.FormattingEnabled = true;
      this.cbNovaVersion.Location = new System.Drawing.Point(17, 80);
      this.cbNovaVersion.Name = "cbNovaVersion";
      this.cbNovaVersion.Size = new System.Drawing.Size(196, 21);
      this.cbNovaVersion.TabIndex = 23;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "System";
      // 
      // cbSystem
      // 
      this.cbSystem.FormattingEnabled = true;
      this.cbSystem.Location = new System.Drawing.Point(17, 33);
      this.cbSystem.Name = "cbSystem";
      this.cbSystem.Size = new System.Drawing.Size(196, 21);
      this.cbSystem.TabIndex = 21;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(741, 466);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Remove Data";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnDeleteSetup);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.tbSetupID);
      this.groupBox1.Location = new System.Drawing.Point(54, 59);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(180, 110);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Delete Test Run";
      // 
      // btnDeleteSetup
      // 
      this.btnDeleteSetup.Location = new System.Drawing.Point(90, 71);
      this.btnDeleteSetup.Name = "btnDeleteSetup";
      this.btnDeleteSetup.Size = new System.Drawing.Size(75, 23);
      this.btnDeleteSetup.TabIndex = 2;
      this.btnDeleteSetup.Text = "Delete";
      this.btnDeleteSetup.UseVisualStyleBackColor = true;
      this.btnDeleteSetup.Click += new System.EventHandler(this.btnDeleteSetup_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 33);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(49, 13);
      this.label9.TabIndex = 1;
      this.label9.Text = "Setup ID";
      // 
      // tbSetupID
      // 
      this.tbSetupID.Location = new System.Drawing.Point(65, 30);
      this.tbSetupID.Name = "tbSetupID";
      this.tbSetupID.Size = new System.Drawing.Size(100, 20);
      this.tbSetupID.TabIndex = 0;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(285, 167);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(56, 13);
      this.label12.TabIndex = 51;
      this.label12.Text = "Comments";
      // 
      // rtbComment
      // 
      this.rtbComment.Location = new System.Drawing.Point(284, 183);
      this.rtbComment.Name = "rtbComment";
      this.rtbComment.Size = new System.Drawing.Size(387, 109);
      this.rtbComment.TabIndex = 52;
      this.rtbComment.Text = "";
      // 
      // testSystemBindingSource
      // 
      this.testSystemBindingSource.DataSource = typeof(JitterTestAnalyser.TestSystem);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(747, 493);
      this.Controls.Add(this.tabControl1);
      this.Name = "MainForm";
      this.Text = "Jitter Result Tool";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.testSystemBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.BindingSource testSystemBindingSource;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label lblState;
    private System.Windows.Forms.ProgressBar progressBarAdd;
    private System.Windows.Forms.Button btnFile;
    private System.Windows.Forms.TextBox tbFile;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox cbMeasureFrom;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cbConveyorSpeed;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cbImageLength;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cbProduct;
    private System.Windows.Forms.CheckBox cbFODEnabled;
    private System.Windows.Forms.CheckBox cbRawDataEnabled;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbMantaVersion;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbNovaVersion;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbSystem;
    private System.Windows.Forms.CheckBox cbStatistics;
    private System.Windows.Forms.CheckBox cbSurveilance;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbDbSize;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnDeleteSetup;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox tbSetupID;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cbOpcClient;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox cbNlcpPoints;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label label12;
    }
}

