using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class EmployeeForm : Form
    {
        private int roleId;
        private string fullName;

        // Строка подключения (если нужна для запроса)
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=Uchet;Integrated Security=True";

        public EmployeeForm(int roleId, string fullName)
        {
            InitializeComponent();

            this.roleId = roleId;
            this.fullName = fullName;

            SetupForm(); // Настройка интерфейса
        }

        // Метод для настройки интерфейса
        private void SetupForm()
        {
            lblEmployeeName.Text = $"Имя: {fullName}";

            if (roleId == 2) // Сотрудник
            {
                lblRole.Text = "Роль: Сотрудник";
                LoadEmployeeData(); // Загружаем данные сотрудника
            }
            else
            {
                lblRole.Text = "Роль: Неизвестная";
            }
        }

        // Метод для загрузки данных сотрудника
        private void LoadEmployeeData()
        {
            
            string query = @"
SELECT DISTINCT
    e.FullName AS [ФИО],
    d.DepartmentName AS [Департамент],
    eq.EquipmentName AS [Закрепленное оборудование],
    ic.StartDateOfUse AS [Дата начала использования],
    ic.InitialCost AS [Стоимость оборудования],
    ic.ManufactureDate AS [Дата изготовления]
FROM 
    Employees e
LEFT JOIN 
    InventoryCard ic ON e.EmployeeCode = ic.EmployeePLCode
LEFT JOIN 
    Departments d ON e.DepartmentCode = d.DepartmentCode
LEFT JOIN 
    Equipment eq ON ic.EquipmentCode = eq.EquipmentCode
WHERE 
    e.FullName = @FullName;


";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Открываем соединение

                    // Создаём адаптер и добавляем параметр
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@FullName", fullName);

                    // Заполняем DataTable результатами запроса
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Привязываем результат к DataGridView
                    dgvEmployeeData.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
