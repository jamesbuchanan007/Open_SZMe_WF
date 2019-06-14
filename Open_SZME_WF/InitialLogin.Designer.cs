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
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.txtQuestion2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.btnInitialLoginCancel = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveSetUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(52, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtInitialPassword
            // 
            this.txtInitialPassword.Location = new System.Drawing.Point(93, 150);
            this.txtInitialPassword.Name = "txtInitialPassword";
            this.txtInitialPassword.Size = new System.Drawing.Size(166, 20);
            this.txtInitialPassword.TabIndex = 1;
            this.txtInitialPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInitialPassword, "Enter Initial Password then press Enter");
            this.txtInitialPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInitialPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Password for Initial Use (Min. 5 Characters)";
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Location = new System.Drawing.Point(52, 223);
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.Size = new System.Drawing.Size(244, 20);
            this.txtQuestion1.TabIndex = 24;
            this.txtQuestion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQuestion1, "Enter 1st Question for Password Recovery");
            // 
            // txtQuestion2
            // 
            this.txtQuestion2.Location = new System.Drawing.Point(52, 315);
            this.txtQuestion2.Name = "txtQuestion2";
            this.txtQuestion2.Size = new System.Drawing.Size(244, 20);
            this.txtQuestion2.TabIndex = 27;
            this.txtQuestion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQuestion2, "Enter 2nd Question for Password Recovery");
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(52, 266);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(244, 20);
            this.txtAnswer1.TabIndex = 29;
            this.txtAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAnswer1, "Enter 1st Answer for Password Recovery");
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(52, 359);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(244, 20);
            this.txtAnswer2.TabIndex = 31;
            this.txtAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAnswer2, "Enter 2nd Answer for Password Recovery");
            // 
            // btnInitialLoginCancel
            // 
            this.btnInitialLoginCancel.BackColor = System.Drawing.Color.Red;
            this.btnInitialLoginCancel.FlatAppearance.BorderSize = 0;
            this.btnInitialLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialLoginCancel.ForeColor = System.Drawing.Color.White;
            this.btnInitialLoginCancel.Location = new System.Drawing.Point(28, 402);
            this.btnInitialLoginCancel.Name = "btnInitialLoginCancel";
            this.btnInitialLoginCancel.Size = new System.Drawing.Size(91, 23);
            this.btnInitialLoginCancel.TabIndex = 3;
            this.btnInitialLoginCancel.Text = "Cancel Set Up";
            this.btnInitialLoginCancel.UseVisualStyleBackColor = false;
            this.btnInitialLoginCancel.Click += new System.EventHandler(this.btnInitialLoginCancel_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(12, 10);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 13);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.Text = "Version: Debug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Question #1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password Recovery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Question #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Answer #1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Answer #2";
            // 
            // btnSaveSetUp
            // 
            this.btnSaveSetUp.BackColor = System.Drawing.Color.Green;
            this.btnSaveSetUp.FlatAppearance.BorderSize = 0;
            this.btnSaveSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSetUp.ForeColor = System.Drawing.Color.White;
            this.btnSaveSetUp.Location = new System.Drawing.Point(228, 402);
            this.btnSaveSetUp.Name = "btnSaveSetUp";
            this.btnSaveSetUp.Size = new System.Drawing.Size(91, 23);
            this.btnSaveSetUp.TabIndex = 32;
            this.btnSaveSetUp.Text = "Save Set Up";
            this.btnSaveSetUp.UseVisualStyleBackColor = false;
            // 
            // InitialLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(345, 449);
            this.Controls.Add(this.btnSaveSetUp);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuestion2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuestion1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelVersion);
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
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuestion1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuestion2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveSetUp;
    }
}