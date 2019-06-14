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
    public partial class InitialLogin : Form
    {
        public InitialLogin()
        {
            InitializeComponent();
            var version = Debugger.IsAttached ? "Debug" : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            labelVersion.Text = "Version: " + version;
        }

        private void txtInitialPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtInitialPassword.Text))
                {
                    MessageBox.Show("Please Enter a Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInitialPassword.Focus();
                    return;
                }

                if (txtInitialPassword.Text.Length < 5)
                {
                    MessageBox.Show("Password Must Be 5 or More Characters", "Open SZMe", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtInitialPassword.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtQuestion1.Text))
                {
                    MessageBox.Show("Please Enter Question #1", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuestion1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAnswer1.Text))
                {
                    MessageBox.Show("Please Enter Answer #1", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnswer1.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtQuestion2.Text))
                {
                    MessageBox.Show("Please Enter Question #2", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuestion2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAnswer2.Text))
                {
                    MessageBox.Show("Please Enter Answer #2", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnswer2.Focus();
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

                    sql = "INSERT INTO LoginTable (" +
                          "LoginPassword," +
                          "LoginQuestionOne," +
                          "LoginAnswerOne," +
                          "LoginQuestionTwo," +
                          "LoginAnswerTwo) VALUES ('" + 
                          txtInitialPassword.Text.Trim() + "','"+
                          txtQuestion1.Text.Trim() + "','"+
                          txtAnswer1.Text.Trim() + "','"+
                          txtQuestion2.Text.Trim() + "','"+
                          txtAnswer2.Text.Trim() + "')";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();

                    MessageBox.Show("Initial Set-Up Complete", "Open SZMe", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Connect to Database","Open SZMe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnInitialLoginCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Set Up?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
