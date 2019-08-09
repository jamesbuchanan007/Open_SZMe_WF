using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using FileHelpers;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            string version;
            InitializeComponent();
            version = Debugger.IsAttached ? "Debug" : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

            labelVersion.Text = "Version: " + version;
        }
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fbd.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cancel?", "Open SZMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                var secondWindow = new SecondWindow { StartPosition = FormStartPosition.CenterParent };
                secondWindow.Show(this);
            }

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("File Path is Missing", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dsLogin = new DataSet();
            DataSet dsPasswords = new DataSet();
            string sql;

            var connectionString = Settings.Default.OpenSZMeDbConnectionString;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "SELECT * FROM LoginTable";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dsLogin, "LoginTable");
                adapter.Dispose();
                command.Dispose();

                sql = "SELECT * FROM PasswordsTable";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dsPasswords, "PasswordsTable");
                adapter.Dispose();
                command.Dispose();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var loginList = new List<Login>();
            var passwordList = new List<Password>();

            for (int i = 0; i < dsLogin.Tables[0].Rows.Count; i++)
            {
                loginList.Add(new Login
                {
                    LoginId = (int)dsLogin.Tables[0].Rows[i]["LoginId"],
                    LoginPassword = (string)dsLogin.Tables[0].Rows[i]["LoginPassword"],
                    LoginQuestionOne = (string)dsLogin.Tables[0].Rows[i]["LoginQuestionOne"],
                    LoginAnswerOne = (string)dsLogin.Tables[0].Rows[i]["LoginAnswerOne"],
                    LoginQuestionTwo = (string)dsLogin.Tables[0].Rows[i]["LoginQuestionTwo"],
                    LoginAnswerTwo = (string)dsLogin.Tables[0].Rows[i]["LoginAnswerTwo"]
                });
            }

            for (int i = 0; i < dsPasswords.Tables[0].Rows.Count; i++)
            {
                passwordList.Add(new Password
                {
                    PasswordId = (int)dsLogin.Tables[0].Rows[i]["PasswordId"],
                    PasswordSite = (string)dsLogin.Tables[0].Rows[i]["PasswordSite"],
                    PasswordPassword = (string)dsLogin.Tables[0].Rows[i]["PasswordPassword"],
                    PasswordUserId = (string)dsLogin.Tables[0].Rows[i]["PasswordUserId"],
                    PasswordMisc = (string)dsLogin.Tables[0].Rows[i]["PasswordMisc"],
                    IsEnabled = (int)dsLogin.Tables[0].Rows[i]["IsEnabled"]
                });
            }

            var engineLogin = new FileHelperAsyncEngine<Login>();
            var enginePassword = new FileHelperAsyncEngine<Password>();

            try
            {
                using (engineLogin.BeginWriteFile(txtFilePath.Text + @"\LoginData.txt"))
                {
                    foreach (var row in loginList)
                    {
                        engineLogin.WriteNext(row);
                    }
                }
                MessageBox.Show("Login Data Backup Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not back up Login Data", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                using (enginePassword.BeginWriteFile(txtFilePath.Text + @"\PasswordData.txt"))
                {
                    foreach (var row in passwordList)
                    {
                        enginePassword.WriteNext(row);
                    }
                }
                MessageBox.Show("Password Data Backup Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not back up Login Data", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        [DelimitedRecord(",")]
        public class Login
        {
            public int LoginId { get; set; }
            public string LoginPassword { get; set; }
            public string LoginQuestionOne { get; set; }
            public string LoginAnswerOne { get; set; }
            public string LoginQuestionTwo { get; set; }
            public string LoginAnswerTwo { get; set; }
        }

        [DelimitedRecord(",")]
        public class Password
        {
            public int PasswordId { get; set; }
            public string PasswordSite { get; set; }
            public string PasswordPassword { get; set; }
            public string PasswordUserId { get; set; }
            public string PasswordMisc { get; set; }
            public int IsEnabled { get; set; }
        }
    }

}
