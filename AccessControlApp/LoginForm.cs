using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class LoginForm : Form
    {
        // Шаблон строки подключения для SQL-аутентификации
        private string connectionStringTemplate = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=UCHET;User ID={0};Password={1}";

        public LoginForm()
        {
            InitializeComponent();
            
        }

        // Обработчик нажатия на кнопку "Войти"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            // Формируем строку подключения
            string connectionString = string.Format(connectionStringTemplate, username, password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Пытаемся подключиться

                    // Определяем роль пользователя
                    string query = @"
                        SELECT 
                            ISNULL(IS_SRVROLEMEMBER('sysadmin'), 0) AS IsAdmin,
                            ISNULL(IS_MEMBER('HRManager'), 0) AS IsHRManager,
                            ISNULL(IS_MEMBER('Employee'), 0) AS IsEmployee";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Form nextForm = null;

                            if (reader.GetInt32(0) == 1) // Администратор
                            {
                                MessageBox.Show($"Добро пожаловать, {username} (Администратор)!");
                                nextForm = new MainForm(1, username);
                            }
                            else if (reader.GetInt32(1) == 1) // HR-менеджер
                            {
                                MessageBox.Show($"Добро пожаловать, {username} (HR Менеджер)!");
                                nextForm = new HRManagerForm(3, username);
                            }
                            else if (reader.GetInt32(2) == 1) // Сотрудник
                            {
                                MessageBox.Show($"Добро пожаловать, {username} (Сотрудник)!");
                                nextForm = new EmployeeForm(2, username);
                            }
                            else
                            {
                                MessageBox.Show("У вас нет доступа к системе.");
                                return;
                            }

                            if (nextForm != null)
                            {
                                nextForm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
