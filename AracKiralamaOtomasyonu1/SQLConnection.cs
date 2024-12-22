using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace AracKiralamaOtomasyonu1
{
    class SQLConnection
    {
        public static SqlConnection ConnectionControl()
        {
            return new SqlConnection(@"Data Source=DESKTOP-MVKVQ23\SQLEXPRESS;Initial Catalog=AracKiralamaDB;User ID=Sa;Password=123654");
        }
        public static void ConnectionOpen(SqlConnection _con) // 
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }
        public static void ConnectionClose(SqlConnection _con)
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
        }
    }
}
