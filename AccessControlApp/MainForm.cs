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

            if (roleId == 1) // Только администратор
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
           
            lblRole.Text = "Роль: Администратор";
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

        private void btnEncryptedBackup_Click(object sender, EventArgs e)
        {
            EncryptedBackupRestoreForm encryptedBackupForm = new EncryptedBackupRestoreForm();
            encryptedBackupForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenAddEmployeeForm_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog(); // Открываем форму модально
        }
    }
}
