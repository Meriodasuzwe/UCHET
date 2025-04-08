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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFullBackup = new System.Windows.Forms.Button();
            this.btnDiffBackup = new System.Windows.Forms.Button();
            this.btnLogBackup = new System.Windows.Forms.Button();
            this.btnFullRes = new System.Windows.Forms.Button();
            this.btnDiffRes = new System.Windows.Forms.Button();
            this.btnLogRes = new System.Windows.Forms.Button();
            this.textBoxFull = new System.Windows.Forms.TextBox();
            this.textBoxDiff = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxDiffRes = new System.Windows.Forms.TextBox();
            this.textBoxFullRes = new System.Windows.Forms.TextBox();
            this.textBoxLogRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPassEnc = new System.Windows.Forms.TextBox();
            this.textBoxCert = new System.Windows.Forms.TextBox();
            this.btnCrKey = new System.Windows.Forms.Button();
            this.btnDelKey = new System.Windows.Forms.Button();
            this.btnCrCer = new System.Windows.Forms.Button();
            this.btnDelCer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxKeyCer = new System.Windows.Forms.TextBox();
            this.btnCrKeyCer = new System.Windows.Forms.Button();
            this.textBoxNewCert = new System.Windows.Forms.TextBox();
            this.btnNewCert = new System.Windows.Forms.Button();
            this.textBoxName_encDB = new System.Windows.Forms.TextBox();
            this.btnEncDB = new System.Windows.Forms.Button();
            this.btnResEncDB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.label5.Location = new System.Drawing.Point(1042, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "X";
            // 
            // btnFullBackup
            // 
            this.btnFullBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnFullBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullBackup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFullBackup.ForeColor = System.Drawing.Color.Black;
            this.btnFullBackup.Location = new System.Drawing.Point(317, 24);
            this.btnFullBackup.Name = "btnFullBackup";
            this.btnFullBackup.Size = new System.Drawing.Size(102, 31);
            this.btnFullBackup.TabIndex = 11;
            this.btnFullBackup.Text = "Выполнить";
            this.btnFullBackup.UseVisualStyleBackColor = false;
            this.btnFullBackup.Click += new System.EventHandler(this.btnFullBackup_Click);
            // 
            // btnDiffBackup
            // 
            this.btnDiffBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnDiffBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiffBackup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDiffBackup.ForeColor = System.Drawing.Color.Black;
            this.btnDiffBackup.Location = new System.Drawing.Point(317, 69);
            this.btnDiffBackup.Name = "btnDiffBackup";
            this.btnDiffBackup.Size = new System.Drawing.Size(102, 31);
            this.btnDiffBackup.TabIndex = 12;
            this.btnDiffBackup.Text = "Выполнить";
            this.btnDiffBackup.UseVisualStyleBackColor = false;
            this.btnDiffBackup.Click += new System.EventHandler(this.btnDiffBackup_Click);
            // 
            // btnLogBackup
            // 
            this.btnLogBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLogBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogBackup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogBackup.ForeColor = System.Drawing.Color.Black;
            this.btnLogBackup.Location = new System.Drawing.Point(317, 116);
            this.btnLogBackup.Name = "btnLogBackup";
            this.btnLogBackup.Size = new System.Drawing.Size(102, 31);
            this.btnLogBackup.TabIndex = 13;
            this.btnLogBackup.Text = "Выполнить";
            this.btnLogBackup.UseVisualStyleBackColor = false;
            this.btnLogBackup.Click += new System.EventHandler(this.btnLogBackup_Click);
            // 
            // btnFullRes
            // 
            this.btnFullRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnFullRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFullRes.ForeColor = System.Drawing.Color.Black;
            this.btnFullRes.Location = new System.Drawing.Point(317, 22);
            this.btnFullRes.Name = "btnFullRes";
            this.btnFullRes.Size = new System.Drawing.Size(102, 31);
            this.btnFullRes.TabIndex = 14;
            this.btnFullRes.Text = "Выполнить";
            this.btnFullRes.UseVisualStyleBackColor = false;
            this.btnFullRes.Click += new System.EventHandler(this.btnFullRes_Click);
            // 
            // btnDiffRes
            // 
            this.btnDiffRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnDiffRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiffRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDiffRes.ForeColor = System.Drawing.Color.Black;
            this.btnDiffRes.Location = new System.Drawing.Point(317, 63);
            this.btnDiffRes.Name = "btnDiffRes";
            this.btnDiffRes.Size = new System.Drawing.Size(102, 31);
            this.btnDiffRes.TabIndex = 15;
            this.btnDiffRes.Text = "Выполнить";
            this.btnDiffRes.UseVisualStyleBackColor = false;
            this.btnDiffRes.Click += new System.EventHandler(this.btnDiffRes_Click);
            // 
            // btnLogRes
            // 
            this.btnLogRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnLogRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogRes.ForeColor = System.Drawing.Color.Black;
            this.btnLogRes.Location = new System.Drawing.Point(317, 110);
            this.btnLogRes.Name = "btnLogRes";
            this.btnLogRes.Size = new System.Drawing.Size(102, 31);
            this.btnLogRes.TabIndex = 16;
            this.btnLogRes.Text = "Выполнить";
            this.btnLogRes.UseVisualStyleBackColor = false;
            this.btnLogRes.Click += new System.EventHandler(this.btnLogRes_Click);
            // 
            // textBoxFull
            // 
            this.textBoxFull.Location = new System.Drawing.Point(158, 26);
            this.textBoxFull.Name = "textBoxFull";
            this.textBoxFull.Size = new System.Drawing.Size(143, 27);
            this.textBoxFull.TabIndex = 17;
            // 
            // textBoxDiff
            // 
            this.textBoxDiff.Location = new System.Drawing.Point(158, 69);
            this.textBoxDiff.Name = "textBoxDiff";
            this.textBoxDiff.Size = new System.Drawing.Size(143, 27);
            this.textBoxDiff.TabIndex = 18;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(158, 118);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(143, 27);
            this.textBoxLog.TabIndex = 19;
            // 
            // textBoxDiffRes
            // 
            this.textBoxDiffRes.Location = new System.Drawing.Point(158, 65);
            this.textBoxDiffRes.Name = "textBoxDiffRes";
            this.textBoxDiffRes.Size = new System.Drawing.Size(143, 27);
            this.textBoxDiffRes.TabIndex = 20;
            // 
            // textBoxFullRes
            // 
            this.textBoxFullRes.Location = new System.Drawing.Point(158, 24);
            this.textBoxFullRes.Name = "textBoxFullRes";
            this.textBoxFullRes.Size = new System.Drawing.Size(143, 27);
            this.textBoxFullRes.TabIndex = 20;
            // 
            // textBoxLogRes
            // 
            this.textBoxLogRes.Location = new System.Drawing.Point(158, 112);
            this.textBoxLogRes.Name = "textBoxLogRes";
            this.textBoxLogRes.Size = new System.Drawing.Size(143, 27);
            this.textBoxLogRes.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Полное копирование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дифференциальное";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Журнала транзакций";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(20, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Полное";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(20, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дифференциальное";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(20, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Журнала транзакций";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFull);
            this.groupBox1.Controls.Add(this.btnFullBackup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDiffBackup);
            this.groupBox1.Controls.Add(this.btnLogBackup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDiff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(40, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 163);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Резервное копирование:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFullRes);
            this.groupBox2.Controls.Add(this.btnFullRes);
            this.groupBox2.Controls.Add(this.btnDiffRes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnLogRes);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDiffRes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxLogRes);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(40, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 163);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Резервное восстановление:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResEncDB);
            this.groupBox3.Controls.Add(this.btnEncDB);
            this.groupBox3.Controls.Add(this.textBoxName_encDB);
            this.groupBox3.Controls.Add(this.btnNewCert);
            this.groupBox3.Controls.Add(this.textBoxNewCert);
            this.groupBox3.Controls.Add(this.btnCrKeyCer);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxKeyCer);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnDelCer);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnDelKey);
            this.groupBox3.Controls.Add(this.btnCrCer);
            this.groupBox3.Controls.Add(this.btnCrKey);
            this.groupBox3.Controls.Add(this.textBoxPassEnc);
            this.groupBox3.Controls.Add(this.textBoxCert);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(502, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 438);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Мастер-ключ";
            // 
            // textBoxPassEnc
            // 
            this.textBoxPassEnc.Location = new System.Drawing.Point(142, 47);
            this.textBoxPassEnc.Name = "textBoxPassEnc";
            this.textBoxPassEnc.Size = new System.Drawing.Size(158, 27);
            this.textBoxPassEnc.TabIndex = 0;
            // 
            // textBoxCert
            // 
            this.textBoxCert.Location = new System.Drawing.Point(142, 103);
            this.textBoxCert.Name = "textBoxCert";
            this.textBoxCert.Size = new System.Drawing.Size(158, 27);
            this.textBoxCert.TabIndex = 1;
            // 
            // btnCrKey
            // 
            this.btnCrKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCrKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrKey.ForeColor = System.Drawing.Color.Black;
            this.btnCrKey.Location = new System.Drawing.Point(324, 43);
            this.btnCrKey.Name = "btnCrKey";
            this.btnCrKey.Size = new System.Drawing.Size(102, 31);
            this.btnCrKey.TabIndex = 2;
            this.btnCrKey.Text = "Создать";
            this.btnCrKey.UseVisualStyleBackColor = false;
            this.btnCrKey.Click += new System.EventHandler(this.btnCrKey_Click);
            // 
            // btnDelKey
            // 
            this.btnDelKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnDelKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelKey.ForeColor = System.Drawing.Color.Black;
            this.btnDelKey.Location = new System.Drawing.Point(443, 43);
            this.btnDelKey.Name = "btnDelKey";
            this.btnDelKey.Size = new System.Drawing.Size(102, 31);
            this.btnDelKey.TabIndex = 3;
            this.btnDelKey.Text = "Удалить";
            this.btnDelKey.UseVisualStyleBackColor = false;
            this.btnDelKey.Click += new System.EventHandler(this.btnDelKey_Click);
            // 
            // btnCrCer
            // 
            this.btnCrCer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCrCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrCer.ForeColor = System.Drawing.Color.Black;
            this.btnCrCer.Location = new System.Drawing.Point(324, 103);
            this.btnCrCer.Name = "btnCrCer";
            this.btnCrCer.Size = new System.Drawing.Size(102, 31);
            this.btnCrCer.TabIndex = 4;
            this.btnCrCer.Text = "Создать";
            this.btnCrCer.UseVisualStyleBackColor = false;
            this.btnCrCer.Click += new System.EventHandler(this.btnCrCer_Click);
            // 
            // btnDelCer
            // 
            this.btnDelCer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnDelCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCer.ForeColor = System.Drawing.Color.Black;
            this.btnDelCer.Location = new System.Drawing.Point(443, 104);
            this.btnDelCer.Name = "btnDelCer";
            this.btnDelCer.Size = new System.Drawing.Size(102, 31);
            this.btnDelCer.TabIndex = 4;
            this.btnDelCer.Text = "Удалить";
            this.btnDelCer.UseVisualStyleBackColor = false;
            this.btnDelCer.Click += new System.EventHandler(this.btnDelCer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Сертификата:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Введите пароль:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(13, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Введите пароль приватного ключа:";
            // 
            // textBoxKeyCer
            // 
            this.textBoxKeyCer.Location = new System.Drawing.Point(275, 171);
            this.textBoxKeyCer.Name = "textBoxKeyCer";
            this.textBoxKeyCer.Size = new System.Drawing.Size(151, 27);
            this.textBoxKeyCer.TabIndex = 8;
            // 
            // btnCrKeyCer
            // 
            this.btnCrKeyCer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCrKeyCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrKeyCer.ForeColor = System.Drawing.Color.Black;
            this.btnCrKeyCer.Location = new System.Drawing.Point(443, 169);
            this.btnCrKeyCer.Name = "btnCrKeyCer";
            this.btnCrKeyCer.Size = new System.Drawing.Size(102, 31);
            this.btnCrKeyCer.TabIndex = 9;
            this.btnCrKeyCer.Text = "Создать";
            this.btnCrKeyCer.UseVisualStyleBackColor = false;
            this.btnCrKeyCer.Click += new System.EventHandler(this.btnCrKeyCer_Click);
            // 
            // textBoxNewCert
            // 
            this.textBoxNewCert.Location = new System.Drawing.Point(275, 219);
            this.textBoxNewCert.Name = "textBoxNewCert";
            this.textBoxNewCert.Size = new System.Drawing.Size(151, 27);
            this.textBoxNewCert.TabIndex = 10;
            // 
            // btnNewCert
            // 
            this.btnNewCert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnNewCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCert.ForeColor = System.Drawing.Color.Black;
            this.btnNewCert.Location = new System.Drawing.Point(443, 221);
            this.btnNewCert.Name = "btnNewCert";
            this.btnNewCert.Size = new System.Drawing.Size(102, 31);
            this.btnNewCert.TabIndex = 11;
            this.btnNewCert.Text = "button1";
            this.btnNewCert.UseVisualStyleBackColor = false;
            this.btnNewCert.Click += new System.EventHandler(this.btnNewCert_Click);
            // 
            // textBoxName_encDB
            // 
            this.textBoxName_encDB.Location = new System.Drawing.Point(169, 289);
            this.textBoxName_encDB.Name = "textBoxName_encDB";
            this.textBoxName_encDB.Size = new System.Drawing.Size(100, 27);
            this.textBoxName_encDB.TabIndex = 12;
            // 
            // btnEncDB
            // 
            this.btnEncDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnEncDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncDB.ForeColor = System.Drawing.Color.Black;
            this.btnEncDB.Location = new System.Drawing.Point(304, 288);
            this.btnEncDB.Name = "btnEncDB";
            this.btnEncDB.Size = new System.Drawing.Size(122, 31);
            this.btnEncDB.TabIndex = 13;
            this.btnEncDB.Text = "Зашифровать";
            this.btnEncDB.UseVisualStyleBackColor = false;
            this.btnEncDB.Click += new System.EventHandler(this.btnEncDB_Click);
            // 
            // btnResEncDB
            // 
            this.btnResEncDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnResEncDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResEncDB.ForeColor = System.Drawing.Color.Black;
            this.btnResEncDB.Location = new System.Drawing.Point(443, 287);
            this.btnResEncDB.Name = "btnResEncDB";
            this.btnResEncDB.Size = new System.Drawing.Size(102, 31);
            this.btnResEncDB.TabIndex = 14;
            this.btnResEncDB.Text = "Восстановить";
            this.btnResEncDB.UseVisualStyleBackColor = false;
            this.btnResEncDB.Click += new System.EventHandler(this.btnResEncDB_Click);
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1073, 718);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupRestoreForm";
            this.Text = "BackupRestoreForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFullBackup;
        private System.Windows.Forms.Button btnDiffBackup;
        private System.Windows.Forms.Button btnLogBackup;
        private System.Windows.Forms.Button btnFullRes;
        private System.Windows.Forms.Button btnDiffRes;
        private System.Windows.Forms.Button btnLogRes;
        private System.Windows.Forms.TextBox textBoxFull;
        private System.Windows.Forms.TextBox textBoxDiff;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxDiffRes;
        private System.Windows.Forms.TextBox textBoxFullRes;
        private System.Windows.Forms.TextBox textBoxLogRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelCer;
        private System.Windows.Forms.Button btnCrCer;
        private System.Windows.Forms.Button btnDelKey;
        private System.Windows.Forms.Button btnCrKey;
        private System.Windows.Forms.TextBox textBoxCert;
        private System.Windows.Forms.TextBox textBoxPassEnc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCrKeyCer;
        private System.Windows.Forms.TextBox textBoxKeyCer;
        private System.Windows.Forms.Button btnNewCert;
        private System.Windows.Forms.TextBox textBoxNewCert;
        private System.Windows.Forms.Button btnEncDB;
        private System.Windows.Forms.TextBox textBoxName_encDB;
        private System.Windows.Forms.Button btnResEncDB;
    }
}