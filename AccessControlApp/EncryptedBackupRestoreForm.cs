using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class EncryptedBackupRestoreForm : Form
    {
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=master;Integrated Security=True";
        public EncryptedBackupRestoreForm()
        {
            InitializeComponent();
            LoadDatabases();
            


        }
        private void LoadDatabases()
        {
            comboBoxDatabases.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxDatabases.Items.Add(reader["name"].ToString());
                }
            }
            if (comboBoxDatabases.Items.Count > 0)
                comboBoxDatabases.SelectedIndex = 0;
        }

        private void CreateMasterKeyAndCertificate(string certName, string masterKeyPassword)
        {
            string certPath = $@"C:\Student\Certify\{certName}.cer";
            string keyPath = $@"C:\Student\Certify\{certName}.pvk";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Создание мастер-ключа
                SqlCommand cmd = new SqlCommand($@"
            IF NOT EXISTS (SELECT * FROM sys.symmetric_keys WHERE name LIKE '%DatabaseMasterKey%')
                CREATE MASTER KEY ENCRYPTION BY PASSWORD = '{masterKeyPassword}';
            
            IF NOT EXISTS (SELECT * FROM sys.certificates WHERE name = '{certName}')
                CREATE CERTIFICATE {certName} WITH SUBJECT = 'My Secure Backup';
            
            BACKUP CERTIFICATE {certName}
            TO FILE = '{certPath}'
            WITH PRIVATE KEY (
                FILE = '{keyPath}',
                ENCRYPTION BY PASSWORD = '{masterKeyPassword}'
            );", conn);

                cmd.ExecuteNonQuery();
            }

            lblStatus.Text = $"Сертификат '{certName}' и мастер-ключ созданы и сохранены в {certPath}";
        }




        private void EncryptedBackupRestoreForm_Load(object sender, EventArgs e)
        {

        }

        private void chkCreateCert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreateCert.Checked)
            {
                string certName = txtCertName.Text.Trim();
                string masterKeyPassword = txtMasterKeyPassword.Text;

                if (string.IsNullOrWhiteSpace(certName) || string.IsNullOrWhiteSpace(masterKeyPassword))
                {
                    MessageBox.Show("Введите имя сертификата и пароль для мастер-ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkCreateCert.Checked = false; // снимаем галочку, если не введены данные
                    return;
                }

                CreateMasterKeyAndCertificate(certName, masterKeyPassword);
            }
        }

        private void btnEncryptedBackup_Click(object sender, EventArgs e)
        {
            string dbName = comboBoxDatabases.SelectedItem?.ToString();
            string backupPath = txtBackupPath.Text;
            string certName = txtCertName.Text.Trim();
            if (string.IsNullOrEmpty(certName))
            {
                MessageBox.Show("Введите имя сертификата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupPath))
            {
                MessageBox.Show("Выберите базу данных и путь для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"
        BACKUP DATABASE [{dbName}]  
        TO DISK = N'{backupPath}'  
        WITH COMPRESSION, 
             ENCRYPTION (ALGORITHM = AES_256, SERVER CERTIFICATE = [{certName}]),  
             STATS = 10;";

            ExecuteSql(query, "Зашифрованная резервная копия успешно создана.");
        }

        private void btnEncryptedRestore_Click(object sender, EventArgs e)
        {
            string dbName = comboBoxDatabases.SelectedItem?.ToString();
            string backupPath = txtBackupPath.Text;

            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupPath))
            {
                MessageBox.Show("Выберите базу данных и путь к файлу резервной копии.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"
        ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        RESTORE DATABASE [{dbName}] FROM DISK = '{backupPath}' WITH REPLACE, STATS = 5;
        ALTER DATABASE [{dbName}] SET MULTI_USER;";

            ExecuteSql(query, "Зашифрованная база данных успешно восстановлена.");
        }
        private void ExecuteSql(string query, string successMessage)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    lblStatus.Text = successMessage;
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка SQL: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
                saveFileDialog.Title = "Выберите место для сохранения резервной копии";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBackupPath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void txtCertName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMasterKeyPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
