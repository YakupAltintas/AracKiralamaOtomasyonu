using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;



namespace AracKiralamaOtomasyonu1
{
    public partial class frmKiralama : Form
    {
        public frmKiralama()
        {
            InitializeComponent();
        }
        FormOperations formO = new FormOperations();
       
        public int MusteriID=0;
        public int AracBilgiID=0;
        int Fiyat=0;
        private void frmKiralama_Load(object sender, EventArgs e)
        {
            
            formO.DatagridDoldur(dataGridView1, "SP_AracKiraRapor");
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
            this.dataGridView1.Columns[15].Visible = false;
            this.dataGridView1.Columns[16].Visible = false;
            this.dataGridView1.Columns[17].Visible = false;
        }
        public void Listeleme()
        {
            AracBilgiID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[17].Value);
            lblVites.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblAracTipi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lblModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblPlaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblRenk.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblYakit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            lblEhliyetSnf.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            lblgunlukKira.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            lblHaftalikKira.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            lblAylikKira.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            lblYillik.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            lblSehirDisiGünlük.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            lblSehirDisiHaftalıkKira.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            lblSehirDısıAylikKira.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            lblSehirdisiYillikKira.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
           

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Listeleme();
            formO.ResimY(pictureBox1, dataGridView1, 16);
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            formO.Arama("SP_AracDurumRaporPlakaLİKE",dataGridView1,"@Plaka",txtPlaka.Text);
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            DateTime bugunTarihi = dtAlis.Value;
            DateTime sinavTarihi = dtTeslim.Value;
            TimeSpan ts = sinavTarihi - bugunTarihi;
            ts.Days.ToString();
            
             if (ts.Days < 7 && cmbKiraTur.SelectedIndex == 0)//günlükiç8
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value)* ts.Days;
            }
            else if (ts.Days < 30 && cmbKiraTur.SelectedIndex == 0)//haftalikiç
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value) * ts.Days/7;
            }
            else if (ts.Days <365  && cmbKiraTur.SelectedIndex == 0)//aylikiç
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value) * ts.Days / 30;
            }
            else if (ts.Days > 365 && cmbKiraTur.SelectedIndex == 0)//yillikiç
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value) * ts.Days / 365;
            }
            else if (ts.Days < 7 && cmbKiraTur.SelectedIndex == 1)
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value) * ts.Days ;
            }
            else if (ts.Days < 30 && cmbKiraTur.SelectedIndex == 1)
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[13].Value) * ts.Days / 7;
            }
            else if (ts.Days < 365 && cmbKiraTur.SelectedIndex == 1)
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[14].Value) * ts.Days / 30;
            }
            else if (ts.Days > 365 && cmbKiraTur.SelectedIndex == 1)
            {
                Fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[15].Value) * ts.Days / 365;
            }

            formO.KiraEkle("SP_Kirala",AracBilgiID,MusteriID,dtAlis,dtTeslim,Fiyat);
            formO.DatagridDoldur(dataGridView1, "SP_AracKiraRapor");
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
            this.dataGridView1.Columns[15].Visible = false;
            this.dataGridView1.Columns[16].Visible = false;
            this.dataGridView1.Columns[17].Visible = false;
            MessageBox.Show("Kiralama Başarılı!");


        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriSec_Click(object sender, EventArgs e)
        {
            frmMusteriSec musteriSec = new frmMusteriSec();
            if (musteriSec.ShowDialog() == DialogResult.OK)
            {
                MusteriID = musteriSec.MusteriID;
                lblTC.Text = musteriSec.tc;
                lblAd.Text = musteriSec.ad;
                lblSoyad.Text = musteriSec.soyad;
                lblCinsiyet.Text = musteriSec.cinsiyet;
                lblDogumT.Text = musteriSec.dogum;
                lblTelefon.Text = musteriSec.telefon;
                lblEmail.Text = musteriSec.email;
                lblEhliyetSinifi.Text = musteriSec.ehliyetSinifi;
                lblEhliyetNo.Text = musteriSec.ehliyetNo;
                lblEhliyetTarihi.Text = musteriSec.ehliyetTarihi;
                lblAdres.Text = musteriSec.adres;
            }
            
        }
    }
}
