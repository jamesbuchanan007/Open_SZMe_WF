namespace Open_SZME_WF
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtQuestion2 = new System.Windows.Forms.TextBox();
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(47, 337);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(244, 20);
            this.txtAnswer2.TabIndex = 10;
            this.txtAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAnswer2, "Enter 2nd Answer for Password Recovery");
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(47, 225);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(244, 20);
            this.txtAnswer1.TabIndex = 8;
            this.txtAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAnswer1, "Enter 1st Answer for Password Recovery");
            // 
            // txtQuestion2
            // 
            this.txtQuestion2.Location = new System.Drawing.Point(48, 282);
            this.txtQuestion2.Name = "txtQuestion2";
            this.txtQuestion2.ReadOnly = true;
            this.txtQuestion2.Size = new System.Drawing.Size(244, 20);
            this.txtQuestion2.TabIndex = 9;
            this.txtQuestion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQuestion2, "Enter 2nd Question for Password Recovery");
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Location = new System.Drawing.Point(47, 168);
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.ReadOnly = true;
            this.txtQuestion1.Size = new System.Drawing.Size(244, 20);
            this.txtQuestion1.TabIndex = 7;
            this.txtQuestion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtQuestion1, "Enter 1st Question for Password Recovery");
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(214, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Generate Random Password");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.label7.Location = new System.Drawing.Point(45, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Answer #2 (Not Case-Sensitive)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Answer #1 (Not Case-Sensitive)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(46, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Question #2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Question #1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(47, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button1, "Generate Random Password");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(338, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuestion2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuestion1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe - Password Recovery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuestion2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuestion1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
    }
}