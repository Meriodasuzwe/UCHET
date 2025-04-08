using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AccessControlApp
{
    public partial class BackupRestoreForm : Form
    {
        private string connectionString = "Data Source=WIN-T5MH0DHUEL9;Initial Catalog=master;Integrated Security=True";
        private SqlConnection con;
        public BackupRestoreForm()
        {
            InitializeComponent();

            con = new SqlConnection("Data Source=WIN-T5MH0DHUEL9;Initial Catalog=master;Integrated Security=True;");
        }

        private void btnFullBackup_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BACKUP DATABASE UCHET TO DISK = N'C:\\Student\\Backups\\"
                + textBoxFull.Text + ".bak' WITH INIT;", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Полная резервная копия создана!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDiffBackup_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BACKUP DATABASE UCHET TO DISK = N'C:\\Student\\Backups\\"
                + textBoxDiff.Text + ".bak' WITH DIFFERENTIAL;", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Дифференциальная резервная копия создана!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnLogBackup_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BACKUP LOG UCHET TO DISK = N'C:\\Student\\Backups\\"
                + textBoxLog.Text + ".bak';", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Резервная копия журнала транзакций создана!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnFullRes_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("USE [master] ALTER DATABASE [UCHET] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ; RESTORE DATABASE [UCHET] FROM DISK = 'C:\\Student\\Backups\\"
                + textBoxFullRes.Text + ".bak' WITH REPLACE,RECOVERY;" +
                "ALTER DATABASE[UCHET] SET MULTI_USER;", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Восстановление из полного бэкапа успешно завершен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            con.Close();
        }

        private void btnDiffRes_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("USE [master] " +
             "ALTER DATABASE [UCHET] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [UCHET] FROM DISK = N'C:\\Student\\Backups\\" + textBoxFullRes.Text + ".bak' WITH FILE = 1, NORECOVERY, NOUNLOAD, REPLACE, STATS = 5; " +
             "RESTORE DATABASE [UCHET] FROM DISK = N'C:\\Student\\Backups\\" + textBoxDiffRes.Text + ".bak' WITH FILE = 1, REPLACE, RECOVERY, NOUNLOAD, STATS = 5; " +
             "ALTER DATABASE [UCHET] SET MULTI_USER;", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Восстановление из дифференциального бэкапа успешно завершен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            con.Close();
        }

        private void btnLogRes_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("USE [master] ALTER DATABASE [UCHET] SET SINGLE_USER WITH ROLLBACK IMMEDIATE  RESTORE DATABASE [UCHET] FROM  DISK =  N'C:\\Student\\Backups\\"
                + textBoxFullRes.Text + ".bak' WITH  FILE = 1,  NORECOVERY,  NOUNLOAD,  REPLACE,  STATS = 5 RESTORE DATABASE [UCHET] FROM  DISK = N'C:\\Student\\Backups\\"
                + textBoxDiffRes.Text + ".bak' WITH  FILE = 1, NORECOVERY, NOUNLOAD, STATS = 5 RESTORE LOG [UCHET] FROM  DISK = N'C:\\Student\\Backups\\"
                + textBoxLogRes.Text + ".bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5 ALTER DATABASE [UCHET] SET MULTI_USER", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Восстановление из журнала транзакций успешно завершен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            con.Close();
        }

        private void btnCrKey_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("use master create master key encryption by password = '" + textBoxPassEnc.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Выполнение команд успешно завершено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDelKey_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DROP MASTER KEY ", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Выполнение команд успешно завершено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnCrCer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("use master create certificate " + textBoxCert.Text + " with subject = 'mybackup'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Выполнение команд успешно завершено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDelCer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DROP CERTIFICATE " + textBoxCert.Text + "", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Выполнение команд успешно завершено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnCrKeyCer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("use master backup certificate " + textBoxCert.Text + " to file = 'C:\\KeyCer\\" + textBoxCert.Text + ".cer' with private key ( file = 'C:\\KeyCer\\" + textBoxPassEnc.Text + ".pvk', encryption by password = '" + textBoxKeyCer.Text + "' ) ", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Резервная копирование мастер-ключа и сертификата создана.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnNewCert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("use master create certificate " + textBoxNewCert.Text + " from file = 'C:\\KeyCer\\" + textBoxCert.Text + ".cer' with private key (file = 'C:\\KeyCer\\" + textBoxKeyCer.Text + ".pvk', decryption by password = '" + textBoxPassEnc.Text + "')", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Сертификат успешно восстановлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnEncDB_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BACKUP DATABASE [UCHET] TO DISK = N'C:\\database\\" + textBoxName_encDB.Text + ".bak' WITH COMPRESSION, ENCRYPTION ( ALGORITHM = AES_256, SERVER CERTIFICATE = " + textBoxCert.Text + "), STATS = 10 ", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Резервную копирование БД с использованием алгоритма шифрования AEC_256 создана.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnResEncDB_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("USE [master]\r\nALTER DATABASE [UCHET] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [UCHET] FROM  DISK = N'C:\\database\\" + textBoxName_encDB.Text + ".bak' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5 ALTER DATABASE [UCHET] SET MULTI_USER;", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("База данных успешно восстановлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}

    