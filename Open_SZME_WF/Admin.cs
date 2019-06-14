using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            var version = Debugger.IsAttached ? "Debug" : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            labelVersion.Text = "Version: " + version;

            var loadQA = GetPassword();
            if (loadQA.Tables[0].Rows.Count == 0) return;

            txtQuestion1.Text = loadQA.Tables[0].Rows[0]["LoginQuestionOne"].ToString();
            txtQuestion2.Text = loadQA.Tables[0].Rows[0]["LoginQuestionTwo"].ToString();
            txtAnswer1.Text = loadQA.Tables[0].Rows[0]["LoginAnswerOne"].ToString();
            txtAnswer2.Text = loadQA.Tables[0].Rows[0]["LoginAnswerTwo"].ToString();
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

        private void btnAdminSubmit_Click(object sender, EventArgs e)
        {
            var oldPw = txtAdminOldPassword;
            var pw1 = txtAdminNewPassword1;
            var pw2 = txtAdminNewPassword2;
            var q1 = txtQuestion1;
            var a1 = txtAnswer1;
            var q2 = txtQuestion2;
            var a2 = txtAnswer2;

            if (string.IsNullOrEmpty(oldPw.Text))
            {
                MessageBox.Show("Enter Old Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldPw.Focus();
                return;
            }
            if (string.IsNullOrEmpty(q1.Text))
            {
                MessageBox.Show("Enter Question #1", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                q1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(a1.Text))
            {
                MessageBox.Show("Enter Answer #1", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(q2.Text))
            {
                MessageBox.Show("Enter Question #2", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                q2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(a2.Text))
            {
                MessageBox.Show("Enter Answer #2", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a2.Focus();
                return;
            }

            //RETRIEVE PASSWORD
            var loginPwDataSet = GetPassword();
            if (loginPwDataSet.Tables[0].Rows.Count == 0) return;

            var dbPw = loginPwDataSet.Tables[0].Rows[0]["LoginPassword"].ToString();

            //CHECK IF USER PASSWORD MATCHES DB PASSWORD
            if (oldPw.Text.Trim() != dbPw)
            {
                MessageBox.Show("Old Password Does Not Match", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                oldPw.Clear();
                oldPw.Focus();
                return;
            }

            //CHECK NEW AND CONFIRMED PASSWORDS MATCH
            if (pw1.Text.Trim() != pw2.Text.Trim())
            {
                MessageBox.Show("New Password Does Not Match Confirmed Password!", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                pw1.Clear();
                pw2.Clear();
                pw1.Focus();
                return;
            }

            //ADD NEW PASSWORD AND QAs TO DB
            if (oldPw.Text == dbPw && pw1.Text.Trim() == pw2.Text.Trim())
            {
                //GET OLD AND NEW QUESTION, ANSWERS, and PASSWORD
                var q1Old = loginPwDataSet.Tables[0].Rows[0]["LoginQuestionOne"].ToString();
                var q1New = q1.Text.Trim();

                var a1Old = loginPwDataSet.Tables[0].Rows[0]["LoginAnswerOne"].ToString();
                var a1New = a1.Text.Trim().ToLower();

                var q2Old = loginPwDataSet.Tables[0].Rows[0]["LoginQuestionTwo"].ToString();
                var q2New = q2.Text.Trim();

                var a2Old = loginPwDataSet.Tables[0].Rows[0]["LoginAnswerTwo"].ToString();
                var a2New = a2.Text.Trim().ToLower();

                var pwOld = loginPwDataSet.Tables[0].Rows[0]["LoginPassword"].ToString();
                var pwNew = pw1.Text.Trim();

                //CHECK IF THEY WERE ALTERED
                var q1Changed = q1Old != q1New;
                var a1Changed = a1Old != a1New;
                var q2Changed = q2Old != q2New;
                var a2Changed = a2Old != a2New;

                var pw1Andpw2Empty = string.IsNullOrEmpty(pw1.Text.Trim()) && string.IsNullOrEmpty(pw2.Text.Trim());
                bool pwChanged;

                //IF PW1 AND PW2 ARE EMPTY, THEN USER WAS NOT TRYING TO UPDATE PASSWORD
                if (!pw1Andpw2Empty)
                {
                    pwChanged = pwOld != pwNew;
                }
                else
                {
                    pwChanged = false;
                }

                //PASS ALONG SO THAT MESSAGE IS MODIFIED TO REFLECT CHANGES
                var message = UpdateMessage(q1Changed, a1Changed, q2Changed, a2Changed, pwChanged);
                AddNewPassword(message);
            }
        }

        private string UpdateMessage(bool q1Changed, bool a1Changed, bool q2Changed, bool a2Changed, bool pwChanged)
        {
            var message = "";

            List<string> messageList = new List<string>();

            if (q1Changed) messageList.Add("Question #1");
            if (a1Changed) messageList.Add("Answer #1");
            if (q2Changed) messageList.Add("Question #2");
            if (a2Changed) messageList.Add("Answer #2");
            if (pwChanged) messageList.Add("Password");

            var listCount = messageList.Count;

            if (listCount == 0)
            {
                message = "Nothing Updated";
            }
            
            //ONE ITEM CHANGED
            if (listCount == 1)
            {
                message = messageList[0] + " has been updated";
            }

            //TWO ITEMS CHANGED
            if (listCount == 2)
            {
               message = messageList[0] + " and " + messageList[1] + " have been updated";
            }

            //THREE OR MORE ITEMS CHANGED
            if (listCount >= 3)
            {
                //GET LAST ITEM CHANGED
                var lastItemChanged = messageList[listCount - 1];

                //ADDS COMMAS
                for (int i = 0; i < listCount-1; i++)
                {
                    message = message + messageList[i] + ", ";
                }

                //ADDS THE 'AND'
                message = message + "and " + lastItemChanged + " have been updated";
            }
          
            return message;
        }

        public void AddNewPassword(string message)
        {
            var newPw = txtAdminNewPassword1.Text.Trim();
            var newQ1 = txtQuestion1.Text.Trim();
            var newA1 = txtAnswer1.Text.Trim().ToLower();
            var newQ2 = txtQuestion2.Text.Trim();
            var newA2 = txtAnswer2.Text.Trim().ToLower();

            var pwChanged = !string.IsNullOrEmpty(newPw);
            var dbPw = pwChanged ? newPw : txtAdminOldPassword.Text.Trim();

            SqlConnection connection;
            SqlCommand command;
            string sql;

            var connectionString = Settings.Default.OpenSZMeDbConnectionString;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Insert Into LoginTable (LoginPassword,LoginQuestionOne,LoginAnswerOne,LoginQuestionTwo,LoginAnswerTwo) Values ('" +
                      dbPw + "','" +
                      newQ1 + "','" +
                      newA1 + "','" +
                      newQ2 + "','" +
                      newA2 + "')";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show(message, "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet GetPassword()
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql;

            var connectionString = Settings.Default.OpenSZMeDbConnectionString;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Select TOP 1 * from LoginTable ORDER BY LoginId Desc";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "LoginTable");
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
        }

        private void btnAdminGenerate_Click(object sender, EventArgs e)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string validWithSpecial = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*$-+?_&=!%{}/@";

            var convert = int.TryParse(numericAdminNumCharacters.Text, out var numChar);

            if (!convert)
            {
                MessageBox.Show("Number of Characters must be a Number.", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                numericAdminNumCharacters.Text = "5";
                numericAdminNumCharacters.Focus();
                return;
            }

            if (!chkBxSpecialCharacter.Checked)
            {
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < numChar--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }

                txtAdminRandomPassword.Text = res.ToString();
            }
            else
            {
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < numChar--)
                {
                    res.Append(validWithSpecial[rnd.Next(validWithSpecial.Length)]);
                }

                txtAdminRandomPassword.Text = res.ToString();
            }
        }

        private void btnAdminMax_Click(object sender, EventArgs e)
        {
            numericAdminNumCharacters.Text = "32";
        }

        private void btnAdminRPGToClip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdminRandomPassword.Text)) return;

            Clipboard.SetText(txtAdminRandomPassword.Text);
            Hide();
        }
    }
}
