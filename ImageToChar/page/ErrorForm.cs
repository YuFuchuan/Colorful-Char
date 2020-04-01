using System;
using System.Windows.Forms;

namespace ImageToChar.page
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SetError(string error)
        {
            this.label1.Text = error;
        }
    }
}
