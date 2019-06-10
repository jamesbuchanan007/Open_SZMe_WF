namespace Open_SZME_WF
{
    partial class SecondWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSecondFormProgramOrSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecondFormPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSecondFormAdd = new System.Windows.Forms.Button();
            this.btnSecondFormEdit = new System.Windows.Forms.Button();
            this.btnSecondFormDelete = new System.Windows.Forms.Button();
            this.btnSecondFormExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSecondFormUserId = new System.Windows.Forms.TextBox();
            this.txtSecondFormMisc = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSecondFormProgramOrSite
            // 
            this.cmbSecondFormProgramOrSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSecondFormProgramOrSite.FormattingEnabled = true;
            this.cmbSecondFormProgramOrSite.Location = new System.Drawing.Point(118, 128);
            this.cmbSecondFormProgramOrSite.Name = "cmbSecondFormProgramOrSite";
            this.cmbSecondFormProgramOrSite.Size = new System.Drawing.Size(236, 21);
            this.cmbSecondFormProgramOrSite.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbSecondFormProgramOrSite, "Select Program / Site");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program / Site";
            // 
            // txtSecondFormPassword
            // 
            this.txtSecondFormPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondFormPassword.Location = new System.Drawing.Point(117, 233);
            this.txtSecondFormPassword.Name = "txtSecondFormPassword";
            this.txtSecondFormPassword.ReadOnly = true;
            this.txtSecondFormPassword.Size = new System.Drawing.Size(237, 20);
            this.txtSecondFormPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSecondFormPassword, "Current Password");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btnSecondFormAdd
            // 
            this.btnSecondFormAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecondFormAdd.BackColor = System.Drawing.Color.Green;
            this.btnSecondFormAdd.FlatAppearance.BorderSize = 0;
            this.btnSecondFormAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormAdd.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormAdd.Location = new System.Drawing.Point(19, 126);
            this.btnSecondFormAdd.Name = "btnSecondFormAdd";
            this.btnSecondFormAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormAdd.TabIndex = 5;
            this.btnSecondFormAdd.Text = "New";
            this.toolTip1.SetToolTip(this.btnSecondFormAdd, "Add New Password Record");
            this.btnSecondFormAdd.UseVisualStyleBackColor = false;
            // 
            // btnSecondFormEdit
            // 
            this.btnSecondFormEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecondFormEdit.BackColor = System.Drawing.Color.Green;
            this.btnSecondFormEdit.FlatAppearance.BorderSize = 0;
            this.btnSecondFormEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormEdit.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormEdit.Location = new System.Drawing.Point(19, 155);
            this.btnSecondFormEdit.Name = "btnSecondFormEdit";
            this.btnSecondFormEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormEdit.TabIndex = 6;
            this.btnSecondFormEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnSecondFormEdit, "Edit Password Record");
            this.btnSecondFormEdit.UseVisualStyleBackColor = false;
            // 
            // btnSecondFormDelete
            // 
            this.btnSecondFormDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecondFormDelete.BackColor = System.Drawing.Color.Green;
            this.btnSecondFormDelete.FlatAppearance.BorderSize = 0;
            this.btnSecondFormDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormDelete.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormDelete.Location = new System.Drawing.Point(19, 184);
            this.btnSecondFormDelete.Name = "btnSecondFormDelete";
            this.btnSecondFormDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormDelete.TabIndex = 7;
            this.btnSecondFormDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnSecondFormDelete, "Delete Password Record");
            this.btnSecondFormDelete.UseVisualStyleBackColor = false;
            // 
            // btnSecondFormExit
            // 
            this.btnSecondFormExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecondFormExit.BackColor = System.Drawing.Color.Red;
            this.btnSecondFormExit.FlatAppearance.BorderSize = 0;
            this.btnSecondFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormExit.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormExit.Location = new System.Drawing.Point(279, 415);
            this.btnSecondFormExit.Name = "btnSecondFormExit";
            this.btnSecondFormExit.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormExit.TabIndex = 8;
            this.btnSecondFormExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnSecondFormExit, "Exit Application");
            this.btnSecondFormExit.UseVisualStyleBackColor = false;
            this.btnSecondFormExit.Click += new System.EventHandler(this.btnSecondFormExit_Click);
            // 
            // txtSecondFormUserId
            // 
            this.txtSecondFormUserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondFormUserId.Location = new System.Drawing.Point(117, 180);
            this.txtSecondFormUserId.Name = "txtSecondFormUserId";
            this.txtSecondFormUserId.ReadOnly = true;
            this.txtSecondFormUserId.Size = new System.Drawing.Size(237, 20);
            this.txtSecondFormUserId.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtSecondFormUserId, "Current User Id");
            // 
            // txtSecondFormMisc
            // 
            this.txtSecondFormMisc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondFormMisc.Location = new System.Drawing.Point(19, 285);
            this.txtSecondFormMisc.Multiline = true;
            this.txtSecondFormMisc.Name = "txtSecondFormMisc";
            this.txtSecondFormMisc.ReadOnly = true;
            this.txtSecondFormMisc.Size = new System.Drawing.Size(335, 105);
            this.txtSecondFormMisc.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtSecondFormMisc, "Miscellaneous Notes");
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(19, 415);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin";
            this.toolTip1.SetToolTip(this.btnAdmin, "Update Application Password");
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Id";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Miscellaneous";
            // 
            // SecondWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(374, 456);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecondFormMisc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecondFormUserId);
            this.Controls.Add(this.btnSecondFormExit);
            this.Controls.Add(this.btnSecondFormDelete);
            this.Controls.Add(this.btnSecondFormEdit);
            this.Controls.Add(this.btnSecondFormAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondFormPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSecondFormProgramOrSite);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecondWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe";
            this.Load += new System.EventHandler(this.SecondWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSecondFormProgramOrSite;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecondFormPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSecondFormAdd;
        private System.Windows.Forms.Button btnSecondFormEdit;
        private System.Windows.Forms.Button btnSecondFormDelete;
        private System.Windows.Forms.Button btnSecondFormExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondFormUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondFormMisc;
        private System.Windows.Forms.Button btnAdmin;
    }
}