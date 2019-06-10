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

namespace Open_SZME_WF
{
    public partial class InitialLogin : Form
    {
        public InitialLogin()
        {
            InitializeComponent();
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

                    sql = "INSERT INTO LoginTable (LoginPassword) VALUES ('" + txtInitialPassword.Text + "')";
                    command = new SqlCommand(sql, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "LoginTable");
                    adapter.Dispose();
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
                Environment.Exit(1);
            }
        }
    }
}
