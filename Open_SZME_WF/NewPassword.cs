using System;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Windows.Forms;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
            var version = Debugger.IsAttached
                ? "Debug"
                : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            labelVersion.Text = "Version: " + version;
        }

        private void btnSaveSetUp_Click(object sender, EventArgs e)
        {
            var pw = txtNewPassword.Text.Trim();
            if (string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("Enter New Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection;
            SqlCommand command;
            string sql;

            var connectionString = Settings.Default.OpenSZMeDbConnectionString;


            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "UPDATE LoginTable SET LoginPassword = '" + pw +
                      "' WHERE LoginId in (Select TOP 1 LoginId from LoginTable ORDER BY LoginId Desc)";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Password Updated", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
