using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_SZME_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm1Clear_Click(object sender, EventArgs e)
        {
            txtForm1Password.Clear();
            txtForm1Password.Focus();
        }

        private void buttonForm1Submit_Click(object sender, EventArgs e)
        {
            var pw = "prism";

            //FOR NOW, PASSWORD WILL BE PRISM.  ONCE DB IS UP, THEN IF PW IN DB IS NULL, THEN PROMPT FOR NEW PASSWORD.

            if (txtForm1Password.Text != "prism")
            {
                MessageBox.Show("Incorrect Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForm1Password.Clear();
                txtForm1Password.Focus();
                return;
            }

            Hide();
            SecondWindow sw = new SecondWindow();
            sw.Show();
        }
    }
}
