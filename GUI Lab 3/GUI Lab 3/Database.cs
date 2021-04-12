using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI_Lab_3
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=LAPTOP-6R50N3SS\SQLEXPRESS;Database=model;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
