using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlytinhoc;

namespace quanlytinhoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=QLtinhoc;Integrated Security=True";
            try
            {
                conn.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Application.Run(new frmCoquan());
            
        }
    }

}
