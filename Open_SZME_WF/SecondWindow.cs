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
                Application.Exit();
            }
        }
    }
}
