﻿namespace Open_SZME_WF
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
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(117, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtInitialPassword
            // 
            this.txtInitialPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInitialPassword.Location = new System.Drawing.Point(227, 343);
            this.txtInitialPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtInitialPassword.Name = "txtInitialPassword";
            this.txtInitialPassword.Size = new System.Drawing.Size(436, 38);
            this.txtInitialPassword.TabIndex = 1;
            this.txtInitialPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInitialPassword, "Enter Initial Password then press Enter");
            this.txtInitialPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitialPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 32);
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
            this.btnInitialLoginCancel.Location = new System.Drawing.Point(325, 455);
            this.btnInitialLoginCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnInitialLoginCancel.Name = "btnInitialLoginCancel";
            this.btnInitialLoginCancel.Size = new System.Drawing.Size(243, 55);
            this.btnInitialLoginCancel.TabIndex = 3;
            this.btnInitialLoginCancel.Text = "Cancel Set Up";
            this.btnInitialLoginCancel.UseVisualStyleBackColor = false;
            this.btnInitialLoginCancel.Click += new System.EventHandler(this.btnInitialLoginCancel_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(12, 9);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(211, 32);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.Text = "Version: Debug";
            // 
            // InitialLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(883, 539);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.btnInitialLoginCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitialPassword);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
        private System.Windows.Forms.Label labelVersion;
    }
}