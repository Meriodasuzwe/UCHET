using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class auditt : Form
    {
        SqlConnection conVideoteka = new SqlConnection(@"Data Source=WIN-T5MH0DHUEL9;Integrated Security=SSPI;Initial Catalog=UCHET");
        SqlConnection conMaster = new SqlConnection(@"Data Source=WIN-T5MH0DHUEL9;Integrated Security=SSPI;Initial Catalog=master");
        public auditt()
        {
            InitializeComponent();
        }
        private void LoadAuditAndDirectors()
        {
            try
            {
                conMaster.Open(); 

                using (SqlCommand cmd = new SqlCommand("sp_ViewAudit", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        System.Data.DataSet ds = new System.Data.DataSet();
                        adapter.Fill(ds);

                        // Первый результат — аудит
                        if (ds.Tables.Count > 0)
                            dataGridView1.DataSource = ds.Tables[0];


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }
        private void auditt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conMaster.Open(); // открываем подключение к master
                using (SqlCommand cmd = new SqlCommand("sp_CreateServerAuditSimple", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудит успешно создан.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании аудита: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conMaster.Open(); // Используем подключение к master
                using (SqlCommand cmd = new SqlCommand("sp_DropServerAudit", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудит успешно удалён.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении аудита: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conMaster.Open();
                using (SqlCommand cmd = new SqlCommand("sp_EnableServerAudit", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудит включён.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при включении аудита: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conMaster.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DisableServerAudit", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудит отключён.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отключении аудита: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем соединение
                conMaster.Open();

                using (SqlCommand cmd = new SqlCommand("sp_srvauditspecif", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@srvspecname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text);

                    // Формируем список ролей из CheckedListBox
                    // Проверяем, что есть выбранные элементы
                    if (checkedListBox1.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Не выбраны роли для спецификации!");
                        return;
                    }

                    // Формируем строку из ролей
                    string roles = string.Join(",", checkedListBox1.CheckedItems.Cast<string>());

                    // Добавляем к параметрам
                    cmd.Parameters.AddWithValue("@specification", roles);

                    // Выполнение команды
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудиторская спецификация успешно создана.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем соединение
                conVideoteka.Open();

                using (SqlCommand cmd = new SqlCommand("sp_srvauditspecif", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@srvspecname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text);

                    // Формируем список ролей из CheckedListBox
                    // Проверяем, что есть выбранные элементы
                    if (checkedListBox1.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Не выбраны роли для спецификации!");
                        return;
                    }

                    // Формируем строку из ролей
                    string roles = string.Join(",", checkedListBox1.CheckedItems.Cast<string>());

                    // Добавляем к параметрам
                    cmd.Parameters.AddWithValue("@specification", roles);

                    // Выполнение команды
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудиторская спецификация успешно создана.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadAuditAndDirectors();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем соединение
                conMaster.Open();

                using (SqlCommand cmd = new SqlCommand("sp_dbauditspecif", conMaster))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dbvspecname", textBox3.Text);
                    cmd.Parameters.AddWithValue("@AuditName", textBox1.Text);

                    // Формируем список ролей из CheckedListBox
                    // Проверяем, что есть выбранные элементы
                    if (checkedListBox3.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Не выбраны роли для спецификации!");
                        return;
                    }

                    // Формируем строку из ролей
                    string roles = string.Join(",", checkedListBox3.CheckedItems.Cast<string>());
                    string spec = string.Join(",", checkedListBox2.CheckedItems.Cast<string>());
                    // Добавляем к параметрам
                    cmd.Parameters.AddWithValue("@roles", roles);
                    cmd.Parameters.AddWithValue("@specif", spec);
                    // Выполнение команды
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудиторская спецификация успешно создана.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (conMaster.State == ConnectionState.Open)
                    conMaster.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка наличия имени спецификации
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Введите имя спецификации для удаления.");
                    return;
                }

                conVideoteka.Open();

                using (SqlCommand cmd = new SqlCommand("sp_dbauditspecif_delete", conVideoteka))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dbvspecname", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аудиторская спецификация успешно удалена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
            finally
            {
                if (conVideoteka.State == ConnectionState.Open)
                    conVideoteka.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
