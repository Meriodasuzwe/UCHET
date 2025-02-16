namespace AccessControlApp
{
    partial class BackupRestoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestoreForm));
            this.comboBoxDatabases = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBackupUncommitted = new System.Windows.Forms.CheckBox();
            this.chkBackupChanges = new System.Windows.Forms.CheckBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblchooseDB = new System.Windows.Forms.Label();
            this.lblRoad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDatabases
            // 
            this.comboBoxDatabases.FormattingEnabled = true;
            this.comboBoxDatabases.Location = new System.Drawing.Point(47, 148);
            this.comboBoxDatabases.Name = "comboBoxDatabases";
            this.comboBoxDatabases.Size = new System.Drawing.Size(194, 21);
            this.comboBoxDatabases.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBackupUncommitted);
            this.groupBox1.Controls.Add(this.chkBackupChanges);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(47, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка";
            // 
            // chkBackupUncommitted
            // 
            this.chkBackupUncommitted.AutoSize = true;
            this.chkBackupUncommitted.Location = new System.Drawing.Point(20, 55);
            this.chkBackupUncommitted.Name = "chkBackupUncommitted";
            this.chkBackupUncommitted.Size = new System.Drawing.Size(296, 17);
            this.chkBackupUncommitted.TabIndex = 1;
            this.chkBackupUncommitted.Text = "Резервное копирование незавершённых транзакций";
            this.chkBackupUncommitted.UseVisualStyleBackColor = true;
            this.chkBackupUncommitted.CheckedChanged += new System.EventHandler(this.chkBackupUncommitted_CheckedChanged);
            // 
            // chkBackupChanges
            // 
            this.chkBackupChanges.AutoSize = true;
            this.chkBackupChanges.Location = new System.Drawing.Point(20, 32);
            this.chkBackupChanges.Name = "chkBackupChanges";
            this.chkBackupChanges.Size = new System.Drawing.Size(310, 17);
            this.chkBackupChanges.TabIndex = 0;
            this.chkBackupChanges.Text = "Резервное копирование изменений во время процесса";
            this.chkBackupChanges.UseVisualStyleBackColor = true;
            this.chkBackupChanges.CheckedChanged += new System.EventHandler(this.chkBackupChanges_CheckedChanged);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(47, 212);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(333, 20);
            this.txtBackupPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.Location = new System.Drawing.Point(518, 189);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 61);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackup.Location = new System.Drawing.Point(443, 296);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(103, 61);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Location = new System.Drawing.Point(599, 296);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(103, 61);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(64, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус:";
            // 
            // lblchooseDB
            // 
            this.lblchooseDB.AutoSize = true;
            this.lblchooseDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblchooseDB.Location = new System.Drawing.Point(44, 122);
            this.lblchooseDB.Name = "lblchooseDB";
            this.lblchooseDB.Size = new System.Drawing.Size(62, 13);
            this.lblchooseDB.TabIndex = 8;
            this.lblchooseDB.Text = "Выбор БД:";
            // 
            // lblRoad
            // 
            this.lblRoad.AutoSize = true;
            this.lblRoad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoad.Location = new System.Drawing.Point(44, 189);
            this.lblRoad.Name = "lblRoad";
            this.lblRoad.Size = new System.Drawing.Size(69, 13);
            this.lblRoad.TabIndex = 9;
            this.lblRoad.Text = "Путь файла:";
            this.lblRoad.Click += new System.EventHandler(this.lblRoad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 109);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Резервное копирование и восстановление БД";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(781, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRoad);
            this.Controls.Add(this.lblchooseDB);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxDatabases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupRestoreForm";
            this.Text = "BackupRestoreForm";
            this.Load += new System.EventHandler(this.BackupRestoreForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDatabases;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBackupUncommitted;
        private System.Windows.Forms.CheckBox chkBackupChanges;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblchooseDB;
        private System.Windows.Forms.Label lblRoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}