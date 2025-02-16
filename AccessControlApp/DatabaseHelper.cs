using System;
using System.Data;
using System.Data.SqlClient;

namespace AccessControlApp
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "WIN-T5MH0DHUEL9;Initial Catalog=UCHET;Integrated Security=True";

        // Метод для выполнения команд, которые не возвращают данные (INSERT, UPDATE, DELETE)
        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Метод для получения данных (SELECT)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
    }
}
