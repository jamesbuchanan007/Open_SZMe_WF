namespace Open_SZME_WF
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.btnFilePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(45, 149);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(1);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(195, 20);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtFilePath, "Enter File Path");
            this.txtFilePath.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(64, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Green;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(242, 225);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(64, 22);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(45, 225);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 22);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(9, 11);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version: Debug";
            // 
            // btnFilePath
            // 
            this.btnFilePath.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilePath.FlatAppearance.BorderSize = 0;
            this.btnFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilePath.ForeColor = System.Drawing.Color.White;
            this.btnFilePath.Location = new System.Drawing.Point(242, 148);
            this.btnFilePath.Margin = new System.Windows.Forms.Padding(1);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(64, 22);
            this.btnFilePath.TabIndex = 7;
            this.btnFilePath.Text = "File Path";
            this.btnFilePath.UseVisualStyleBackColor = false;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // BackupForm
            // 
            this.AcceptButton = this.btnBackup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(337, 280);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SZMe - Backup Data";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
    }
}

