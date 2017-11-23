namespace JitterTestAnalyser
{
  partial class ErrorForm
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
      this.btnAccept = new System.Windows.Forms.Button();
      this.rtbErrorMsg = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // btnAccept
      // 
      this.btnAccept.Location = new System.Drawing.Point(366, 226);
      this.btnAccept.Name = "btnAccept";
      this.btnAccept.Size = new System.Drawing.Size(75, 23);
      this.btnAccept.TabIndex = 1;
      this.btnAccept.Text = "OK";
      this.btnAccept.UseVisualStyleBackColor = true;
      this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
      // 
      // rtbErrorMsg
      // 
      this.rtbErrorMsg.Location = new System.Drawing.Point(11, 9);
      this.rtbErrorMsg.Name = "rtbErrorMsg";
      this.rtbErrorMsg.Size = new System.Drawing.Size(429, 208);
      this.rtbErrorMsg.TabIndex = 2;
      this.rtbErrorMsg.Text = "";
      // 
      // ErrorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(453, 261);
      this.Controls.Add(this.rtbErrorMsg);
      this.Controls.Add(this.btnAccept);
      this.Name = "ErrorForm";
      this.Text = "Error";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAccept;
    private System.Windows.Forms.RichTextBox rtbErrorMsg;

  }
}