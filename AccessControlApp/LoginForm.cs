using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class LoginForm : Form
    {
        // Строка подключения с использованием параметров безопасности
        private string _connectionStringTemplate = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=UCHET;User ID={0};Password={1};";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = string.Format(_connectionStringTemplate, username, password);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Проверка ролей в базе данных
                    string roleQuery = @"
                        SELECT 
                            ISNULL(IS_MEMBER('db_owner'), 0) AS IsAdmin,
                            ISNULL(IS_MEMBER('HRManager'), 0) AS IsHRManager,
                            ISNULL(IS_MEMBER('Employee'), 0) AS IsEmployee";

                    using (SqlCommand cmd = new SqlCommand(roleQuery, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int isAdmin = reader.GetInt32(0);
                            int isHRManager = reader.GetInt32(1);
                            int isEmployee = reader.GetInt32(2);

                            Form nextForm = null;

                            if (isAdmin == 1)
                            {
                                nextForm = new MainForm(roleId: 1, fullName: username);
                            }
                            else if (isHRManager == 1)
                            {
                                nextForm = new MainForm(roleId: 2, fullName: username);
                            }
                            else if (isEmployee == 1)
                            {
                                nextForm = new EmployeeForm(roleId: 3, fullName: username);
                            }
                            else
                            {
                                MessageBox.Show("Доступ запрещён.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (nextForm != null)
                            {
                                this.Hide();
                                nextForm.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка аутентификации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Закрытие формы
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}