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
using System.Windows.Forms.VisualStyles;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class SecondWindow : Form
    {
        public static int RecordIndex { get; set; }
        public static int RecordId { get; set; }

        public SecondWindow()
        {
            InitializeComponent();

            cmb2ndFormProgramOrSite.Enabled = true;

            DisableAllButtons();
            DisableClipboardButtons();
            DisableStartOverCancelButtons();
            DisableAllTextBoxes();

            btn2ndFormNew.Enabled = true;
            btn2ndFormEdit.Enabled = true;
            btn2ndFormDelete.Enabled = true;

            RecordIndex = 0;

            var dataSet = GetPassword();
            var dsTable = dataSet.Tables[0];
            var count = dataSet.Tables[0].Rows.Count;
            RecordIndex = count == 0 ? 1 : count;

            Dictionary<int,RecordViewModel> recordDictionary = new Dictionary<int, RecordViewModel>();

            //LOAD RECORD DICTIONARY MINUS EXPIRED RECORDS
            for (int i = 0; i < count; i++)
            {
                RecordViewModel recordViewModel = new RecordViewModel()
                {
                    id = (int)dsTable.Rows[i]["PasswordId"],
                    password = dsTable.Rows[i]["PasswordPassword"].ToString(),
                    userId = dsTable.Rows[i]["PasswordUserId"].ToString(),
                    site = dsTable.Rows[i]["PasswordSite"].ToString(),
                    misc = dsTable.Rows[i]["PasswordMisc"].ToString()
                };

                recordDictionary.Add(i, new RecordViewModel
                {id = recordViewModel.id, password = recordViewModel.password, userId = recordViewModel.userId, site = recordViewModel.site,
                    misc = recordViewModel.misc
                });
            }

            //LOAD COMBO DICTIONARY AND BIND
            for (int i = 0; i < recordDictionary.Count; i++)
            {
                cmb2ndFormProgramOrSite.Items.Add(recordDictionary[i].site);
            }
            
            cmb2ndFormProgramOrSite.SelectedIndex = RecordIndex;

            cmb2ndFormProgramOrSite.DataSource = new BindingSource(recordDictionary, null);
            cmb2ndFormProgramOrSite.ValueMember = "Key";
            cmb2ndFormProgramOrSite.DisplayMember = "Value";

            //GET RECORD MATCHING SELECTED COMBO BOX
            var recordRecordId = recordDictionary.FirstOrDefault(x=>x.Value.site == cmb2ndFormProgramOrSite.SelectedText);

            //GET RECORD ID
            RecordId = recordRecordId.Value.id;
        }

        private void SecondWindow_Load(object sender, EventArgs e)
        {
            cmb2ndFormProgramOrSite.Focus();
        }

        private void btn2ndFormExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Application?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Clipboard.Clear();
                Environment.Exit(1);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            Admin ap = new Admin();
            ap.ShowDialog();
            Show();
        }

        private void btn2ndFormPastePw_Click(object sender, EventArgs e)
        {
            txt2ndFormPassword.Text = Clipboard.GetText();
        }

        private void btn2ndFormClearClipboard_Click(object sender, EventArgs e)
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

        private void btn2ndFormNew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add New Password?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cmb2ndFormProgramOrSite.Enabled = false;
                EnableAllButtons();
                EnableClipboardButtons();
                EnableStartOverCancelButtons();
                btn2ndFormEdit.Enabled = false;
                btn2ndFormDelete.Enabled = false;
                EnableAllTextBoxes();
                ClearAllTextBoxes();
            }
        }

        private void btn2ndFormStartOver_Click(object sender, EventArgs e)
        {
            txt2ndFormPassword.Clear();
        }

        private void DisableAllButtons()
        {
            btn2ndFormNew.Enabled = false;
            btn2ndFormEdit.Enabled = false;
            btn2ndFormDelete.Enabled = false;
            btn2ndFormSubmit.Enabled = false;
            btn2ndFormStartOver.Enabled = false;
            btn2ndFormCancel.Enabled = false;
            btn2ndFormPastePw.Enabled = false;
            btn2ndFormClearClipboard.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btn2ndFormNew.Enabled = true;
            btn2ndFormEdit.Enabled = true;
            btn2ndFormDelete.Enabled = true;
            btn2ndFormSubmit.Enabled = true;
            btn2ndFormStartOver.Enabled = true;
            btn2ndFormCancel.Enabled = true;
            btn2ndFormPastePw.Enabled = true;
            btn2ndFormClearClipboard.Enabled = true;
        }

        private void DisableAllTextBoxes()
        {
            txt2ndFormProgramSite.ReadOnly = true;
            txt2ndFormUserId.ReadOnly = true;
            txt2ndFormPassword.ReadOnly = true;
            txt2ndFormMisc.ReadOnly = true;
        }

        private void EnableAllTextBoxes()
        {
            txt2ndFormProgramSite.ReadOnly = false;
            txt2ndFormUserId.ReadOnly = false;
            txt2ndFormPassword.ReadOnly = false;
            txt2ndFormMisc.ReadOnly = false;
        }

        private void EnableStartOverCancelButtons()
        {
            btn2ndFormStartOver.Enabled = true;
            btn2ndFormCancel.Enabled = true;
        }
        private void DisableStartOverCancelButtons()
        {
            btn2ndFormStartOver.Enabled = false;
            btn2ndFormCancel.Enabled = false;
        }

        private void EnableClipboardButtons()
        {
            btn2ndFormPastePw.Enabled = true;
            btn2ndFormClearClipboard.Enabled = true;
        }
        private void DisableClipboardButtons()
        {
            btn2ndFormPastePw.Enabled = false;
            btn2ndFormClearClipboard.Enabled = false;
        }

        private void ClearAllTextBoxes()
        {
            txt2ndFormProgramSite.Clear();
            txt2ndFormUserId.Clear();
            txt2ndFormPassword.Clear();
            txt2ndFormMisc.Clear();
            txt2ndFormProgramSite.Focus();
        }

        private void btn2ndFormEdit_Click(object sender, EventArgs e)
        {
            cmb2ndFormProgramOrSite.Enabled = false;

            EnableAllButtons();
            EnableAllTextBoxes();
            EnableClipboardButtons();
            EnableStartOverCancelButtons();

            btn2ndFormNew.Enabled = false;
            btn2ndFormDelete.Enabled = false;
        }

        private void btn2ndFormCancel_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Cancel?", "Open SZMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DisableAllButtons();
                DisableAllTextBoxes();
                btn2ndFormNew.Enabled = true;
                btn2ndFormEdit.Enabled = true;
                btn2ndFormDelete.Enabled = true;
            }
        }

        private void btn2ndFormDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Password Record?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                cmb2ndFormProgramOrSite.Enabled = false;
                DisableAllButtons();
                DisableStartOverCancelButtons();
                DisableClipboardButtons();
            }
        }

        private void DeleteRecord(int index)
        {
            var passwordId = index;
        }

        private void btn2ndFormSubmit_Click(object sender, EventArgs e)
        {
            var ps = txt2ndFormProgramSite;
            var userId = txt2ndFormUserId;
            var pw = txt2ndFormPassword;
            var misc = txt2ndFormMisc;

            if (string.IsNullOrEmpty(ps.Text))
            {
                MessageBox.Show("Please Enter Program / Site", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(userId.Text.Trim()))
            {
                MessageBox.Show("User ID is Blank.  Enter 'None' if User Id is not needed.", "Open SZMe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(pw.Text.Trim()))
            {
                MessageBox.Show("Please Enter Password", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pw.Text.Length < 5)
            {
                DialogResult result = MessageBox.Show("Is Passsword supposed to be less than 5 characters?", "Open SZMe", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    txt2ndFormPassword.Focus();
                }
            }

            DialogResult submitResult = MessageBox.Show("Save Password Record?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (submitResult == DialogResult.Yes)
            {
                //ADD NEW RECORD
                if (btn2ndFormNew.Enabled)
                {
                    SqlConnection connection;
                    SqlCommand command;
                    string sql;

                    var connectionString = Settings.Default.OpenSZMeDbConnectionString;

                    connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();

                        sql = "INSERT INTO PasswordsTable (PasswordPassword,PasswordUserId,PasswordSite,PasswordMisc,IsEnabled) VALUES ('" + pw.Text.Trim() + "', " + userId.Text.Trim() + "','" + ps.Text.Trim() + "','" + misc + "',true)";
                        command = new SqlCommand(sql, connection);
                        command.Dispose();
                        connection.Close();

                        MessageBox.Show("Password Added", "Open SZMe", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        DisableAllButtons();
                        DisableAllTextBoxes();
                        DisableClipboardButtons();
                        DisableStartOverCancelButtons();

                        btn2ndFormNew.Enabled = true;
                        btn2ndFormEdit.Enabled = true;
                        btn2ndFormDelete.Enabled = true;

                        cmb2ndFormProgramOrSite.Focus();

                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Open Connection", "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (btn2ndFormEdit.Enabled)
                {
                    SqlConnection connection;
                    SqlCommand command;
                    string sql;

                    var connectionString = Settings.Default.OpenSZMeDbConnectionString;

                    connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();

                        sql = "UPDATE PasswordsTable SET PasswordPassword = '" + pw.Text.Trim() + "', PasswordUserId = '"+ userId.Text.Trim() + "', PasswordSite = '"+ps.Text.Trim() + "', PasswordMisc = '"+misc.Text.Trim() + "', IsEnabled = True WHERE PasswordId = " + RecordIndex;
                        command = new SqlCommand(sql, connection);
                        command.Dispose();
                        connection.Close();

                        MessageBox.Show("Password Updated", "Open SZMe", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        DisableAllButtons();
                        DisableAllTextBoxes();
                        DisableClipboardButtons();
                        DisableStartOverCancelButtons();

                        btn2ndFormNew.Enabled = true;
                        btn2ndFormEdit.Enabled = true;
                        btn2ndFormDelete.Enabled = true;

                        cmb2ndFormProgramOrSite.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Open Connection!!","Open SZMe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
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

                sql = "Select * from PasswordsTable Where IsEnable = true";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "PasswordsTable");
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

    public class RecordViewModel
    {
        public int id { get; set; }
        public string password { get; set; }
        public string userId { get; set; }
        public string site { get; set; }
        public string misc { get; set; }
    }
}
