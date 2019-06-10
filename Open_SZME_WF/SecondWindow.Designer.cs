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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Open_SZME_WF.Properties.Resources.Open_SZMe_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSecondFormProgramOrSite
            // 
            this.cmbSecondFormProgramOrSite.FormattingEnabled = true;
            this.cmbSecondFormProgramOrSite.Location = new System.Drawing.Point(24, 139);
            this.cmbSecondFormProgramOrSite.Name = "cmbSecondFormProgramOrSite";
            this.cmbSecondFormProgramOrSite.Size = new System.Drawing.Size(236, 21);
            this.cmbSecondFormProgramOrSite.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbSecondFormProgramOrSite, "Select Program / Site");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program / Site";
            // 
            // txtSecondFormPassword
            // 
            this.txtSecondFormPassword.Location = new System.Drawing.Point(23, 207);
            this.txtSecondFormPassword.Name = "txtSecondFormPassword";
            this.txtSecondFormPassword.ReadOnly = true;
            this.txtSecondFormPassword.Size = new System.Drawing.Size(237, 20);
            this.txtSecondFormPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSecondFormPassword, "Current Password");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btnSecondFormAdd
            // 
            this.btnSecondFormAdd.BackColor = System.Drawing.Color.Green;
            this.btnSecondFormAdd.FlatAppearance.BorderSize = 0;
            this.btnSecondFormAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormAdd.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormAdd.Location = new System.Drawing.Point(23, 269);
            this.btnSecondFormAdd.Name = "btnSecondFormAdd";
            this.btnSecondFormAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormAdd.TabIndex = 5;
            this.btnSecondFormAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnSecondFormAdd, "Add New Password Record");
            this.btnSecondFormAdd.UseVisualStyleBackColor = false;
            // 
            // btnSecondFormEdit
            // 
            this.btnSecondFormEdit.BackColor = System.Drawing.Color.Green;
            this.btnSecondFormEdit.FlatAppearance.BorderSize = 0;
            this.btnSecondFormEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormEdit.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormEdit.Location = new System.Drawing.Point(104, 269);
            this.btnSecondFormEdit.Name = "btnSecondFormEdit";
            this.btnSecondFormEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormEdit.TabIndex = 6;
            this.btnSecondFormEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnSecondFormEdit, "Edit Password Record");
            this.btnSecondFormEdit.UseVisualStyleBackColor = false;
            // 
            // btnSecondFormDelete
            // 
            this.btnSecondFormDelete.BackColor = System.Drawing.Color.Green;
            this.btnSecondFormDelete.FlatAppearance.BorderSize = 0;
            this.btnSecondFormDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormDelete.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormDelete.Location = new System.Drawing.Point(185, 269);
            this.btnSecondFormDelete.Name = "btnSecondFormDelete";
            this.btnSecondFormDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormDelete.TabIndex = 7;
            this.btnSecondFormDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnSecondFormDelete, "Delete Password Record");
            this.btnSecondFormDelete.UseVisualStyleBackColor = false;
            // 
            // btnSecondFormExit
            // 
            this.btnSecondFormExit.BackColor = System.Drawing.Color.Red;
            this.btnSecondFormExit.FlatAppearance.BorderSize = 0;
            this.btnSecondFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFormExit.ForeColor = System.Drawing.Color.White;
            this.btnSecondFormExit.Location = new System.Drawing.Point(196, 333);
            this.btnSecondFormExit.Name = "btnSecondFormExit";
            this.btnSecondFormExit.Size = new System.Drawing.Size(75, 23);
            this.btnSecondFormExit.TabIndex = 8;
            this.btnSecondFormExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnSecondFormExit, "Exit Application");
            this.btnSecondFormExit.UseVisualStyleBackColor = false;
            this.btnSecondFormExit.Click += new System.EventHandler(this.btnSecondFormExit_Click);
            // 
            // SecondWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(283, 368);
            this.Controls.Add(this.btnSecondFormExit);
            this.Controls.Add(this.btnSecondFormDelete);
            this.Controls.Add(this.btnSecondFormEdit);
            this.Controls.Add(this.btnSecondFormAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondFormPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSecondFormProgramOrSite);
            this.Controls.Add(this.pictureBox1);
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
    }
}