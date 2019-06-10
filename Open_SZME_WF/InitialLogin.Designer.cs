namespace Open_SZME_WF
{
    partial class InitialLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInitialPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInitialLoginCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtInitialPassword
            // 
            this.txtInitialPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInitialPassword.Location = new System.Drawing.Point(85, 144);
            this.txtInitialPassword.Name = "txtInitialPassword";
            this.txtInitialPassword.Size = new System.Drawing.Size(166, 20);
            this.txtInitialPassword.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtInitialPassword, "Enter Initial Password");
            this.txtInitialPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitialPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Password for Initial Use (Min. 5 Characters)";
            // 
            // btnInitialLoginCancel
            // 
            this.btnInitialLoginCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInitialLoginCancel.BackColor = System.Drawing.Color.Red;
            this.btnInitialLoginCancel.FlatAppearance.BorderSize = 0;
            this.btnInitialLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialLoginCancel.ForeColor = System.Drawing.Color.White;
            this.btnInitialLoginCancel.Location = new System.Drawing.Point(122, 191);
            this.btnInitialLoginCancel.Name = "btnInitialLoginCancel";
            this.btnInitialLoginCancel.Size = new System.Drawing.Size(91, 23);
            this.btnInitialLoginCancel.TabIndex = 3;
            this.btnInitialLoginCancel.Text = "Cancel Set Up";
            this.btnInitialLoginCancel.UseVisualStyleBackColor = false;
            this.btnInitialLoginCancel.Click += new System.EventHandler(this.btnInitialLoginCancel_Click);
            // 
            // InitialLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(331, 226);
            this.Controls.Add(this.btnInitialLoginCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitialPassword);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitialLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe - Initial Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtInitialPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnInitialLoginCancel;
    }
}