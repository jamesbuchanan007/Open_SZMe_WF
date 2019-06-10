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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm1Clear_Click(object sender, EventArgs e)
        {
            txtForm1Password.Clear();
            txtForm1Password.Focus();
        }

        private void buttonForm1Submit_Click(object sender, EventArgs e)
        {
            var pw = "";

            //FOR NOW, PASSWORD WILL BE PRISM.  ONCE DB IS UP, THEN IF PW IN DB IS NULL, THEN PROMPT FOR NEW PASSWORD.

            if (!string.IsNullOrEmpty(txtForm1Password.Text))
            {
                MessageBox.Show("Incorrect Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForm1Password.Clear();
                txtForm1Password.Focus();
                return;
            }

            Hide();
            SecondWindow sw = new SecondWindow();
            sw.Show();
        }

        private void txtForm1Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var pw = "prism";

                //FOR NOW, PASSWORD WILL BE PRISM.  ONCE DB IS UP, THEN IF PW IN DB IS NULL, THEN PROMPT FOR NEW PASSWORD.
                if (!string.IsNullOrEmpty(txtForm1Password.Text))
                {
                    MessageBox.Show("Incorrect Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtForm1Password.Clear();
                    txtForm1Password.Focus();
                    return;
                }

                Hide();
                SecondWindow sw = new SecondWindow();
                sw.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CHANGE TO TRUE PRIOR TO PUBLISH
            bool isInitialLogin = false;

            while (isInitialLogin)
            {
                var password = GetPassword();

                if (password.Tables[0].Rows.Count == 0)
                Hide();
                InitialLogin il = new InitialLogin();
                il.ShowDialog();

                password = GetPassword();
                if (password.Tables[0].Rows.Count > 0) isInitialLogin = false;
            }
            Show();
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
    }
}
