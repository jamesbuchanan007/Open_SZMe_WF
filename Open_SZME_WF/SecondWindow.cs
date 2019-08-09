using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Open_SZME_WF.Properties;

namespace Open_SZME_WF
{
    public partial class SecondWindow : Form
    {
        public static int RecordIndex { get; set; }
        public static int RecordId { get; set; }
        public static Dictionary<int, RecordViewModel> RecordDictionary { get; set; }
        public static Dictionary<int, string> ComboBoxDictionary { get; set; }

        public SecondWindow()
        {
            InitializeComponent();
            var version = Debugger.IsAttached ? "Debug" : ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            labelVersion.Text = "Version: " + version;
            RecordIndex = 0;
            RecordId = 0;
            RecordDictionary = new Dictionary<int, RecordViewModel>();
            ComboBoxDictionary = new Dictionary<int, string>();


            Reset();
            ReloadRecordAndComboBox();

            if (cmb2ndFormProgramOrSite.Items.Count == 0)
            {
                DisableAllButtons();
                btn2ndFormNew.Enabled = true;
            }

            var backupDataSet = GetBackupStatus();

            var backupDate = (DateTime)backupDataSet.Tables[0].Rows[0]["BackupDate"];
            var backupCompleted = (bool)backupDataSet.Tables[0].Rows[0]["BackupCompleted"];

            if (!backupCompleted)
            {
                var result = MessageBox.Show("Last Backup Not Completed.  Retry?", "Open SZMe", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var buf = new BackupForm {StartPosition = FormStartPosition.CenterParent};
                    buf.ShowDialog(this);
                }

               
            }

            var dateDiff = DateTime.Compare(backupDate, DateTime.Today);
            if (dateDiff > 7)
            {
                var result = MessageBox.Show("Last Backup Longer than 7 days.  Backup Now?", "OpenSZMe", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    var buf = new BackupForm {StartPosition = FormStartPosition.CenterParent};
                    buf.ShowDialog(this);
                }

            }
        }

        private DataSet GetBackupStatus()
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

                sql = "SELECT TOP 1 * FROM BackupTable ORDER BY BackupId desc";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "BackupTable");
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

        //LOAD COMBOBOX, BIND, AND SET RECORD ID
        private void LoadComboBoxDictionary()
        {
            if (RecordDictionary.Count == 0) return;
            ComboBoxDictionary.Clear();

            //LOAD COMBO DICTIONARY AND BIND
            for (int i = 0; i < RecordDictionary.Count; i++)
            {
                ComboBoxDictionary.Add(i, RecordDictionary[i].Site);
            }

            //cmb2ndFormProgramOrSite.SelectedIndex = RecordIndex+1;

            cmb2ndFormProgramOrSite.DataSource = new BindingSource(ComboBoxDictionary, null);
            cmb2ndFormProgramOrSite.ValueMember = "Key";
            cmb2ndFormProgramOrSite.DisplayMember = "Value";

            SetRecordId();
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            txt2ndFormProgramSite.Text = RecordDictionary[RecordIndex].Site;
            txt2ndFormUserId.Text = RecordDictionary[RecordIndex].UserId;
            txt2ndFormPassword.Text = RecordDictionary[RecordIndex].Password;
            txt2ndFormMisc.Text = RecordDictionary[RecordIndex].Misc;
        }

        //SET RECORD ID
        private void SetRecordId()
        {
            //GET INDEX FOR COMBOBOX
            var comboBoxIndex = cmb2ndFormProgramOrSite.SelectedIndex;

            //GET RECORD MATCHING SELECTED COMBO BOX INDEX
            var record = RecordDictionary.ElementAt(comboBoxIndex);

            if (RecordDictionary.Count <= 1)
            {
                RecordId = 0;
                return;
            }

            //GET RECORD ID
            RecordId = record.Value.Id;
        }

        //LOAD RECORD DICTIONARY MINUS EXPIRED RECORDS
        public void LoadRecordDictionary(DataSet dataSet)
        {
            var dsTable = dataSet.Tables[0];
            var count = dataSet.Tables[0].Rows.Count;

            RecordDictionary.Clear();

            for (int i = 0; i < count; i++)
            {
                RecordViewModel recordViewModel = new RecordViewModel()
                {
                    Id = (int)dsTable.Rows[i]["PasswordId"],
                    Password = dsTable.Rows[i]["PasswordPassword"].ToString(),
                    UserId = dsTable.Rows[i]["PasswordUserId"].ToString(),
                    Site = dsTable.Rows[i]["PasswordSite"].ToString(),
                    Misc = dsTable.Rows[i]["PasswordMisc"].ToString()
                };

                RecordDictionary.Add(i, new RecordViewModel
                {
                    Id = recordViewModel.Id,
                    Password = recordViewModel.Password,
                    UserId = recordViewModel.UserId,
                    Site = recordViewModel.Site,
                    Misc = recordViewModel.Misc
                });
            }
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
            ap.StartPosition = FormStartPosition.CenterParent;
            ap.ShowDialog(this);
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

        private void RemovePasswordChar()
        {
            txt2ndFormUserId.UseSystemPasswordChar = false;
            txt2ndFormPassword.UseSystemPasswordChar = false;
            txt2ndFormMisc.UseSystemPasswordChar = false;
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
                btn2ndFormEdit.Enabled = false;
                btn2ndFormDelete.Enabled = false;
                EnableAllTextBoxes();
                ClearAllTextBoxes();
                RemovePasswordChar();
            }
        }

