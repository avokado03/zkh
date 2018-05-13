using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace zkh
{
    public static class Ado
    {
        public static string cs = @"Data Source=HZ-ПК\;Initial Catalog = Kursachek; Integrated Security = True";

        public static void ExecuteNonQuery(string query)
        {
            using (SqlConnection c = new SqlConnection(cs))
            {
                try
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(query, c);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.Close();
                }
            }
        }

        public static DataTable ExecuteReader(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection c = new SqlConnection(cs))
            {
                try
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(query, c);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    c.Close();
                }
            }
        }

        public static int ExecuteReader(string query, int id)
        {
            int tId;
            using (SqlConnection c = new SqlConnection(cs))
            {
                try
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(query, c);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    tId = reader.GetInt32(0);
                    return tId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    c.Close();
                }
            }
        }
    }
}

