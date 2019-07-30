using System;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Windows.Forms;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class ForgotPassword : Form
    {
        public static string AnswerOne { get; set; }
        public static string AnswerTwo { get; set; }

        public ForgotPassword()
        {
            InitializeComponent();

            var version = Debugger.IsAttached
                ? "Debug"
                : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            labelVersion.Text = "Version: " + version;

            AnswerOne = "";
            AnswerTwo = "";

            var ds = GetQuestions();
            var column = ds.Tables[0].Rows[0];

            txtQuestion1.Text = column["LoginQuestionOne"].ToString();
            txtQuestion2.Text = column["LoginQuestionTwo"].ToString();
            AnswerOne = column["LoginAnswerOne"].ToString();
            AnswerTwo = column["LoginAnswerTwo"].ToString();
        }

        private DataSet GetQuestions()
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
                MessageBox.Show(ex.ToString(), "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var a1 = txtAnswer1.Text.Trim().ToLower();
            var a2 = txtAnswer2.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(a1))
            {
                MessageBox.Show("Please Enter Answer #1", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(a2))
            {
                MessageBox.Show("Please Enter Answer #2", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a1 != AnswerOne)
            {
                MessageBox.Show("Answer #1 Does Not Match", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a2 != AnswerTwo)
            {
                MessageBox.Show("Answer #2 Does Not Match", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            NewPassword np = new NewPassword();
            np.StartPosition = FormStartPosition.CenterParent;
            np.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Cancel Password Reset?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Hide();
                Form1 f1 =new Form1();
                f1.StartPosition = FormStartPosition.CenterParent;
                f1.Show(this);
            }
        }
    }
}
