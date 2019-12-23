using System;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string version;
            InitializeComponent();
            version = Debugger.IsAttached ? "Debug" : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

            labelVersion.Text = "Version: " + version;
        }

        #region Clear Form
        private void btnForm1Clear_Click(object sender, EventArgs e)
        {
            txtForm1Password.Clear();
            txtForm1Password.Focus();
        }

        #endregion

        #region Login Form
        private void Login()
        {
            var pw = GetLoginPassword();
            if (string.IsNullOrEmpty(txtForm1Password.Text))
            {
                MessageBox.Show("Enter Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForm1Password.Focus();
                return;
            }

            var goodHash = Settings.Default.Password;
            var pwText = txtForm1Password.Text;
            var passwordsMatch = PasswordStorage.PasswordStorage.VerifyPassword(pwText, goodHash);

            if (passwordsMatch)
            {
                Hide();
                SecondWindow sw = new SecondWindow();
                sw.StartPosition = FormStartPosition.CenterParent;
                sw.Show(this);
            }
            else
            {
                MessageBox.Show("Passwords Do Not Match", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForm1Password.Clear();
                txtForm1Password.Focus();
            }
        }

        #endregion

        #region Submit

        private void buttonForm1Submit_Click(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #region Press Enter

        private void txtForm1Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        #endregion

        #region Form Load

        private void Form1_Load(object sender, EventArgs e)
        {
            while (string.IsNullOrEmpty(Settings.Default.Password))
            {
                var il = new InitialLogin
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                il.ShowDialog(this);
            }

            Show();
        }


        #endregion

        #region Get Login Password

        public string GetLoginPassword()
        {
            return Settings.Default.Password;
        }

        #endregion

        #region Forgotten Password

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.StartPosition = FormStartPosition.CenterParent;
            fp.Show(this);
        }

        #endregion
    }
}
