using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmKullaniciHesapalari : Form
    {
        public frmKullaniciHesapalari()
        {
            InitializeComponent();
        }
        FormOperations formOperations = new FormOperations();
    
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmKullaniciHesapalari_Load(object sender, EventArgs e)
        {
            formOperations.DatagridDoldur(dataGridView1, "SP_KullaniciListele");
         
            this.dataGridView1.Columns[3].Visible = false;
        }

   

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (tbxKullaniciAdi.Text == String.Empty || tbxSifre.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılmaz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (formOperations.VeriVarMi("SP_KullaniciAdiVarmi", "KullaniciAdi", tbxKullaniciAdi.Text))
            {


                formOperations.KullaniciEkle("SP_KullaniciEkleme", new KullanicilarProp
                {
                    KullaniciAdi = tbxKullaniciAdi.Text,
                    Sifre = tbxSifre.Text
                });


                formOperations.DatagridDoldur(dataGridView1, "SP_KullaniciListele");
                MessageBox.Show("Kullanıcı Eklendi!!");


            }
            else
            {
                MessageBox.Show("Kullanıcı Mevcut!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


            tbxKullaniciAdi.Clear();
            tbxSifre.Clear();
            formOperations.DatagridDoldur(dataGridView1, "SP_KullaniciListele");
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            formOperations.Delete("SP_KullaniciSilme", "@KullaniciID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Öğrenci Silindi!!");
        }

        private void btnDuzenle_Click_1(object sender, EventArgs e)
        {
            formOperations.KullaniciGüncelle("SP_KullaniciGuncelleme", new KullanicilarProp
            {
                KullaniciID = int.Parse(lblID.Text),
                Sifre = tbxSifre.Text

            });
            formOperations.DatagridDoldur(dataGridView1, "SP_KullaniciListele");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
