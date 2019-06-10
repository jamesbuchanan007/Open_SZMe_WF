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
    public partial class SecondWindow : Form
    {
        public SecondWindow()
        {
            InitializeComponent();
        }
        
        private void SecondWindow_Load(object sender, EventArgs e)
        {
            cmbSecondFormProgramOrSite.Focus();
        }

        private void btnSecondFormExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Application?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Clipboard.Clear();
                Environment.Exit(1);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            Admin ap = new Admin();
            ap.ShowDialog();
            Show();
        }

        private void btn2ndFormPastePw_Click(object sender, EventArgs e)
        {
            txtSecondFormPassword.Text = Clipboard.GetText();
        }

        private void btn2ndFormClearClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                MessageBox.Show("Clipboard is Cleared", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception eg)
            {
                MessageBox.Show(eg.ToString());
            }
        }
    }
}
