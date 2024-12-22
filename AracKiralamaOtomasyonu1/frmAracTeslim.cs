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
    public partial class frmAracTeslim : Form
    {
        FormOperations formO = new FormOperations();
        int MusteriID;
        int AracID;
        int KiraID=0;
        public frmAracTeslim()
        {
            InitializeComponent();
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
            GridkolonGizle();
        }

        private void GridkolonGizle()
        {
            formO.DatagridDoldur3(dataGridView1, "SP_KiraGetir", "@MusteriID", MusteriID.ToString());
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formO.ResimY(pictureBox1,dataGridView1,10);
            lblPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblFiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            lblAlis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            lblTeslim.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            AracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            KiraID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
        }
        private void frmAracTeslim_Load(object sender, EventArgs e)
        {

        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            int km = Convert.ToInt32(txtKM.Text);
            formO.TeslimAl("SP_TelimAl",comboBox1.SelectedIndex+1,KiraID, km, AracID);
            GridkolonGizle();
            MessageBox.Show("Araç Teslim Alındı!");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            formO.ComboboxFill("SP_PersonelListele", comboBox1,"TC");
        }

        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
