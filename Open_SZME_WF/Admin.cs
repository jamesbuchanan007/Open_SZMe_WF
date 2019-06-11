using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Open_SZME_WF.Properties;
using System.Security.Cryptography;

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

        private void btnAdminSubmit_Click(object sender, EventArgs e)
        {
            var loginPwDataSet = GetPassword();
            if (loginPwDataSet.Tables[0].Rows.Count == 0) return;

            var dbPw = loginPwDataSet.Tables[0].Rows[0]["LoginPassword"].ToString();

            var oldPw = txtAdminOldPassword;
            var pw1 = txtAdminNewPassword1;
            var pw2 = txtAdminNewPassword2;

            if (string.IsNullOrEmpty(oldPw.Text))
            {
                MessageBox.Show("Enter Old Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldPw.Focus();
            }
            if (string.IsNullOrEmpty(pw1.Text))
            {
                MessageBox.Show("Enter New Password 1", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pw1.Focus();
            }
            if (string.IsNullOrEmpty(pw2.Text))
            {
                MessageBox.Show("Enter New Password 2", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pw2.Focus();
            }

            if (oldPw.Text.Trim() != dbPw)
            {
                MessageBox.Show("Old Password Does Not Match!!", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                oldPw.Clear();
                oldPw.Focus();
            }

            if (pw1.Text.Trim() != pw2.Text.Trim())
            {
                MessageBox.Show("New Password 1 Does Not Match New Password 2!!", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                pw1.Clear();
                pw2.Clear();
                pw1.Focus();
            }

            if (oldPw.Text == dbPw && pw1.Text.Trim() == pw2.Text.Trim())
            {
                AddNewPassword(pw1.Text);
            }
        }

        public void AddNewPassword(string newPw)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql;

            var connectionString = Settings.Default.OpenSZMeDbConnectionString;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "Insert Into LoginTable (LoginPassword) Values ('" + newPw + "')";
                command = new SqlCommand(sql, connection);
                command.Dispose();
                connection.Close();

                MessageBox.Show("Password Updated", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                sql = "Select TOP 1 * from LoginTable ORDER BY LoginTableId Desc";
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
            Clipboard.SetText(txtAdminRandomPassword.Text);
            Hide();
        }

        private void btnAdminClearClipboard_Click(object sender, EventArgs e)
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
