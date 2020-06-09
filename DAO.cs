using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace quanlytinhoc
{
    class DAO
    {
        public static SqlConnection conn;
        public static string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=QLtinhoc;Integrated Security=True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Closed)
                try
                {
                    conn.Open();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }
        public static void CloseConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    MessageBox.Show("Đóng ket noi thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static bool checkKeyExit(string sql)
        {
            bool kq = false;

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                kq = true;


            return kq;

        }
        public static void FillDataToCombo(string sql, ComboBox combo, string valueField, string DisplayField)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable mytable = new DataTable();
            adapter.Fill(mytable);
            combo.DataSource = mytable;
            combo.ValueMember = valueField;
            combo.DisplayMember = DisplayField;

        }
    }
}
