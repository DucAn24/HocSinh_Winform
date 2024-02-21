using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thucHanh
{
    internal class dbConnection
    {
        
        public void DataConnect(string sqlStr, DataGridView dtg)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dtg.DataSource = data; 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Execute(string sql)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                // Ket noi
                conn.Open();

                string sqlStr = sql;

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(" thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
