using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    class Logincontrol
    {
         static SqlConnection con = SQLConnection.ConnectionControl();
        KullanicilarProp kullaniciProperties = new KullanicilarProp();
        static SqlDataReader dr;
        static SqlCommand cmd;

        public static bool LoginKontrol(string KullaniciAdi, string Sifre)
        {
            string sorgu = "select * from Kullanicilar where KullaniciAdi=@user and Sifre=@password and Durum=1";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", KullaniciAdi);
            cmd.Parameters.AddWithValue("@password", Sha512Enctriyption.SHA512Enctriyption(Sifre));
            SQLConnection.ConnectionOpen(con);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                SQLConnection.ConnectionClose(con);
                return true;
            }
            else
            {
                SQLConnection.ConnectionClose(con);
                return false;
            }

        }
    }
}
