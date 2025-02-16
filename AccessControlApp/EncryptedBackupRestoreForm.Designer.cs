namespace AccessControlApp
{
    partial class EncryptedBackupRestoreForm
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
            this.comboBoxDatabases = new System.Windows.Forms.ComboBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnEncryptedBackup = new System.Windows.Forms.Button();
            this.btnEncryptedRestore = new System.Windows.Forms.Button();
            this.chkCreateCert = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCertName = new System.Windows.Forms.TextBox();
            this.txtMasterKeyPassword = new System.Windows.Forms.TextBox();
            this.lblCert = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDatabases
            // 
            this.comboBoxDatabases.FormattingEnabled = true;
            this.comboBoxDatabases.Location = new System.Drawing.Point(284, 127);
            this.comboBoxDatabases.Name = "comboBoxDatabases";
            this.comboBoxDatabases.Size = new System.Drawing.Size(151, 21);
            this.comboBoxDatabases.TabIndex = 0;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(284, 174);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(275, 20);
            this.txtBackupPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.Location = new System.Drawing.Point(606, 167);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 30);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Поиск";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnEncryptedBackup
            // 
            this.btnEncryptedBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnEncryptedBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptedBackup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptedBackup.Location = new System.Drawing.Point(284, 377);
            this.btnEncryptedBackup.Name = "btnEncryptedBackup";
            this.btnEncryptedBackup.Size = new System.Drawing.Size(92, 39);
            this.btnEncryptedBackup.TabIndex = 3;
            this.btnEncryptedBackup.Text = "BACKUP";
            this.btnEncryptedBackup.UseVisualStyleBackColor = false;
            this.btnEncryptedBackup.Click += new System.EventHandler(this.btnEncryptedBackup_Click);
            // 
            // btnEncryptedRestore
            // 
            this.btnEncryptedRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnEncryptedRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptedRestore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncryptedRestore.Location = new System.Drawing.Point(477, 377);
            this.btnEncryptedRestore.Name = "btnEncryptedRestore";
            this.btnEncryptedRestore.Size = new System.Drawing.Size(82, 39);
            this.btnEncryptedRestore.TabIndex = 4;
            this.btnEncryptedRestore.Text = "RESTORE";
            this.btnEncryptedRestore.UseVisualStyleBackColor = false;
            this.btnEncryptedRestore.Click += new System.EventHandler(this.btnEncryptedRestore_Click);
            // 
            // chkCreateCert
            // 
            this.chkCreateCert.AutoSize = true;
            this.chkCreateCert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCreateCert.ForeColor = System.Drawing.SystemColors.Control;
            this.chkCreateCert.Location = new System.Drawing.Point(78, 335);
            this.chkCreateCert.Name = "chkCreateCert";
            this.chkCreateCert.Size = new System.Drawing.Size(233, 25);
            this.chkCreateCert.TabIndex = 5;
            this.chkCreateCert.Text = "Создать сертификат и ключ ";
            this.chkCreateCert.UseVisualStyleBackColor = true;
            this.chkCreateCert.CheckedChanged += new System.EventHandler(this.chkCreateCert_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(74, 432);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Статус:";
            // 
            // txtCertName
            // 
            this.txtCertName.Location = new System.Drawing.Point(284, 249);
            this.txtCertName.Name = "txtCertName";
            this.txtCertName.Size = new System.Drawing.Size(275, 20);
            this.txtCertName.TabIndex = 7;
            this.txtCertName.TextChanged += new System.EventHandler(this.txtCertName_TextChanged);
            // 
            // txtMasterKeyPassword
            // 
            this.txtMasterKeyPassword.Location = new System.Drawing.Point(284, 290);
            this.txtMasterKeyPassword.Name = "txtMasterKeyPassword";
            this.txtMasterKeyPassword.Size = new System.Drawing.Size(275, 20);
            this.txtMasterKeyPassword.TabIndex = 8;
            this.txtMasterKeyPassword.UseSystemPasswordChar = true;
            // 
            // lblCert
            // 
            this.lblCert.AutoSize = true;
            this.lblCert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCert.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCert.Location = new System.Drawing.Point(74, 249);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(139, 21);
            this.lblCert.TabIndex = 10;
            this.lblCert.Text = "Имя сертификата:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(74, 290);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(172, 21);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Пароль мастер-ключа:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDb.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDb.Location = new System.Drawing.Point(74, 127);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(176, 21);
            this.lblDb.TabIndex = 12;
            this.lblDb.Text = "Выберите базу данных:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPath.Location = new System.Drawing.Point(74, 171);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(186, 21);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "Путь к файлу рез. копии:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 104);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(702, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTop.Location = new System.Drawing.Point(170, 39);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(480, 30);
            this.lblTop.TabIndex = 16;
            this.lblTop.Text = "Шифрование с использованием сертификата";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessControlApp.Properties.Resources._3672883_award_certificate_education_emblem_medal_icon;
            this.pictureBox1.Location = new System.Drawing.Point(77, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EncryptedBackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblCert);
            this.Controls.Add(this.txtMasterKeyPassword);
            this.Controls.Add(this.txtCertName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkCreateCert);
            this.Controls.Add(this.btnEncryptedRestore);
            this.Controls.Add(this.btnEncryptedBackup);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.comboBoxDatabases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncryptedBackupRestoreForm";
            this.Text = "EncryptedBackupRestoreForm";
            this.Load += new System.EventHandler(this.EncryptedBackupRestoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDatabases;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEncryptedBackup;
        private System.Windows.Forms.Button btnEncryptedRestore;
        private System.Windows.Forms.CheckBox chkCreateCert;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCertName;
        private System.Windows.Forms.TextBox txtMasterKeyPassword;
        private System.Windows.Forms.Label lblCert;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTop;
    }
}