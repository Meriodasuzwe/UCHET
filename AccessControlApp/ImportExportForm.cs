using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class ImportExportForm : Form
    {
        public ImportExportForm()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel файлы (*.xlsx)|*.xlsx",
                Title = "Сохранить Excel файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataToExcel(saveFileDialog.FileName);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Выберите файл Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportDataFromExcel(openFileDialog.FileName);
            }
        }

        private void ImportExportForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для импорта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Данные успешно загружены в DataGridView!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ImportDataFromExcel(string filePath)
        {
            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    // Заполняем заголовки
                    for (int col = 1; col <= colCount; col++)
                    {
                        string columnName = worksheet.Cells[1, col].Text.Trim();
                        if (string.IsNullOrEmpty(columnName)) columnName = "Column " + col;
                        dataGridView1.Columns.Add("col" + col, columnName);
                    }

                    // Заполняем строки
                    for (int row = 2; row <= rowCount; row++) // Начинаем с 2-й строки, так как 1-я - заголовки
                    {
                        object[] rowData = new object[colCount];
                        for (int col = 1; col <= colCount; col++)
                        {
                            rowData[col - 1] = worksheet.Cells[row, col].Value;
                        }
                        dataGridView1.Rows.Add(rowData);
                    }

                    MessageBox.Show("Данные успешно импортированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка импорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод экспорта данных в Excel
        private void ExportDataToExcel(string filePath)
        {
            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    int rowCount = dataGridView1.Rows.Count;
                    int colCount = dataGridView1.Columns.Count;

                    // Заголовки столбцов
                    for (int col = 0; col < colCount; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                        worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                    }

                    // Данные из DataGridView
                    for (int row = 0; row < rowCount; row++)
                    {
                        for (int col = 0; col < colCount; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value;
                        }
                    }

                    // Сохранение файла
                    FileInfo file = new FileInfo(filePath);
                    package.SaveAs(file);

                    MessageBox.Show("Данные успешно экспортированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

