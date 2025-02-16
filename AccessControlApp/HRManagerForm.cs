using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class HRManagerForm : Form
    {
        private int roleId;
        private string fullName;

        // Конструктор, который принимает два аргумента
        public HRManagerForm(int roleId, string fullName)
        {
            InitializeComponent(); // Инициализация компонентов формы

            this.roleId = roleId;       // Сохранение roleId
            this.fullName = fullName;   // Сохранение имени пользователя

            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HRManagerForm_Load(object sender, EventArgs e)
        {

        }
    }

}
