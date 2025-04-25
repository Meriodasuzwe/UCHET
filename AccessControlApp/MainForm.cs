using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class MainForm : Form
    {
        private int roleId;
        private string fullName;

        // Строка подключения к базе данных
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=Uchet;Integrated Security=True";

        public MainForm(int roleId, string fullName)
        {
            InitializeComponent();
            this.btnOpenAddEmployeeForm.Click += new System.EventHandler(this.btnOpenAddEmployeeForm_Click);

            this.roleId = roleId;
            this.fullName = fullName;

            if (roleId == 1 || roleId == 2) // Только администратор
            {
                SetupForm();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void SetupForm()
        {

            if (roleId == 1) // Администратор
            {
                lblRole.Text = "Роль: Администратор";
                btnSecurity.Visible = true;
                btnBackupRestore.Visible = true;
                
                btnImportExport.Visible = true;
                btnOpenAddEmployeeForm.Visible = true;
                btnInventoryCard.Visible = true;
            }
            else if (roleId == 2) // HRManager
            {
                lblRole.Text = "Роль: Менеджер отдела кадров";
                btnSecurity.Visible = false;
                btnBackupRestore.Visible = false;
                
                btnImportExport.Visible = true;
                btnOpenAddEmployeeForm.Visible = true;
                btnInventoryCard.Visible = true;
            }
        }

        // Метод для создания логина и пользователя
        
        private void btnSecurity_Click(object sender, EventArgs e)
        {
            SecurityForm securityForm = new SecurityForm();
            securityForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            BackupRestoreForm backupForm = new BackupRestoreForm();
            backupForm.ShowDialog();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenAddEmployeeForm_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog(); // Открываем форму модально
        }

        private void btnImportExport_Click(object sender, EventArgs e)
        {
            ImportExportForm importExportForm = new ImportExportForm();
            importExportForm.ShowDialog();
        }

        private void btnInventoryCard_Click(object sender, EventArgs e)
        {
            EquipmentViewerForm equipmentViewerForm = new EquipmentViewerForm();
            equipmentViewerForm.ShowDialog();
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            auditt auditt = new auditt();
            auditt.ShowDialog();
        }
    }
}
