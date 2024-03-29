﻿namespace Open_SZME_WF
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
            this.cmb2ndFormProgramOrSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2ndFormPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2ndFormNew = new System.Windows.Forms.Button();
            this.btn2ndFormEdit = new System.Windows.Forms.Button();
            this.btn2ndFormDelete = new System.Windows.Forms.Button();
            this.btn2ndFormExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt2ndFormUserId = new System.Windows.Forms.TextBox();
            this.txt2ndFormMisc = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btn2ndFormPastePw = new System.Windows.Forms.Button();
            this.btn2ndFormClearClipboard = new System.Windows.Forms.Button();
            this.txt2ndFormProgramSite = new System.Windows.Forms.TextBox();
            this.btn2ndFormSubmit = new System.Windows.Forms.Button();
            this.btnAdminRPGToClip = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPasteUserId = new System.Windows.Forms.Button();
            this.btnPasteSite = new System.Windows.Forms.Button();
            this.btnCopyUserId = new System.Windows.Forms.Button();
            this.btnCopyMisc = new System.Windows.Forms.Button();
            this.btnPasteMisc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmb2ndFormProgramOrSite
            // 
            this.cmb2ndFormProgramOrSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb2ndFormProgramOrSite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb2ndFormProgramOrSite.FormattingEnabled = true;
            this.cmb2ndFormProgramOrSite.Location = new System.Drawing.Point(140, 127);
            this.cmb2ndFormProgramOrSite.Name = "cmb2ndFormProgramOrSite";
            this.cmb2ndFormProgramOrSite.Size = new System.Drawing.Size(225, 21);
            this.cmb2ndFormProgramOrSite.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmb2ndFormProgramOrSite, "Select Program / Site");
            this.cmb2ndFormProgramOrSite.SelectedIndexChanged += new System.EventHandler(this.cmb2ndFormProgramOrSite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Program / Site";
            // 
            // txt2ndFormPassword
            // 
            this.txt2ndFormPassword.Location = new System.Drawing.Point(43, 359);
            this.txt2ndFormPassword.Name = "txt2ndFormPassword";
            this.txt2ndFormPassword.ReadOnly = true;
            this.txt2ndFormPassword.Size = new System.Drawing.Size(220, 20);
            this.txt2ndFormPassword.TabIndex = 26;
            this.txt2ndFormPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt2ndFormPassword, "Current Password");
            this.txt2ndFormPassword.UseSystemPasswordChar = true;
            this.txt2ndFormPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt2ndFormPassword_MouseDown);
            this.txt2ndFormPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt2ndFormPassword_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btn2ndFormNew
            // 
            this.btn2ndFormNew.BackColor = System.Drawing.Color.Green;
            this.btn2ndFormNew.FlatAppearance.BorderSize = 0;
            this.btn2ndFormNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormNew.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormNew.Location = new System.Drawing.Point(46, 181);
            this.btn2ndFormNew.Name = "btn2ndFormNew";
            this.btn2ndFormNew.Size = new System.Drawing.Size(75, 23);
            this.btn2ndFormNew.TabIndex = 5;
            this.btn2ndFormNew.Text = "New";
            this.toolTip1.SetToolTip(this.btn2ndFormNew, "Add New Password Record");
            this.btn2ndFormNew.UseVisualStyleBackColor = false;
            this.btn2ndFormNew.Click += new System.EventHandler(this.btn2ndFormNew_Click);
            // 
            // btn2ndFormEdit
            // 
            this.btn2ndFormEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn2ndFormEdit.FlatAppearance.BorderSize = 0;
            this.btn2ndFormEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormEdit.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormEdit.Location = new System.Drawing.Point(127, 181);
            this.btn2ndFormEdit.Name = "btn2ndFormEdit";
            this.btn2ndFormEdit.Size = new System.Drawing.Size(75, 23);
            this.btn2ndFormEdit.TabIndex = 6;
            this.btn2ndFormEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btn2ndFormEdit, "Edit Password Record");
            this.btn2ndFormEdit.UseVisualStyleBackColor = false;
            this.btn2ndFormEdit.Click += new System.EventHandler(this.btn2ndFormEdit_Click);
            // 
            // btn2ndFormDelete
            // 
            this.btn2ndFormDelete.BackColor = System.Drawing.Color.Red;
            this.btn2ndFormDelete.FlatAppearance.BorderSize = 0;
            this.btn2ndFormDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormDelete.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormDelete.Location = new System.Drawing.Point(208, 181);
            this.btn2ndFormDelete.Name = "btn2ndFormDelete";
            this.btn2ndFormDelete.Size = new System.Drawing.Size(75, 23);
            this.btn2ndFormDelete.TabIndex = 7;
            this.btn2ndFormDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btn2ndFormDelete, "Delete Password Record");
            this.btn2ndFormDelete.UseVisualStyleBackColor = false;
            this.btn2ndFormDelete.Click += new System.EventHandler(this.btn2ndFormDelete_Click);
            // 
            // btn2ndFormExit
            // 
            this.btn2ndFormExit.BackColor = System.Drawing.Color.Red;
            this.btn2ndFormExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn2ndFormExit.FlatAppearance.BorderSize = 0;
            this.btn2ndFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormExit.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormExit.Location = new System.Drawing.Point(289, 632);
            this.btn2ndFormExit.Name = "btn2ndFormExit";
            this.btn2ndFormExit.Size = new System.Drawing.Size(75, 23);
            this.btn2ndFormExit.TabIndex = 8;
            this.btn2ndFormExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btn2ndFormExit, "Exit Application");
            this.btn2ndFormExit.UseVisualStyleBackColor = false;
            this.btn2ndFormExit.Click += new System.EventHandler(this.btn2ndFormExit_Click);
            // 
            // txt2ndFormUserId
            // 
            this.txt2ndFormUserId.Location = new System.Drawing.Point(43, 296);
            this.txt2ndFormUserId.Name = "txt2ndFormUserId";
            this.txt2ndFormUserId.ReadOnly = true;
            this.txt2ndFormUserId.Size = new System.Drawing.Size(220, 20);
            this.txt2ndFormUserId.TabIndex = 25;
            this.txt2ndFormUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt2ndFormUserId, "Current User Id");
            this.txt2ndFormUserId.UseSystemPasswordChar = true;
            this.txt2ndFormUserId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt2ndFormUserId_MouseDown);
            this.txt2ndFormUserId.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt2ndFormUserId_MouseUp);
            // 
            // txt2ndFormMisc
            // 
            this.txt2ndFormMisc.Location = new System.Drawing.Point(43, 442);
            this.txt2ndFormMisc.Multiline = true;
            this.txt2ndFormMisc.Name = "txt2ndFormMisc";
            this.txt2ndFormMisc.ReadOnly = true;
            this.txt2ndFormMisc.Size = new System.Drawing.Size(322, 105);
            this.txt2ndFormMisc.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txt2ndFormMisc, "Miscellaneous Notes");
            this.txt2ndFormMisc.UseSystemPasswordChar = true;
            this.txt2ndFormMisc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt2ndFormMisc_MouseDown);
            this.txt2ndFormMisc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt2ndFormMisc_MouseUp);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(43, 632);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin";
            this.toolTip1.SetToolTip(this.btnAdmin, "Update Application Password");
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btn2ndFormPastePw
            // 
            this.btn2ndFormPastePw.BackColor = System.Drawing.Color.Green;
            this.btn2ndFormPastePw.Enabled = false;
            this.btn2ndFormPastePw.FlatAppearance.BorderSize = 0;
            this.btn2ndFormPastePw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormPastePw.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormPastePw.Location = new System.Drawing.Point(314, 357);
            this.btn2ndFormPastePw.Name = "btn2ndFormPastePw";
            this.btn2ndFormPastePw.Size = new System.Drawing.Size(50, 23);
            this.btn2ndFormPastePw.TabIndex = 20;
            this.btn2ndFormPastePw.Text = "Paste";
            this.toolTip1.SetToolTip(this.btn2ndFormPastePw, "Paste Password from Clipboard");
            this.btn2ndFormPastePw.UseVisualStyleBackColor = false;
            this.btn2ndFormPastePw.Click += new System.EventHandler(this.btn2ndFormPastePw_Click);
            // 
            // btn2ndFormClearClipboard
            // 
            this.btn2ndFormClearClipboard.BackColor = System.Drawing.Color.Red;
            this.btn2ndFormClearClipboard.FlatAppearance.BorderSize = 0;
            this.btn2ndFormClearClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormClearClipboard.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormClearClipboard.Location = new System.Drawing.Point(43, 385);
            this.btn2ndFormClearClipboard.Name = "btn2ndFormClearClipboard";
            this.btn2ndFormClearClipboard.Size = new System.Drawing.Size(106, 23);
            this.btn2ndFormClearClipboard.TabIndex = 21;
            this.btn2ndFormClearClipboard.Text = "Clear Clipboard";
            this.toolTip1.SetToolTip(this.btn2ndFormClearClipboard, "Clear Clipboard");
            this.btn2ndFormClearClipboard.UseVisualStyleBackColor = false;
            this.btn2ndFormClearClipboard.Click += new System.EventHandler(this.btn2ndFormClearClipboard_Click);
            // 
            // txt2ndFormProgramSite
            // 
            this.txt2ndFormProgramSite.Location = new System.Drawing.Point(43, 238);
            this.txt2ndFormProgramSite.Name = "txt2ndFormProgramSite";
            this.txt2ndFormProgramSite.ReadOnly = true;
            this.txt2ndFormProgramSite.Size = new System.Drawing.Size(266, 20);
            this.txt2ndFormProgramSite.TabIndex = 24;
            this.txt2ndFormProgramSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt2ndFormProgramSite, "Current User Id");
            // 
            // btn2ndFormSubmit
            // 
            this.btn2ndFormSubmit.BackColor = System.Drawing.Color.Green;
            this.btn2ndFormSubmit.Enabled = false;
            this.btn2ndFormSubmit.FlatAppearance.BorderSize = 0;
            this.btn2ndFormSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndFormSubmit.ForeColor = System.Drawing.Color.White;
            this.btn2ndFormSubmit.Location = new System.Drawing.Point(290, 553);
            this.btn2ndFormSubmit.Name = "btn2ndFormSubmit";
            this.btn2ndFormSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn2ndFormSubmit.TabIndex = 28;
            this.btn2ndFormSubmit.Text = "Save";
            this.toolTip1.SetToolTip(this.btn2ndFormSubmit, "Add New Password Record");
            this.btn2ndFormSubmit.UseVisualStyleBackColor = false;
            this.btn2ndFormSubmit.Click += new System.EventHandler(this.btn2ndFormSubmit_Click);
            // 
            // btnAdminRPGToClip
            // 
            this.btnAdminRPGToClip.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminRPGToClip.FlatAppearance.BorderSize = 0;
            this.btnAdminRPGToClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRPGToClip.ForeColor = System.Drawing.Color.White;
            this.btnAdminRPGToClip.Location = new System.Drawing.Point(269, 357);
            this.btnAdminRPGToClip.Name = "btnAdminRPGToClip";
            this.btnAdminRPGToClip.Size = new System.Drawing.Size(39, 23);
            this.btnAdminRPGToClip.TabIndex = 30;
            this.btnAdminRPGToClip.Text = "Copy";
            this.toolTip1.SetToolTip(this.btnAdminRPGToClip, "Copy Password to Clipboard");
            this.btnAdminRPGToClip.UseVisualStyleBackColor = false;
            this.btnAdminRPGToClip.Click += new System.EventHandler(this.btnAdminRPGToClip_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(289, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button1, "Cancel");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPasteUserId
            // 
            this.btnPasteUserId.BackColor = System.Drawing.Color.Green;
            this.btnPasteUserId.Enabled = false;
            this.btnPasteUserId.FlatAppearance.BorderSize = 0;
            this.btnPasteUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteUserId.ForeColor = System.Drawing.Color.White;
            this.btnPasteUserId.Location = new System.Drawing.Point(314, 294);
            this.btnPasteUserId.Name = "btnPasteUserId";
            this.btnPasteUserId.Size = new System.Drawing.Size(50, 23);
            this.btnPasteUserId.TabIndex = 32;
            this.btnPasteUserId.Text = "Paste";
            this.toolTip1.SetToolTip(this.btnPasteUserId, "Paste User Id from Clipboard");
            this.btnPasteUserId.UseVisualStyleBackColor = false;
            this.btnPasteUserId.Click += new System.EventHandler(this.btnPasteUserId_Click);
            // 
            // btnPasteSite
            // 
            this.btnPasteSite.BackColor = System.Drawing.Color.Green;
            this.btnPasteSite.Enabled = false;
            this.btnPasteSite.FlatAppearance.BorderSize = 0;
            this.btnPasteSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteSite.ForeColor = System.Drawing.Color.White;
            this.btnPasteSite.Location = new System.Drawing.Point(315, 236);
            this.btnPasteSite.Name = "btnPasteSite";
            this.btnPasteSite.Size = new System.Drawing.Size(50, 23);
            this.btnPasteSite.TabIndex = 33;
            this.btnPasteSite.Text = "Paste";
            this.toolTip1.SetToolTip(this.btnPasteSite, "Paste Program / Site from Clipboard");
            this.btnPasteSite.UseVisualStyleBackColor = false;
            this.btnPasteSite.Click += new System.EventHandler(this.btnPasteSite_Click);
            // 
            // btnCopyUserId
            // 
            this.btnCopyUserId.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopyUserId.FlatAppearance.BorderSize = 0;
            this.btnCopyUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyUserId.ForeColor = System.Drawing.Color.White;
            this.btnCopyUserId.Location = new System.Drawing.Point(269, 294);
            this.btnCopyUserId.Name = "btnCopyUserId";
            this.btnCopyUserId.Size = new System.Drawing.Size(39, 23);
            this.btnCopyUserId.TabIndex = 34;
            this.btnCopyUserId.Text = "Copy";
            this.toolTip1.SetToolTip(this.btnCopyUserId, "Copy User Id to Clipboard");
            this.btnCopyUserId.UseVisualStyleBackColor = false;
            this.btnCopyUserId.Click += new System.EventHandler(this.btnCopyUserId_Click);
            // 
            // btnCopyMisc
            // 
            this.btnCopyMisc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopyMisc.FlatAppearance.BorderSize = 0;
            this.btnCopyMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyMisc.ForeColor = System.Drawing.Color.White;
            this.btnCopyMisc.Location = new System.Drawing.Point(43, 553);
            this.btnCopyMisc.Name = "btnCopyMisc";
            this.btnCopyMisc.Size = new System.Drawing.Size(39, 23);
            this.btnCopyMisc.TabIndex = 36;
            this.btnCopyMisc.Text = "Copy";
            this.toolTip1.SetToolTip(this.btnCopyMisc, "Copy Miscellaneous to Clipboard");
            this.btnCopyMisc.UseVisualStyleBackColor = false;
            this.btnCopyMisc.Click += new System.EventHandler(this.btnCopyMisc_Click);
            // 
            // btnPasteMisc
            // 
            this.btnPasteMisc.BackColor = System.Drawing.Color.Green;
            this.btnPasteMisc.Enabled = false;
            this.btnPasteMisc.FlatAppearance.BorderSize = 0;
            this.btnPasteMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteMisc.ForeColor = System.Drawing.Color.White;
            this.btnPasteMisc.Location = new System.Drawing.Point(88, 553);
            this.btnPasteMisc.Name = "btnPasteMisc";
            this.btnPasteMisc.Size = new System.Drawing.Size(50, 23);
            this.btnPasteMisc.TabIndex = 35;
            this.btnPasteMisc.Text = "Paste";
            this.toolTip1.SetToolTip(this.btnPasteMisc, "Paste Misc from Clipboard");
            this.btnPasteMisc.UseVisualStyleBackColor = false;
            this.btnPasteMisc.Click += new System.EventHandler(this.btnPasteMisc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Miscellaneous";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Program / Site";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 4);
            this.label6.TabIndex = 27;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(4, 4);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 13);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "Version: Debug";
            // 
            // SecondWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.CancelButton = this.btn2ndFormExit;
            this.ClientSize = new System.Drawing.Size(413, 674);
            this.Controls.Add(this.btnCopyMisc);
            this.Controls.Add(this.btnPasteMisc);
            this.Controls.Add(this.btnCopyUserId);
            this.Controls.Add(this.btnPasteSite);
            this.Controls.Add(this.btnPasteUserId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdminRPGToClip);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn2ndFormSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt2ndFormProgramSite);
            this.Controls.Add(this.btn2ndFormClearClipboard);
            this.Controls.Add(this.btn2ndFormPastePw);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2ndFormMisc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2ndFormUserId);
            this.Controls.Add(this.btn2ndFormExit);
            this.Controls.Add(this.btn2ndFormDelete);
            this.Controls.Add(this.btn2ndFormEdit);
            this.Controls.Add(this.btn2ndFormNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2ndFormPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb2ndFormProgramOrSite);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(422, 338);
            this.Name = "SecondWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe";
            this.Load += new System.EventHandler(this.SecondWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb2ndFormProgramOrSite;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2ndFormPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2ndFormNew;
        private System.Windows.Forms.Button btn2ndFormEdit;
        private System.Windows.Forms.Button btn2ndFormDelete;
        private System.Windows.Forms.Button btn2ndFormExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2ndFormUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2ndFormMisc;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btn2ndFormPastePw;
        private System.Windows.Forms.Button btn2ndFormClearClipboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2ndFormProgramSite;
        private System.Windows.Forms.Button btn2ndFormSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button btnAdminRPGToClip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPasteUserId;
        private System.Windows.Forms.Button btnPasteSite;
        private System.Windows.Forms.Button btnCopyUserId;
        private System.Windows.Forms.Button btnCopyMisc;
        private System.Windows.Forms.Button btnPasteMisc;
    }
}