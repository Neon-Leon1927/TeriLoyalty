using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeriLoyalty
{
    public static class DataBase
    {
        public static SqlConnection conn;

        public static void OpenConnection()
        {
            conn = new SqlConnection
            {
                ConnectionString = "Server=GK216_11\\SQLEXPRESS;Database=teri"
            };
            conn.Open();
        }
        public static void CloseConnection()
        {
            conn.Close();
        }
        public static void RunSQL(String Text)
        {
            SqlCommand command = new SqlCommand(Text, conn);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