        private void btn2ndFormStartOver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Clear Form?", "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txt2ndFormPassword.Clear();
                txt2ndFormMisc.Clear();
                txt2ndFormProgramSite.Clear();
                txt2ndFormProgramSite.Clear();
            }

            txt2ndFormProgramSite.Focus();
        }

        private void DisableAllButtons()
        {
            btn2ndFormNew.Enabled = false;
            btn2ndFormEdit.Enabled = false;
            btn2ndFormDelete.Enabled = false;
            btn2ndFormSubmit.Enabled = false;
            btn2ndFormPastePw.Enabled = false;
            btnPasteSite.Enabled = false;
            btnPasteUserId.Enabled = false;
            btnPasteMisc.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btn2ndFormNew.Enabled = true;
            btn2ndFormEdit.Enabled = true;
            btn2ndFormDelete.Enabled = true;
            btn2ndFormSubmit.Enabled = true;
            btn2ndFormPastePw.Enabled = true;
            btnPasteSite.Enabled = true;
            btnPasteUserId.Enabled = true;
            btnPasteMisc.Enabled = true;
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

        private void EnableClipboardButtons()
        {
            btn2ndFormPastePw.Enabled = true;
        }
        private void DisableClipboardButtons()
        {
            btn2ndFormPastePw.Enabled = false;
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
            RecordIndex = cmb2ndFormProgramOrSite.SelectedIndex;
            var record = RecordDictionary.ElementAt(RecordIndex);
            var value = record.Value;
            var question = "Edit Record for '" + value.Site + "'?";

            DialogResult result = MessageBox.Show(question, "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cmb2ndFormProgramOrSite.Enabled = false;

                EnableAllButtons();
                EnableAllTextBoxes();
                EnableClipboardButtons();

                btn2ndFormNew.Enabled = false;
                btn2ndFormDelete.Enabled = false;

                RemovePasswordChar();
            }

        }

        private void btn2ndFormDelete_Click(object sender, EventArgs e)
        {
            RecordIndex = cmb2ndFormProgramOrSite.SelectedIndex;
            var record = RecordDictionary.ElementAt(RecordIndex);
            var value = record.Value;
            var question = "Delete Record for '" + value.Site + "'?";

            DialogResult result = MessageBox.Show(question, "Open SZMe", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteRecord();
                Reset();
                ReloadRecordAndComboBox();
            }
        }

        private void DeleteRecord()
        {
            SqlConnection connection;
            SqlCommand command;
            string sql;

            var connectionString = Settings.Default.OpenSZMeDbConnectionString;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                sql = "UPDATE PasswordsTable SET IsEnabled = 0 WHERE PasswordId = " + RecordId;
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Password Record Expired", "Open SZMe", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                DialogResult result = MessageBox.Show("Is Password supposed to be less than 5 characters?", "Open SZMe", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    txt2ndFormPassword.Focus();
                }
            }

            //ADD NEW RECORD
            if (btn2ndFormNew.Enabled)
            {
                //NEED TO MVOE THIS INSIDE 'ADD NEW RECORD'
                var questionSave = "Save Record for '" + ps.Text + "'?";

                DialogResult submitResult = MessageBox.Show(questionSave, "Open SZMe", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (submitResult == DialogResult.Yes)
                {
                    SqlConnection connection;
                    SqlCommand command;
                    string sql;

                    var connectionString = Settings.Default.OpenSZMeDbConnectionString;

                    connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();

                        sql = "INSERT INTO PasswordsTable " +
                              "(PasswordSite," +
                              "PasswordPassword," +
                              "PasswordUserId," +
                              "PasswordMisc," +
                              "IsEnabled) " +
                              "VALUES ('" +
                              ps.Text.Trim() + "', '" +
                              pw.Text.Trim() + "','" +
                              userId.Text.Trim() + "','" +
                              misc.Text + "',1)";
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();

                        MessageBox.Show("Password Added", "Open SZMe", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Reset();

                    ReloadRecordAndComboBox();
                    cmb2ndFormProgramOrSite.SelectedIndex = ComboBoxDictionary.Count - 1;
                }

                return;
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

                    sql = "UPDATE PasswordsTable SET " +
                          "PasswordPassword = '" + pw.Text.Trim() + "', " +
                          "PasswordUserId = '" + userId.Text.Trim() + "', " +
                          "PasswordSite = '" + ps.Text.Trim() + "', " +
                          "PasswordMisc = '" + misc.Text.Trim() + "', " +
                          "IsEnabled = 1 " +
                          "WHERE PasswordId = " + RecordId;
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();

                    MessageBox.Show("Password Updated for " + RecordDictionary[RecordIndex].Site, "Open SZMe", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Reset();

                    ReloadRecordAndComboBox();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Open SZMe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reset();

                ReloadRecordAndComboBox();
                cmb2ndFormProgramOrSite.SelectedIndex = RecordIndex;
                return;
            }
            Reset();
        }

        private void ReloadRecordAndComboBox()
        {
            var dataSet = GetPassword();

            if (dataSet == null) return;
            LoadRecordDictionary(dataSet);
            LoadComboBoxDictionary();

        }

        private void Reset()
        {
            cmb2ndFormProgramOrSite.Enabled = true;
            cmb2ndFormProgramOrSite.Focus();

            DisableAllButtons();
            DisableAllTextBoxes();
            DisableClipboardButtons();

            btn2ndFormNew.Enabled = true;
            btn2ndFormEdit.Enabled = true;
            btn2ndFormDelete.Enabled = true;

            txt2ndFormUserId.UseSystemPasswordChar = true;
            txt2ndFormPassword.UseSystemPasswordChar = true;
            txt2ndFormMisc.UseSystemPasswordChar = true;
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

                sql = "Select * From PasswordsView Where IsEnabled = 1";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "PasswordsView");
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

        private void cmb2ndFormProgramOrSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordIndex = cmb2ndFormProgramOrSite.SelectedIndex;
            if (RecordDictionary.Count == 0) return;
            var record = RecordDictionary.ElementAt(RecordIndex);
            var value = record.Value;

            txt2ndFormProgramSite.Text = value.Site;
            txt2ndFormUserId.Text = value.UserId;
            txt2ndFormPassword.Text = value.Password;
            txt2ndFormMisc.Text = value.Misc;

            RecordId = value.Id;
        }

        private void btnAdminRPGToClip_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2ndFormPassword.Text)) { Clipboard.SetText(txt2ndFormPassword.Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Cancel?", "Open SZMe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ClearAllTextBoxes();
                Reset();
                ReloadRecordAndComboBox();
            }

        }

        private void btnPasteSite_Click(object sender, EventArgs e)
        {
            txt2ndFormProgramSite.Text = Clipboard.GetText();
        }

        private void btnCopyUserId_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2ndFormUserId.Text)) { Clipboard.SetText(txt2ndFormUserId.Text); }
        }

        private void btnPasteUserId_Click(object sender, EventArgs e)
        {
            txt2ndFormUserId.Text = Clipboard.GetText();
        }

        private void SecondWindow_KeyDown(object sender, KeyEventArgs e)
        {
            //KEYBOARD SHORTCUTS
            if (e.Control && e.KeyCode == Keys.S)
            {
                btn2ndFormSubmit_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                btn2ndFormNew_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                btn2ndFormEdit_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                btn2ndFormDelete_Click(sender, e);
            }
        }

        private void btnCopyMisc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2ndFormMisc.Text)) { Clipboard.SetText(txt2ndFormMisc.Text); }
        }

        private void btnPasteMisc_Click(object sender, EventArgs e)
        {
            txt2ndFormMisc.Text = Clipboard.GetText();
        }

        private void txt2ndFormUserId_MouseDown(object sender, MouseEventArgs e)
        {
            txt2ndFormUserId.UseSystemPasswordChar = false;
        }

        private void txt2ndFormUserId_MouseUp(object sender, MouseEventArgs e)
        {
            txt2ndFormUserId.UseSystemPasswordChar = true;
        }

        private void txt2ndFormPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txt2ndFormPassword.UseSystemPasswordChar = false;
        }

        private void txt2ndFormPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txt2ndFormPassword.UseSystemPasswordChar = true;
        }

        private void txt2ndFormMisc_MouseDown(object sender, MouseEventArgs e)
        {
            txt2ndFormMisc.UseSystemPasswordChar = false;
        }

        private void txt2ndFormMisc_MouseUp(object sender, MouseEventArgs e)
        {
            txt2ndFormMisc.UseSystemPasswordChar = true;
        }
    }

    public class RecordViewModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string Site { get; set; }
        public string Misc { get; set; }
    }
}
