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
            this.btnAdminClearClipboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdminNumCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(59, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAdminOldPassword
            // 
            this.txtAdminOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminOldPassword.Location = new System.Drawing.Point(59, 141);
            this.txtAdminOldPassword.Name = "txtAdminOldPassword";
            this.txtAdminOldPassword.Size = new System.Drawing.Size(242, 20);
            this.txtAdminOldPassword.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtAdminOldPassword, "Enter Current Password");
            this.txtAdminOldPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password";
            // 
            // txtAdminNewPassword1
            // 
            this.txtAdminNewPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminNewPassword1.Location = new System.Drawing.Point(59, 198);
            this.txtAdminNewPassword1.Name = "txtAdminNewPassword1";
            this.txtAdminNewPassword1.Size = new System.Drawing.Size(242, 20);
            this.txtAdminNewPassword1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtAdminNewPassword1, "Enter New Password");
            this.txtAdminNewPassword1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // txtAdminNewPassword2
            // 
            this.txtAdminNewPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminNewPassword2.Location = new System.Drawing.Point(59, 255);
            this.txtAdminNewPassword2.Name = "txtAdminNewPassword2";
            this.txtAdminNewPassword2.Size = new System.Drawing.Size(242, 20);
            this.txtAdminNewPassword2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtAdminNewPassword2, "Confirm New Password");
            this.txtAdminNewPassword2.UseSystemPasswordChar = true;
            // 
            // btnAdminSubmit
            // 
            this.btnAdminSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminSubmit.BackColor = System.Drawing.Color.Green;
            this.btnAdminSubmit.FlatAppearance.BorderSize = 0;
            this.btnAdminSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSubmit.ForeColor = System.Drawing.Color.White;
            this.btnAdminSubmit.Location = new System.Drawing.Point(226, 308);
            this.btnAdminSubmit.Name = "btnAdminSubmit";
            this.btnAdminSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSubmit.TabIndex = 7;
            this.btnAdminSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnAdminSubmit, "Submit");
            this.btnAdminSubmit.UseVisualStyleBackColor = false;
            this.btnAdminSubmit.Click += new System.EventHandler(this.btnAdminSubmit_Click);
            // 
            // btnAdminStartOver
            // 
            this.btnAdminStartOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminStartOver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminStartOver.FlatAppearance.BorderSize = 0;
            this.btnAdminStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminStartOver.ForeColor = System.Drawing.Color.White;
            this.btnAdminStartOver.Location = new System.Drawing.Point(142, 308);
            this.btnAdminStartOver.Name = "btnAdminStartOver";
            this.btnAdminStartOver.Size = new System.Drawing.Size(75, 23);
            this.btnAdminStartOver.TabIndex = 8;
            this.btnAdminStartOver.Text = "Start Over";
            this.toolTip1.SetToolTip(this.btnAdminStartOver, "Start Over");
            this.btnAdminStartOver.UseVisualStyleBackColor = false;
            this.btnAdminStartOver.Click += new System.EventHandler(this.btnAdminStartOver_Click);
            // 
            // btnAdminCancel
            // 
            this.btnAdminCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminCancel.BackColor = System.Drawing.Color.Red;
            this.btnAdminCancel.FlatAppearance.BorderSize = 0;
            this.btnAdminCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCancel.ForeColor = System.Drawing.Color.White;
            this.btnAdminCancel.Location = new System.Drawing.Point(59, 308);
            this.btnAdminCancel.Name = "btnAdminCancel";
            this.btnAdminCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAdminCancel.TabIndex = 9;
            this.btnAdminCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnAdminCancel, "Cancel");
            this.btnAdminCancel.UseVisualStyleBackColor = false;
            this.btnAdminCancel.Click += new System.EventHandler(this.btnAdminCancel_Click);
            // 
            // txtAdminRandomPassword
            // 
            this.txtAdminRandomPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminRandomPassword.Location = new System.Drawing.Point(59, 399);
            this.txtAdminRandomPassword.Name = "txtAdminRandomPassword";
            this.txtAdminRandomPassword.ReadOnly = true;
            this.txtAdminRandomPassword.Size = new System.Drawing.Size(242, 20);
            this.txtAdminRandomPassword.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtAdminRandomPassword, "Random Password");
            // 
            // numericAdminNumCharacters
            // 
            this.numericAdminNumCharacters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericAdminNumCharacters.Location = new System.Drawing.Point(59, 476);
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
            this.numericAdminNumCharacters.TabIndex = 12;
            this.toolTip1.SetToolTip(this.numericAdminNumCharacters, "Number of Characters (Max 20)");
            this.numericAdminNumCharacters.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chkBxSpecialCharacter
            // 
            this.chkBxSpecialCharacter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBxSpecialCharacter.AutoSize = true;
            this.chkBxSpecialCharacter.ForeColor = System.Drawing.Color.White;
            this.chkBxSpecialCharacter.Location = new System.Drawing.Point(59, 509);
            this.chkBxSpecialCharacter.Name = "chkBxSpecialCharacter";
            this.chkBxSpecialCharacter.Size = new System.Drawing.Size(153, 17);
            this.chkBxSpecialCharacter.TabIndex = 14;
            this.chkBxSpecialCharacter.Text = "Include Special Characters";
            this.toolTip1.SetToolTip(this.chkBxSpecialCharacter, "Include Special Characters (~`!@#$%^&*()+=_-{}[], etc.)");
            this.chkBxSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // btnAdminGenerate
            // 
            this.btnAdminGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminGenerate.BackColor = System.Drawing.Color.Green;
            this.btnAdminGenerate.FlatAppearance.BorderSize = 0;
            this.btnAdminGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGenerate.ForeColor = System.Drawing.Color.White;
            this.btnAdminGenerate.Location = new System.Drawing.Point(226, 503);
            this.btnAdminGenerate.Name = "btnAdminGenerate";
            this.btnAdminGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnAdminGenerate.TabIndex = 15;
            this.btnAdminGenerate.Text = "Generate";
            this.toolTip1.SetToolTip(this.btnAdminGenerate, "Generate Random Password");
            this.btnAdminGenerate.UseVisualStyleBackColor = false;
            this.btnAdminGenerate.Click += new System.EventHandler(this.btnAdminGenerate_Click);
            // 
            // btnAdminMax
            // 
            this.btnAdminMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminMax.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminMax.FlatAppearance.BorderSize = 0;
            this.btnAdminMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMax.ForeColor = System.Drawing.Color.White;
            this.btnAdminMax.Location = new System.Drawing.Point(145, 476);
            this.btnAdminMax.Name = "btnAdminMax";
            this.btnAdminMax.Size = new System.Drawing.Size(37, 20);
            this.btnAdminMax.TabIndex = 18;
            this.btnAdminMax.Text = "Max";
            this.toolTip1.SetToolTip(this.btnAdminMax, "Generate Random Password");
            this.btnAdminMax.UseVisualStyleBackColor = false;
            this.btnAdminMax.Click += new System.EventHandler(this.btnAdminMax_Click);
            // 
            // btnAdminRPGToClip
            // 
            this.btnAdminRPGToClip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminRPGToClip.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminRPGToClip.FlatAppearance.BorderSize = 0;
            this.btnAdminRPGToClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRPGToClip.ForeColor = System.Drawing.Color.White;
            this.btnAdminRPGToClip.Location = new System.Drawing.Point(59, 422);
            this.btnAdminRPGToClip.Name = "btnAdminRPGToClip";
            this.btnAdminRPGToClip.Size = new System.Drawing.Size(39, 23);
            this.btnAdminRPGToClip.TabIndex = 19;
            this.btnAdminRPGToClip.Text = "Copy";
            this.toolTip1.SetToolTip(this.btnAdminRPGToClip, "Copy Random Password to Clipboard");
            this.btnAdminRPGToClip.UseVisualStyleBackColor = false;
            this.btnAdminRPGToClip.Click += new System.EventHandler(this.btnAdminRPGToClip_Click);
            // 
            // btnAdminClearClipboard
            // 
            this.btnAdminClearClipboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminClearClipboard.BackColor = System.Drawing.Color.Red;
            this.btnAdminClearClipboard.FlatAppearance.BorderSize = 0;
            this.btnAdminClearClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminClearClipboard.ForeColor = System.Drawing.Color.White;
            this.btnAdminClearClipboard.Location = new System.Drawing.Point(262, 422);
            this.btnAdminClearClipboard.Name = "btnAdminClearClipboard";
            this.btnAdminClearClipboard.Size = new System.Drawing.Size(39, 23);
            this.btnAdminClearClipboard.TabIndex = 20;
            this.btnAdminClearClipboard.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnAdminClearClipboard, "Clear Clipboard");
            this.btnAdminClearClipboard.UseVisualStyleBackColor = false;
            this.btnAdminClearClipboard.Click += new System.EventHandler(this.btnAdminClearClipboard_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Random Password Generator";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "# of Characters";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(18, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 2);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(359, 560);
            this.Controls.Add(this.btnAdminClearClipboard);
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
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe - Admin";
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
        private System.Windows.Forms.Button btnAdminClearClipboard;
    }
}