namespace Open_SZME_WF
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAdminOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminNewPassword1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnAdminSubmit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdminStartOver = new System.Windows.Forms.Button();
            this.btnAdminCancel = new System.Windows.Forms.Button();
            this.txtAdminRandomPassword = new System.Windows.Forms.TextBox();
            this.numericAdminNumCharacters = new System.Windows.Forms.NumericUpDown();
            this.chkBxSpecialCharacter = new System.Windows.Forms.CheckBox();
            this.btnAdminGenerate = new System.Windows.Forms.Button();
            this.btnAdminMax = new System.Windows.Forms.Button();
            this.btnAdminRPGToClip = new System.Windows.Forms.Button();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtQuestion2 = new System.Windows.Forms.TextBox();
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdminNumCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(192, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAdminOldPassword
            // 
            this.txtAdminOldPassword.Location = new System.Drawing.Point(61, 190);
            this.txtAdminOldPassword.Name = "txtAdminOldPassword";
            this.txtAdminOldPassword.Size = new System.Drawing.Size(242, 20);
            this.txtAdminOldPassword.TabIndex = 1;
            this.txtAdminOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAdminOldPassword, "Enter Current Password");
            this.txtAdminOldPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "New Password";
            // 
            // txtAdminNewPassword1
            // 
            this.txtAdminNewPassword1.Location = new System.Drawing.Point(61, 247);
            this.txtAdminNewPassword1.Name = "txtAdminNewPassword1";
            this.txtAdminNewPassword1.Size = new System.Drawing.Size(242, 20);
            this.txtAdminNewPassword1.TabIndex = 3;
            this.txtAdminNewPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAdminNewPassword1, "Enter New Password");
            this.txtAdminNewPassword1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Confirm Password";
            // 
            // txtAdminNewPassword2
            // 
            this.txtAdminNewPassword2.Location = new System.Drawing.Point(61, 304);
            this.txtAdminNewPassword2.Name = "txtAdminNewPassword2";
            this.txtAdminNewPassword2.Size = new System.Drawing.Size(242, 20);
            this.txtAdminNewPassword2.TabIndex = 5;
            this.txtAdminNewPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAdminNewPassword2, "Confirm New Password");
            this.txtAdminNewPassword2.UseSystemPasswordChar = true;
            // 
            // btnAdminSubmit
            // 
            this.btnAdminSubmit.BackColor = System.Drawing.Color.Green;
            this.btnAdminSubmit.FlatAppearance.BorderSize = 0;
            this.btnAdminSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSubmit.ForeColor = System.Drawing.Color.White;
            this.btnAdminSubmit.Location = new System.Drawing.Point(360, 125);
            this.btnAdminSubmit.Name = "btnAdminSubmit";
            this.btnAdminSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSubmit.TabIndex = 11;
            this.btnAdminSubmit.Text = "Save";
            this.toolTip1.SetToolTip(this.btnAdminSubmit, "Submit");
            this.btnAdminSubmit.UseVisualStyleBackColor = false;
            this.btnAdminSubmit.Click += new System.EventHandler(this.btnAdminSubmit_Click);
            // 
            // btnAdminStartOver
            // 
            this.btnAdminStartOver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminStartOver.FlatAppearance.BorderSize = 0;
            this.btnAdminStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminStartOver.ForeColor = System.Drawing.Color.White;
            this.btnAdminStartOver.Location = new System.Drawing.Point(279, 125);
            this.btnAdminStartOver.Name = "btnAdminStartOver";
            this.btnAdminStartOver.Size = new System.Drawing.Size(75, 23);
            this.btnAdminStartOver.TabIndex = 13;
            this.btnAdminStartOver.Text = "Start Over";
            this.toolTip1.SetToolTip(this.btnAdminStartOver, "Start Over");
            this.btnAdminStartOver.UseVisualStyleBackColor = false;
            this.btnAdminStartOver.Click += new System.EventHandler(this.btnAdminStartOver_Click);
            // 
            // btnAdminCancel
            // 
            this.btnAdminCancel.BackColor = System.Drawing.Color.Red;
            this.btnAdminCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdminCancel.FlatAppearance.BorderSize = 0;
            this.btnAdminCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCancel.ForeColor = System.Drawing.Color.White;
            this.btnAdminCancel.Location = new System.Drawing.Point(196, 125);
            this.btnAdminCancel.Name = "btnAdminCancel";
            this.btnAdminCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAdminCancel.TabIndex = 12;
            this.btnAdminCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnAdminCancel, "Cancel");
            this.btnAdminCancel.UseVisualStyleBackColor = false;
            this.btnAdminCancel.Click += new System.EventHandler(this.btnAdminCancel_Click);
            // 
            // txtAdminRandomPassword
            // 
            this.txtAdminRandomPassword.Location = new System.Drawing.Point(280, 436);
            this.txtAdminRandomPassword.Name = "txtAdminRandomPassword";
            this.txtAdminRandomPassword.ReadOnly = true;
            this.txtAdminRandomPassword.Size = new System.Drawing.Size(242, 20);
            this.txtAdminRandomPassword.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtAdminRandomPassword, "Random Password");
            // 
            // numericAdminNumCharacters
            // 
            this.numericAdminNumCharacters.Location = new System.Drawing.Point(102, 436);
            this.numericAdminNumCharacters.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericAdminNumCharacters.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericAdminNumCharacters.Name = "numericAdminNumCharacters";
            this.numericAdminNumCharacters.Size = new System.Drawing.Size(80, 20);
            this.numericAdminNumCharacters.TabIndex = 14;
            this.toolTip1.SetToolTip(this.numericAdminNumCharacters, "Number of Characters (Max 20)");
            this.numericAdminNumCharacters.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chkBxSpecialCharacter
            // 
            this.chkBxSpecialCharacter.AutoSize = true;
            this.chkBxSpecialCharacter.ForeColor = System.Drawing.Color.White;
            this.chkBxSpecialCharacter.Location = new System.Drawing.Point(99, 466);
            this.chkBxSpecialCharacter.Name = "chkBxSpecialCharacter";
            this.chkBxSpecialCharacter.Size = new System.Drawing.Size(153, 17);
            this.chkBxSpecialCharacter.TabIndex = 16;
            this.chkBxSpecialCharacter.Text = "Include Special Characters";
            this.toolTip1.SetToolTip(this.chkBxSpecialCharacter, "Include Special Characters (~`!@#$%^&*()+=_-{}[], etc.)");
            this.chkBxSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // btnAdminGenerate
            // 
            this.btnAdminGenerate.BackColor = System.Drawing.Color.Green;
            this.btnAdminGenerate.FlatAppearance.BorderSize = 0;
            this.btnAdminGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGenerate.ForeColor = System.Drawing.Color.White;
            this.btnAdminGenerate.Location = new System.Drawing.Point(528, 434);
            this.btnAdminGenerate.Name = "btnAdminGenerate";
            this.btnAdminGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnAdminGenerate.TabIndex = 18;
            this.btnAdminGenerate.Text = "Generate";
            this.toolTip1.SetToolTip(this.btnAdminGenerate, "Generate Random Password");
            this.btnAdminGenerate.UseVisualStyleBackColor = false;
            this.btnAdminGenerate.Click += new System.EventHandler(this.btnAdminGenerate_Click);
            // 
            // btnAdminMax
            // 
            this.btnAdminMax.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminMax.FlatAppearance.BorderSize = 0;
            this.btnAdminMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMax.ForeColor = System.Drawing.Color.White;
            this.btnAdminMax.Location = new System.Drawing.Point(188, 436);
            this.btnAdminMax.Name = "btnAdminMax";
            this.btnAdminMax.Size = new System.Drawing.Size(37, 20);
            this.btnAdminMax.TabIndex = 15;
            this.btnAdminMax.Text = "Max";
            this.toolTip1.SetToolTip(this.btnAdminMax, "Generate Random Password");
            this.btnAdminMax.UseVisualStyleBackColor = false;
            this.btnAdminMax.Click += new System.EventHandler(this.btnAdminMax_Click);
            // 
            // btnAdminRPGToClip
            // 
            this.btnAdminRPGToClip.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminRPGToClip.FlatAppearance.BorderSize = 0;
            this.btnAdminRPGToClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRPGToClip.ForeColor = System.Drawing.Color.White;
            this.btnAdminRPGToClip.Location = new System.Drawing.Point(399, 460);
            this.btnAdminRPGToClip.Name = "btnAdminRPGToClip";
            this.btnAdminRPGToClip.Size = new System.Drawing.Size(123, 23);
            this.btnAdminRPGToClip.TabIndex = 19;
            this.btnAdminRPGToClip.Text = "Copy to Clipboard";
            this.toolTip1.SetToolTip(this.btnAdminRPGToClip, "Copy Random Password to Clipboard");
            this.btnAdminRPGToClip.UseVisualStyleBackColor = false;
            this.btnAdminRPGToClip.Click += new System.EventHandler(this.btnAdminRPGToClip_Click);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(359, 359);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(244, 20);
            this.txtAnswer2.TabIndex = 10;
            this.txtAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAnswer2, "Enter 2nd Answer for Password Recovery");
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(359, 247);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(244, 20);
            this.txtAnswer1.TabIndex = 8;
            this.txtAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAnswer1, "Enter 1st Answer for Password Recovery");
            // 
            // txtQuestion2
            // 
            this.txtQuestion2.Location = new System.Drawing.Point(360, 304);
            this.txtQuestion2.Name = "txtQuestion2";
            this.txtQuestion2.Size = new System.Drawing.Size(244, 20);
            this.txtQuestion2.TabIndex = 9;
            this.txtQuestion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQuestion2, "Enter 2nd Question for Password Recovery");
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Location = new System.Drawing.Point(359, 190);
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.Size = new System.Drawing.Size(244, 20);
            this.txtQuestion1.TabIndex = 7;
            this.txtQuestion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQuestion1, "Enter 1st Question for Password Recovery");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Random Password Generator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(102, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "# of Characters (Max: 32)";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(653, 2);
            this.label6.TabIndex = 16;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(4, 11);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 13);
            this.labelVersion.TabIndex = 21;
            this.labelVersion.Text = "Version: Debug";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(357, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Answer #2 (Not Case-Sensitive)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(357, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Answer #1 (Not Case-Sensitive)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(358, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Question #2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(356, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Question #1";
            // 
            // Admin
            // 
            this.AcceptButton = this.btnAdminSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.CancelButton = this.btnAdminCancel;
            this.ClientSize = new System.Drawing.Size(675, 519);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuestion2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuestion1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.btnAdminRPGToClip);
            this.Controls.Add(this.btnAdminMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdminGenerate);
            this.Controls.Add(this.chkBxSpecialCharacter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericAdminNumCharacters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdminRandomPassword);
            this.Controls.Add(this.btnAdminCancel);
            this.Controls.Add(this.btnAdminStartOver);
            this.Controls.Add(this.btnAdminSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdminNewPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminNewPassword1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminOldPassword);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe - Admin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Admin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdminNumCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAdminOldPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminNewPassword1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminNewPassword2;
        private System.Windows.Forms.Button btnAdminSubmit;
        private System.Windows.Forms.Button btnAdminStartOver;
        private System.Windows.Forms.Button btnAdminCancel;
        private System.Windows.Forms.TextBox txtAdminRandomPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericAdminNumCharacters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBxSpecialCharacter;
        private System.Windows.Forms.Button btnAdminGenerate;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnAdminMax;
        private System.Windows.Forms.Button btnAdminRPGToClip;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuestion2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuestion1;
        private System.Windows.Forms.Label label10;
    }
}