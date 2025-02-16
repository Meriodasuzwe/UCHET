namespace AccessControlApp
{
    partial class SecurityForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivileges = new System.Windows.Forms.ComboBox();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.btnGrant = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.checkedListBoxRoles = new System.Windows.Forms.CheckedListBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(76, 155);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(231, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назначение ролей и прав сотруднику";
            // 
            // comboBoxPrivileges
            // 
            this.comboBoxPrivileges.FormattingEnabled = true;
            this.comboBoxPrivileges.Location = new System.Drawing.Point(437, 155);
            this.comboBoxPrivileges.Name = "comboBoxPrivileges";
            this.comboBoxPrivileges.Size = new System.Drawing.Size(214, 21);
            this.comboBoxPrivileges.TabIndex = 3;
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.chkSelect.Location = new System.Drawing.Point(437, 215);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(69, 21);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "SELECT";
            this.chkSelect.UseVisualStyleBackColor = true;
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.chkInsert.Location = new System.Drawing.Point(583, 215);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.Size = new System.Drawing.Size(68, 21);
            this.chkInsert.TabIndex = 5;
            this.chkInsert.Text = "INSERT";
            this.chkInsert.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.chkUpdate.Location = new System.Drawing.Point(437, 252);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(73, 21);
            this.chkUpdate.TabIndex = 6;
            this.chkUpdate.Text = "UPDATE";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDelete.Location = new System.Drawing.Point(581, 252);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(70, 21);
            this.chkDelete.TabIndex = 7;
            this.chkDelete.Text = "DELETE";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // btnGrant
            // 
            this.btnGrant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGrant.Location = new System.Drawing.Point(509, 285);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(87, 54);
            this.btnGrant.TabIndex = 8;
            this.btnGrant.Text = "GRANT";
            this.btnGrant.UseVisualStyleBackColor = false;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnRevoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevoke.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRevoke.Location = new System.Drawing.Point(509, 357);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(87, 54);
            this.btnRevoke.TabIndex = 9;
            this.btnRevoke.Text = "REVOKE";
            this.btnRevoke.UseVisualStyleBackColor = false;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // checkedListBoxRoles
            // 
            this.checkedListBoxRoles.FormattingEnabled = true;
            this.checkedListBoxRoles.Location = new System.Drawing.Point(76, 215);
            this.checkedListBoxRoles.Name = "checkedListBoxRoles";
            this.checkedListBoxRoles.Size = new System.Drawing.Size(231, 109);
            this.checkedListBoxRoles.TabIndex = 10;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRole.Location = new System.Drawing.Point(76, 357);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(80, 54);
            this.btnAddRole.TabIndex = 11;
            this.btnAddRole.Text = "Добавить";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnRemoveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveRole.Location = new System.Drawing.Point(232, 357);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(75, 54);
            this.btnRemoveRole.TabIndex = 12;
            this.btnRemoveRole.Text = "Удалить";
            this.btnRemoveRole.UseVisualStyleBackColor = false;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 102);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessControlApp.Properties.Resources._9004760_unlock_padlock_access_security_icon;
            this.pictureBox1.Location = new System.Drawing.Point(76, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(434, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Добавление и  отмена привелегии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Логин пользователя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(73, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Добавление роли:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(434, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Привелегии:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(782, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveRole);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.checkedListBoxRoles);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnGrant);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.chkUpdate);
            this.Controls.Add(this.chkInsert);
            this.Controls.Add(this.chkSelect);
            this.Controls.Add(this.comboBoxPrivileges);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityForm";
            this.Text = "SecurityForm";
            this.Load += new System.EventHandler(this.SecurityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrivileges;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.CheckedListBox checkedListBoxRoles;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}