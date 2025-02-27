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
            this.chkBackupDifferential = new System.Windows.Forms.CheckBox();
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
            this.txtLogPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullRestore = new System.Windows.Forms.RadioButton();
            this.rbDiffRestore = new System.Windows.Forms.RadioButton();
            this.rbLogRestore = new System.Windows.Forms.RadioButton();
            this.txtDiffBackupPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowseDiff = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowseLog = new Guna.UI2.WinForms.Guna2Button();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.chkBackupDifferential);
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
            // chkBackupDifferential
            // 
            this.chkBackupDifferential.AutoSize = true;
            this.chkBackupDifferential.Location = new System.Drawing.Point(19, 65);
            this.chkBackupDifferential.Name = "chkBackupDifferential";
            this.chkBackupDifferential.Size = new System.Drawing.Size(164, 17);
            this.chkBackupDifferential.TabIndex = 2;
            this.chkBackupDifferential.Text = "Дифференциальный бэкап";
            this.chkBackupDifferential.UseVisualStyleBackColor = true;
            this.chkBackupDifferential.CheckedChanged += new System.EventHandler(this.chkBackupDifferential_CheckedChanged);
            // 
            // chkBackupUncommitted
            // 
            this.chkBackupUncommitted.AutoSize = true;
            this.chkBackupUncommitted.Location = new System.Drawing.Point(19, 42);
            this.chkBackupUncommitted.Name = "chkBackupUncommitted";
            this.chkBackupUncommitted.Size = new System.Drawing.Size(165, 17);
            this.chkBackupUncommitted.TabIndex = 1;
            this.chkBackupUncommitted.Text = "Бэкап журнала транзакций";
            this.chkBackupUncommitted.UseVisualStyleBackColor = true;
            this.chkBackupUncommitted.CheckedChanged += new System.EventHandler(this.chkBackupUncommitted_CheckedChanged);
            // 
            // chkBackupChanges
            // 
            this.chkBackupChanges.AutoSize = true;
            this.chkBackupChanges.Location = new System.Drawing.Point(19, 19);
            this.chkBackupChanges.Name = "chkBackupChanges";
            this.chkBackupChanges.Size = new System.Drawing.Size(99, 17);
            this.chkBackupChanges.TabIndex = 0;
            this.chkBackupChanges.Text = "Полный бэкап";
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
            this.btnBrowse.Location = new System.Drawing.Point(404, 125);
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
            this.btnBackup.Location = new System.Drawing.Point(709, 125);
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
            this.btnRestore.Location = new System.Drawing.Point(570, 125);
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
            this.lblStatus.Location = new System.Drawing.Point(62, 453);
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
            this.label5.Location = new System.Drawing.Point(886, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogPath.DefaultText = "";
            this.txtLogPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogPath.Location = new System.Drawing.Point(635, 450);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.PasswordChar = '\0';
            this.txtLogPath.PlaceholderText = "";
            this.txtLogPath.SelectedText = "";
            this.txtLogPath.Size = new System.Drawing.Size(200, 16);
            this.txtLogPath.TabIndex = 15;
            // 
            // FullRestore
            // 
            this.FullRestore.AutoSize = true;
            this.FullRestore.Location = new System.Drawing.Point(491, 331);
            this.FullRestore.Name = "FullRestore";
            this.FullRestore.Size = new System.Drawing.Size(78, 17);
            this.FullRestore.TabIndex = 16;
            this.FullRestore.TabStop = true;
            this.FullRestore.Text = "FullRestore";
            this.FullRestore.UseVisualStyleBackColor = true;
            this.FullRestore.CheckedChanged += new System.EventHandler(this.rbFullRestore_CheckedChanged);
            // 
            // rbDiffRestore
            // 
            this.rbDiffRestore.AutoSize = true;
            this.rbDiffRestore.Location = new System.Drawing.Point(491, 379);
            this.rbDiffRestore.Name = "rbDiffRestore";
            this.rbDiffRestore.Size = new System.Drawing.Size(87, 17);
            this.rbDiffRestore.TabIndex = 17;
            this.rbDiffRestore.TabStop = true;
            this.rbDiffRestore.Text = "rbDiffRestore";
            this.rbDiffRestore.UseVisualStyleBackColor = true;
            // 
            // rbLogRestore
            // 
            this.rbLogRestore.AutoSize = true;
            this.rbLogRestore.Location = new System.Drawing.Point(491, 449);
            this.rbLogRestore.Name = "rbLogRestore";
            this.rbLogRestore.Size = new System.Drawing.Size(89, 17);
            this.rbLogRestore.TabIndex = 18;
            this.rbLogRestore.TabStop = true;
            this.rbLogRestore.Text = "rbLogRestore";
            this.rbLogRestore.UseVisualStyleBackColor = true;
            // 
            // txtDiffBackupPath
            // 
            this.txtDiffBackupPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiffBackupPath.DefaultText = "";
            this.txtDiffBackupPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiffBackupPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiffBackupPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiffBackupPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiffBackupPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiffBackupPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiffBackupPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiffBackupPath.Location = new System.Drawing.Point(635, 379);
            this.txtDiffBackupPath.Name = "txtDiffBackupPath";
            this.txtDiffBackupPath.PasswordChar = '\0';
            this.txtDiffBackupPath.PlaceholderText = "";
            this.txtDiffBackupPath.SelectedText = "";
            this.txtDiffBackupPath.Size = new System.Drawing.Size(200, 13);
            this.txtDiffBackupPath.TabIndex = 19;
            // 
            // btnBrowseDiff
            // 
            this.btnBrowseDiff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseDiff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseDiff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseDiff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseDiff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseDiff.ForeColor = System.Drawing.Color.White;
            this.btnBrowseDiff.Location = new System.Drawing.Point(635, 398);
            this.btnBrowseDiff.Name = "btnBrowseDiff";
            this.btnBrowseDiff.Size = new System.Drawing.Size(200, 23);
            this.btnBrowseDiff.TabIndex = 20;
            this.btnBrowseDiff.Text = "дифф востановление путь";
            this.btnBrowseDiff.Click += new System.EventHandler(this.btnBrowseDiff_Click);
            // 
            // btnBrowseLog
            // 
            this.btnBrowseLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseLog.ForeColor = System.Drawing.Color.White;
            this.btnBrowseLog.Location = new System.Drawing.Point(635, 472);
            this.btnBrowseLog.Name = "btnBrowseLog";
            this.btnBrowseLog.Size = new System.Drawing.Size(200, 21);
            this.btnBrowseLog.TabIndex = 21;
            this.btnBrowseLog.Text = "Поиск журнала транзакций";
            this.btnBrowseLog.Click += new System.EventHandler(this.btnBrowseLog_Click);
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Location = new System.Drawing.Point(491, 212);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(321, 20);
            this.txtRestorePath.TabIndex = 22;
            this.txtRestorePath.TextChanged += new System.EventHandler(this.txtRestorePath_TextChanged);
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(905, 505);
            this.Controls.Add(this.txtRestorePath);
            this.Controls.Add(this.btnBrowseLog);
            this.Controls.Add(this.btnBrowseDiff);
            this.Controls.Add(this.txtDiffBackupPath);
            this.Controls.Add(this.rbLogRestore);
            this.Controls.Add(this.rbDiffRestore);
            this.Controls.Add(this.FullRestore);
            this.Controls.Add(this.txtLogPath);
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
        private System.Windows.Forms.CheckBox chkBackupDifferential;
        private Guna.UI2.WinForms.Guna2TextBox txtLogPath;
        private System.Windows.Forms.RadioButton FullRestore;
        private System.Windows.Forms.RadioButton rbDiffRestore;
        private System.Windows.Forms.RadioButton rbLogRestore;
        private Guna.UI2.WinForms.Guna2TextBox txtDiffBackupPath;
        private Guna.UI2.WinForms.Guna2Button btnBrowseDiff;
        private Guna.UI2.WinForms.Guna2Button btnBrowseLog;
        private System.Windows.Forms.TextBox txtRestorePath;
    }
}