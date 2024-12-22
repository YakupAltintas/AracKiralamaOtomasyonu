using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmLogin : Form
    {
        static SqlConnection con = SQLConnection.ConnectionControl();
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static SqlCommand cmd;
        static DataSet ds;
        public frmLogin()
        {
            InitializeComponent();
        }
        Logincontrol LoginControl = new Logincontrol();
        private void button1_Click(object sender, EventArgs e)
        {

            Giris();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Giris()
        {

            try
            {
                if (Logincontrol.LoginKontrol(tbxKullaniciAdi.Text, tbxSifre.Text))
                {
                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");

                    tbxKullaniciAdi.Clear();
                    tbxSifre.Clear();
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message.ToString());
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
