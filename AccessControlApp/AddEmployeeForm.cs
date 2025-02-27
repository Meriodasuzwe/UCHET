using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class AddEmployeeForm : Form
    {
        private string connectionString = "Server=WIN-T5MH0DHUEL9;Database=UCHET;Integrated Security=True;";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadPositions();
            radioButtonEmployee.Checked = true; // По умолчанию выбираем "Обычный сотрудник"
        }

        private void LoadDepartments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DepartmentCode, DepartmentName FROM Departments", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                comboBoxDepartment.DataSource = dt;
                comboBoxDepartment.DisplayMember = "DepartmentName";
                comboBoxDepartment.ValueMember = "DepartmentCode";
            }
        }

        private void LoadPositions()
        {
            string[] positions = { "Разнорабочий", "Уборщица", "Инженер", "Оператор", "Кладовщик", "Электрик" };
            comboBoxPosition.DataSource = positions;
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение всех полей
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                comboBoxDepartment.SelectedItem == null ||
                comboBoxPosition.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxAge.Text) ||  // Проверка на возраст
                string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, корректен ли возраст
           
            if (!int.TryParse(textBoxAge.Text.Trim(), out int age) || age <= 0)
            {
                MessageBox.Show("Введите корректный возраст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = $"{textBoxName.Text.Trim()} {textBoxSurname.Text.Trim()}";
            int departmentCode = (int)comboBoxDepartment.SelectedValue;
            string address = textBoxAddress.Text.Trim();
            string position = comboBoxPosition.SelectedItem.ToString();
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string role = radioButtonHR.Checked ? "HRManager" : "Employee"; // Выбор роли

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    
                    string query = @"INSERT INTO Employees (FullName, DepartmentCode, Address, Position, Age)
                             VALUES (@FullName, @DepartmentCode, @Address, @Position, @Age);";

                    using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@DepartmentCode", departmentCode);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Position", position);
                        cmd.Parameters.AddWithValue("@Age", age); 

                        cmd.ExecuteNonQuery();
                    }

                    string createLoginQuery = $"CREATE LOGIN [{login}] WITH PASSWORD = '{password}';";
                    new SqlCommand(createLoginQuery, conn, transaction).ExecuteNonQuery();

                    string createUserQuery = $"CREATE USER [{login}] FOR LOGIN [{login}];";
                    new SqlCommand(createUserQuery, conn, transaction).ExecuteNonQuery();

                    string grantRoleQuery = $"ALTER ROLE {role} ADD MEMBER [{login}];";
                    new SqlCommand(grantRoleQuery, conn, transaction).ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

