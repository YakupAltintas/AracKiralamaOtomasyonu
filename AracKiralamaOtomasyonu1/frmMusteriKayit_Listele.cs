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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        FormOperations formO = new FormOperations();
        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear() 
        {
            mskTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            mskTelefon.Clear();
            cmbCinsiyet.Items.Clear();
            txtMail.Clear();
            cmbEhliyetSinifi.Items.Clear();
            mskEhliyetNo.Clear();
            richAdres.Clear();
        }

        private void frmMusteriKayit_Listele_Load(object sender, EventArgs e)
        {
            formO.DatagridDoldur(DataGridView1, "SP_MusteriListele");
            this.DataGridView1.Columns[0].Visible = false;
            this.DataGridView1.Columns[9].Visible = false;
        }

        private void btnMusteriEkleKaydet_Click_1(object sender, EventArgs e)
        {
            if (mskTC.Text == String.Empty || txtAd.Text == String.Empty || txtSoyad.Text == String.Empty || cmbCinsiyet.Text == String.Empty || dtDogum.Text == String.Empty || mskTelefon.Text == String.Empty
                || txtMail.Text == String.Empty || cmbEhliyetSinifi.Text == String.Empty || mskEhliyetNo.Text == String.Empty || dtEhliyetTarihi.Text == String.Empty || richAdres.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılmaz!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!formO.VeriVarMi("SP_MusteriKontrol", "@TC", mskTC.Text))
            {
                formO.MusteriEkle("SP_MusteriYeniden", mskTC, txtAd, txtSoyad, mskTelefon, richAdres, txtMail, cmbCinsiyet, dtDogum, mskEhliyetNo, cmbEhliyetSinifi, dtEhliyetTarihi);
                formO.DatagridDoldur(DataGridView1, "SP_MusteriListele");
                this.DataGridView1.Columns[0].Visible = false;
                this.DataGridView1.Columns[9].Visible = false;
                MessageBox.Show("Kayıt Kaydedildi!");
                Clear();
            }
            else if (formO.VeriVarMi("SP_MusteriTcVarmi", "@TC", mskTC.Text))
            {
                formO.MusteriEkle("SP_MusteriEkle", mskTC, txtAd, txtSoyad, mskTelefon, richAdres, txtMail, cmbCinsiyet, dtDogum, mskEhliyetNo, cmbEhliyetSinifi, dtEhliyetTarihi);
                formO.DatagridDoldur(DataGridView1, "SP_MusteriListele");
                this.DataGridView1.Columns[0].Visible = false;
                this.DataGridView1.Columns[9].Visible = false;
                MessageBox.Show("Kayıt Eklendi!");
                Clear();
            }
            else
            {
                MessageBox.Show("Aynı Kayıt  Mevcut!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();

            }
        }

        int MusteriID;
        private void btnMusteriEkleDuzenle_Click_1(object sender, EventArgs e)
        {
            
            formO.MusteriUpdate("SP_MusteriGuncelle", mskTC, txtAd, txtSoyad, mskTelefon, richAdres, txtMail, cmbCinsiyet, dtDogum, mskEhliyetNo, cmbEhliyetSinifi, dtEhliyetTarihi, MusteriID);
            formO.DatagridDoldur(DataGridView1, "SP_MusteriListele");
            MessageBox.Show("Musteri Güncellendi!!");
            
        }

        private void cmbEhliyetSinifi_Click(object sender, EventArgs e)
        {
            cmbEhliyetSinifi.Items.Clear();
            formO.ComboboxFill("SP_EhliyetSinifiListele",cmbEhliyetSinifi,"EhliyetSinifi");
        }

        private void btnMusteriEkleCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MusteriID = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value);
            mskTC.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            mskTelefon.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            richAdres.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbCinsiyet.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            dtDogum.Value = Convert.ToDateTime(DataGridView1.CurrentRow.Cells[8].Value);
            cmbEhliyetSinifi.Text = DataGridView1.CurrentRow.Cells[10].Value.ToString();
            mskEhliyetNo.Text = DataGridView1.CurrentRow.Cells[11].Value.ToString();
            dtEhliyetTarihi.Value = Convert.ToDateTime(DataGridView1.CurrentRow.Cells[12].Value);
        }

     

        private void cmbEhliyetSinifi_Click_1(object sender, EventArgs e)
        {
            cmbEhliyetSinifi.Items.Clear();
            formO.ComboboxFill("SP_EhliyetSinifiListele", cmbEhliyetSinifi,"EhliyetSinifi");
        }

        

        private void mskTCAra_TextChanged_1(object sender, EventArgs e)
        {
            formO.Arama("SP_MusteriListeleLike", DataGridView1, "@TC", mskTCAra.Text);
        }

        private void btnMusteriEkleSil_Click_1(object sender, EventArgs e)
        {
            formO.Sil("SP_MusteriSil", "@MusteriID", MusteriID);
            formO.DatagridDoldur(DataGridView1, "SP_MusteriListele");
            MessageBox.Show("Musteri Bilgileri Silindi!!");
        }
    }
}
