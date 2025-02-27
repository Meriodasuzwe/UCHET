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
        private bool isBackupMode = true;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (isBackupMode)
            {
                // Выбор пути для резервного копирования
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                saveFileDialog.Title = "Выберите место для сохранения резервной копии";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBackupPath.Text = saveFileDialog.FileName;
                }
            }
            else
            {
                // Выбор файла для восстановления
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл резервной копии";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRestorePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            isBackupMode = true;
            string dbName = comboBoxDatabases.SelectedItem?.ToString();
            string backupPath = txtBackupPath.Text;

            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupPath))
            {
                MessageBox.Show("Выберите базу данных и укажите путь для резервной копии.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            if (chkBackupUncommitted.Checked)
            {
                // Бэкап журнала транзакций (незавершённые изменения)
                query = $"BACKUP LOG [{dbName}] TO DISK = '{backupPath}' WITH NO_TRUNCATE;";
            }
            else if (chkBackupDifferential.Checked)
            {
                // Дифференциальный бэкап (только изменения с последнего полного)
                query = $"BACKUP DATABASE [{dbName}] TO DISK = '{backupPath}' WITH DIFFERENTIAL;";
            }
            else
            {
                // Полный бэкап (по умолчанию)
                string options = chkBackupChanges.Checked ? " WITH INIT" : "";
                query = $"BACKUP DATABASE [{dbName}] TO DISK = '{backupPath}'{options};";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                ExecuteSql(query, conn, "Резервное копирование успешно завершено.");
            }

        }



        //-----
        // Универсальный метод выполнения SQL-команд
        private void ExecuteSql(string query, SqlConnection conn, string successMessage = null)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrWhiteSpace(successMessage))
                {
                    lblStatus.Text = successMessage;
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка SQL: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRestore_Click(object sender, EventArgs e)
        {
            isBackupMode = false;
            string dbName = comboBoxDatabases.Text; // Или SelectedItem.ToString()
            string backupPath = txtRestorePath.Text;

            // 2. Проверяем, что пользователь ввел данные
            if (string.IsNullOrWhiteSpace(dbName) || string.IsNullOrWhiteSpace(backupPath))
            {
                MessageBox.Show("Укажите базу данных и путь к файлу резервной копии!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Пытаемся выполнить восстановление
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Формируем единый запрос
                    string query = $@"
                USE master;
                ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{dbName}]
                FROM DISK = '{backupPath}'
                WITH REPLACE, RECOVERY;
                ALTER DATABASE [{dbName}] SET MULTI_USER;
            ";

                    // Выполняем запрос
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Если все ок
                MessageBox.Show("Восстановление успешно завершено!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Если произошла ошибка
                MessageBox.Show("Ошибка при восстановлении: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Полное восстановление
        private void RestoreFullBackup(string dbName, string backupPath)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $@"
            USE [master]; 
            ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; 
            RESTORE DATABASE [{dbName}] FROM DISK = '{backupPath}' 
            WITH REPLACE, RECOVERY;
            ALTER DATABASE [{dbName}] SET MULTI_USER;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Полное восстановление выполнено успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при восстановлении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Дифференциальное восстановление
        private void RestoreDifferentialBackup(string dbName, string backupPath, SqlConnection conn)
        {
            string query = $@"
    RESTORE DATABASE [{dbName}] FROM DISK = '{backupPath}' WITH RECOVERY;
    ALTER DATABASE [{dbName}] SET MULTI_USER;
    ";
            ExecuteSql(query, conn);
        }

        // Восстановление журнала транзакций
        private void RestoreLogBackup(string dbName, string backupPath, SqlConnection conn)
        {
            string query = $@"
    RESTORE LOG [{dbName}] FROM DISK = '{backupPath}' WITH RECOVERY;";
            ExecuteSql(query, conn);
        }
        // Проверка наличия полного бэкапа перед дифференциальным или логовым восстановлением
        private bool IsFullBackupExists(string dbName, SqlConnection conn)
        {
            string query = $"RESTORE HEADERONLY FROM DISK = '{txtBackupPath.Text}'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader()) // Используем ExecuteReader()
                {
                    return reader.HasRows; // Проверяем, есть ли данные
                }
            }
            catch
            {
                return false;
            }
        }

        //RESTORE END



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

        private void chkBackupDifferential_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл дифференциального бэкапа";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDiffBackupPath.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseDiff_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Transaction Log files (*.trn)|*.trn|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл журнала транзакций";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLogPath.Text = openFileDialog.FileName;
            }
        }

        private void rbFullRestore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRestorePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    