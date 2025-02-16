using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class SecurityForm : Form
    {
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=Uchet;Integrated Security=True";

        public SecurityForm()
        {
            InitializeComponent();
            LoadDatabaseRoles();
            LoadPrivileges();
        }

        // Загрузка ролей из базы данных
        private void LoadDatabaseRoles()
        {
            checkedListBoxRoles.Items.Clear();
            string[] roles = {
                "db_accessadmin", "db_backupoperator", "db_datareader",
                "db_datawriter", "db_ddladmin", "db_denydatareader",
                "db_denydatawriter", "db_owner"
            };
            checkedListBoxRoles.Items.AddRange(roles);
        }

        // Выдача привилегий
        private void btnGrant_Click(object sender, EventArgs e)
        {
            GrantPrivileges();
        }

        // Отзыв привилегий
        private void btnRevoke_Click(object sender, EventArgs e)
        {
            RevokePrivileges();
        }

        // Основной метод для управления привилегиями
        private void ManagePrivileges(string action)
        {
            string userName = txtUserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tableName = "Employees";
            string query = "";

            // Используем FROM для REVOKE и TO для GRANT
            string target = action == "REVOKE" ? "FROM" : "TO";

            if (chkSelect.Checked) query += $"{action} SELECT ON {tableName} {target} [{userName}]; ";
            if (chkInsert.Checked) query += $"{action} INSERT ON {tableName} {target} [{userName}]; ";
            if (chkUpdate.Checked) query += $"{action} UPDATE ON {tableName} {target} [{userName}]; ";
            if (chkDelete.Checked) query += $"{action} DELETE ON {tableName} {target} [{userName}]; ";

            ExecuteSql(query, $"{action} привилегий выполнено!");
        }


        // Добавление ролей пользователю
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";
            foreach (var item in checkedListBoxRoles.CheckedItems)
            {
                string role = item.ToString();
                query += $"ALTER ROLE [{role}] ADD MEMBER [{userName}]; ";
            }

            ExecuteSql(query, "Роли успешно добавлены пользователю!");
        }

        // Удаление ролей у пользователя
        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";
            foreach (var item in checkedListBoxRoles.CheckedItems)
            {
                string role = item.ToString();
                query += $"ALTER ROLE [{role}] DROP MEMBER [{userName}]; ";
            }

            ExecuteSql(query, "Роли успешно удалены у пользователя!");
        }

        // Универсальный метод для выполнения SQL-запросов
        private void ExecuteSql(string query, string successMessage)
        {
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Не выбраны действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка SQL: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {

        }
        private void GrantPrivileges()
        {
            string userName = txtUserName.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkedListBoxRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну роль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            foreach (var item in checkedListBoxRoles.CheckedItems)
            {
                string role = item.ToString();
                query += $"ALTER ROLE [{role}] ADD MEMBER [{userName}]; ";
            }

            ExecuteSql(query, "Роли успешно назначены!");
        }

        private void RevokePrivileges()
        {
            string userName = txtUserName.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkedListBoxRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну роль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            foreach (var item in checkedListBoxRoles.CheckedItems)
            {
                string role = item.ToString();
                query += $"ALTER ROLE [{role}] DROP MEMBER [{userName}]; ";
            }

            ExecuteSql(query, "Роли успешно отозваны!");
        }
        private void LoadPrivileges()
        {
            comboBoxPrivileges.Items.Clear(); // Очистка перед загрузкой

            // Добавление привилегий
            comboBoxPrivileges.Items.Add("GRANT");
            comboBoxPrivileges.Items.Add("REVOKE");

            // Выбор первого элемента по умолчанию
            if (comboBoxPrivileges.Items.Count > 0)
            {
                comboBoxPrivileges.SelectedIndex = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
