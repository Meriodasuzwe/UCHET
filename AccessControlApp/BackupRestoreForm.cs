using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class BackupRestoreForm : Form
    {
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=master;Integrated Security=True";

        public BackupRestoreForm()
        {
            InitializeComponent();
            LoadDatabases();
        }

        // Загрузка баз данных с сервера
        private void LoadDatabases()
        {
            comboBoxDatabases.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxDatabases.Items.Add(reader["name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке баз данных: " + ex.Message);
                }
            }

            if (comboBoxDatabases.Items.Count > 0)
                comboBoxDatabases.SelectedIndex = 0; // По умолчанию выбираем первую базу
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
            saveFileDialog.Title = "Выберите место для сохранения резервной копии";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = saveFileDialog.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string dbName = comboBoxDatabases.SelectedItem?.ToString();
            string backupPath = txtBackupPath.Text;

            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupPath))
            {
                MessageBox.Show("Выберите базу данных и укажите путь для резервной копии.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            if (chkBackupUncommitted.Checked)
            {
                // Резервное копирование незавершённых транзакций (журнал транзакций)
                query = $"BACKUP LOG [{dbName}] TO DISK = '{backupPath}' WITH NO_TRUNCATE;";
            }
            else
            {
                // Обычное резервное копирование базы данных
                string options = chkBackupChanges.Checked ? " WITH COPY_ONLY" : "";
                query = $"BACKUP DATABASE [{dbName}] TO DISK = '{backupPath}'{options};";
            }

            ExecuteSql(query, "Резервное копирование успешно завершено.");
        }


        //-----
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

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string dbName = comboBoxDatabases.SelectedItem?.ToString();
            string backupPath = txtBackupPath.Text;

            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupPath))
            {
                MessageBox.Show("Выберите базу данных и укажите путь к файлу резервной копии.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"
                ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{dbName}] FROM DISK = '{backupPath}' WITH REPLACE;
                ALTER DATABASE [{dbName}] SET MULTI_USER;
            ";

            ExecuteSql(query, "Восстановление базы данных успешно завершено.");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRoad_Click(object sender, EventArgs e)
        {

        }

        private void BackupRestoreForm_Load(object sender, EventArgs e)
        {

        }

        private void chkBackupUncommitted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBackupChanges_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

    