namespace AccessControlApp
{
    partial class MainForm
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
            this.lblRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.btnEncryptedBackup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenAddEmployeeForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(155, 34);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(229, 37);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Администратор";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 109);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(831, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSecurity.Location = new System.Drawing.Point(62, 151);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(138, 75);
            this.btnSecurity.TabIndex = 37;
            this.btnSecurity.Text = "Безопасность";
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackupRestore.Location = new System.Drawing.Point(320, 151);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(157, 75);
            this.btnBackupRestore.TabIndex = 38;
            this.btnBackupRestore.Text = "Резервное копирование и восстановление";
            this.btnBackupRestore.UseVisualStyleBackColor = false;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // btnEncryptedBackup
            // 
            this.btnEncryptedBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnEncryptedBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptedBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncryptedBackup.Location = new System.Drawing.Point(572, 151);
            this.btnEncryptedBackup.Name = "btnEncryptedBackup";
            this.btnEncryptedBackup.Size = new System.Drawing.Size(157, 75);
            this.btnEncryptedBackup.TabIndex = 39;
            this.btnEncryptedBackup.Text = "Шифрование с использованием сертификата";
            this.btnEncryptedBackup.UseVisualStyleBackColor = false;
            this.btnEncryptedBackup.Click += new System.EventHandler(this.btnEncryptedBackup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessControlApp.Properties.Resources._131507_hacker_administrator_system_sys_hack_icon;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenAddEmployeeForm
            // 
            this.btnOpenAddEmployeeForm.Location = new System.Drawing.Point(121, 291);
            this.btnOpenAddEmployeeForm.Name = "btnOpenAddEmployeeForm";
            this.btnOpenAddEmployeeForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAddEmployeeForm.TabIndex = 40;
            this.btnOpenAddEmployeeForm.Text = "button1";
            this.btnOpenAddEmployeeForm.UseVisualStyleBackColor = true;
            this.btnOpenAddEmployeeForm.Click += new System.EventHandler(this.btnOpenAddEmployeeForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.btnOpenAddEmployeeForm);
            this.Controls.Add(this.btnEncryptedBackup);
            this.Controls.Add(this.btnBackupRestore);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button btnBackupRestore;
        private System.Windows.Forms.Button btnEncryptedBackup;
        private System.Windows.Forms.Button btnOpenAddEmployeeForm;
    }
}