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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdminStartOver_Click(object sender, EventArgs e)
        {
            txtAdminOldPassword.Clear();
            txtAdminNewPassword1.Clear();
            txtAdminNewPassword2.Clear();
            txtAdminOldPassword.Focus();
        }

        private void btnAdminCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Application Password Update?", "Open SZMe",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
