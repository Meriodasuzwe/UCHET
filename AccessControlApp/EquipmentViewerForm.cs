using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class EquipmentViewerForm : Form
    {
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=Uchet;Integrated Security=True";

        public EquipmentViewerForm()
        {
            InitializeComponent();
            InitializeAdditionalComponents();
        }

        // Инициализация дополнительных элементов
        private void InitializeAdditionalComponents()
        {
            // ComboBox для фильтрации по категориям
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;

            // Кнопка экспорта
            btnExport.Text = "Экспорт в CSV";
            btnExport.Click += btnExport_Click;

            // Кнопка обновления
            btnRefresh.Click += btnRefresh_Click;
        }

        // Загрузка данных с фильтрами
        private void LoadEquipment(string equipmentFilter = "", string categoryFilter = "")
        {
            string query = @"
                SELECT 
                    e.EquipmentName AS 'Оборудование',
                    c.CategoryName AS 'Категория',
                    ic.InitialCost AS 'Начальная стоимость',
                    ic.ManufactureDate AS 'Дата выпуска',
                    emp.FullName AS 'Ответственный',
                    ic.DepartmentCode AS 'Код отдела'
                FROM InventoryCard ic
                JOIN Equipment e ON ic.EquipmentCode = e.EquipmentCode
                JOIN EquipmentCategories c ON ic.EquipmentCategoryCode = c.EquipmentCategoryCode
                LEFT JOIN Employees emp ON ic.EmployeePLCode = emp.EmployeeCode
                WHERE 1=1";

            if (!string.IsNullOrEmpty(equipmentFilter))
                query += " AND e.EquipmentName LIKE @equipmentFilter";

            if (!string.IsNullOrEmpty(categoryFilter) && cmbCategories.SelectedIndex > 0)
                query += " AND c.CategoryName = @categoryFilter";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    if (!string.IsNullOrEmpty(equipmentFilter))
                        da.SelectCommand.Parameters.AddWithValue("@equipmentFilter", "%" + equipmentFilter + "%");

                    if (!string.IsNullOrEmpty(categoryFilter) && cmbCategories.SelectedIndex > 0)
                        da.SelectCommand.Parameters.AddWithValue("@categoryFilter", categoryFilter);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEquipment.DataSource = dt;

                    // Настройка ширины столбцов
                    dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загрузка категорий в ComboBox
        private void LoadCategories()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CategoryName FROM EquipmentCategories", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbCategories.Items.Clear();
                    cmbCategories.Items.Add("Все категории");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmbCategories.Items.Add(reader["CategoryName"].ToString());
                        }
                        cmbCategories.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Нет доступных категорий.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // События
        private void EquipmentViewerForm_Load(object sender, EventArgs e)
        {
            LoadEquipment();
            LoadCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string categoryFilter = cmbCategories.SelectedIndex > 0 ? cmbCategories.SelectedItem.ToString() : "";
            LoadEquipment(txtSearch.Text, categoryFilter);
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV файлы|*.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            // Заголовки
                            sw.WriteLine(string.Join(";", dgvEquipment.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText)));

                            // Данные
                            foreach (DataGridViewRow row in dgvEquipment.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    sw.WriteLine(string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "")));
                                }
                            }
                        }
                        MessageBox.Show("Экспорт завершен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategories.SelectedIndex = 0;
            LoadEquipment();
        }

        private int GetEquipmentId(string equipmentName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT EquipmentCode FROM Equipment WHERE EquipmentName = @Name",
                        con
                    );
                    cmd.Parameters.AddWithValue("@Name", equipmentName);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения ID: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void dgvEquipment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            try
            {
                string columnName = dgvEquipment.Columns[e.ColumnIndex].HeaderText;
                string newValue = dgvEquipment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

                // Обновление только для столбца "Оборудование"
                if (columnName == "Оборудование")
                {
                    int equipmentId = GetEquipmentId(newValue);
                    if (equipmentId == -1)
                    {
                        MessageBox.Show("Оборудование не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE Equipment SET EquipmentName = @Name WHERE EquipmentCode = @ID",
                            con
                        );
                        cmd.Parameters.AddWithValue("@Name", newValue);
                        cmd.Parameters.AddWithValue("@ID", equipmentId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}