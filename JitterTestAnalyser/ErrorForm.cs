using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JitterTestAnalyser
{
  public partial class ErrorForm : Form
  {
    public ErrorForm(string message, string innerExeption)
    {
      InitializeComponent();
      rtbErrorMsg.AppendText(message);
      rtbErrorMsg.AppendText(innerExeption);
    }

    private void btnAccept_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
