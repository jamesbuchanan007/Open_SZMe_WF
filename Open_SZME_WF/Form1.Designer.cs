namespace Open_SZME_WF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtForm1Password = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonForm1Submit = new System.Windows.Forms.Button();
            this.btnForm1Clear = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtForm1Password
            // 
            this.txtForm1Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForm1Password.Location = new System.Drawing.Point(56, 102);
            this.txtForm1Password.Margin = new System.Windows.Forms.Padding(1);
            this.txtForm1Password.Name = "txtForm1Password";
            this.txtForm1Password.Size = new System.Drawing.Size(195, 20);
            this.txtForm1Password.TabIndex = 0;
            this.txtForm1Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtForm1Password, "Enter Password");
            this.txtForm1Password.UseSystemPasswordChar = true;
            this.txtForm1Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForm1Password_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonForm1Submit
            // 
            this.buttonForm1Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForm1Submit.BackColor = System.Drawing.Color.Green;
            this.buttonForm1Submit.FlatAppearance.BorderSize = 0;
            this.buttonForm1Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForm1Submit.ForeColor = System.Drawing.Color.White;
            this.buttonForm1Submit.Location = new System.Drawing.Point(224, 146);
            this.buttonForm1Submit.Margin = new System.Windows.Forms.Padding(1);
            this.buttonForm1Submit.Name = "buttonForm1Submit";
            this.buttonForm1Submit.Size = new System.Drawing.Size(64, 22);
            this.buttonForm1Submit.TabIndex = 2;
            this.buttonForm1Submit.Text = "Submit";
            this.buttonForm1Submit.UseVisualStyleBackColor = false;
            this.buttonForm1Submit.Click += new System.EventHandler(this.buttonForm1Submit_Click);
            // 
            // btnForm1Clear
            // 
            this.btnForm1Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForm1Clear.BackColor = System.Drawing.Color.Red;
            this.btnForm1Clear.FlatAppearance.BorderSize = 0;
            this.btnForm1Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm1Clear.ForeColor = System.Drawing.Color.White;
            this.btnForm1Clear.Location = new System.Drawing.Point(14, 146);
            this.btnForm1Clear.Margin = new System.Windows.Forms.Padding(1);
            this.btnForm1Clear.Name = "btnForm1Clear";
            this.btnForm1Clear.Size = new System.Drawing.Size(64, 22);
            this.btnForm1Clear.TabIndex = 3;
            this.btnForm1Clear.Text = "Clear";
            this.btnForm1Clear.UseVisualStyleBackColor = false;
            this.btnForm1Clear.Click += new System.EventHandler(this.btnForm1Clear_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(4, 4);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version: Debug";
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForgotPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.ForeColor = System.Drawing.Color.White;
            this.btnForgotPassword.Location = new System.Drawing.Point(105, 146);
            this.btnForgotPassword.Margin = new System.Windows.Forms.Padding(1);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(98, 22);
            this.btnForgotPassword.TabIndex = 5;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonForm1Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(304, 179);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.btnForm1Clear);
            this.Controls.Add(this.buttonForm1Submit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtForm1Password);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForm1Password;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonForm1Submit;
        private System.Windows.Forms.Button btnForm1Clear;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button btnForgotPassword;
    }
}

