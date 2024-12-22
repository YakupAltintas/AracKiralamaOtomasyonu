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
    public partial class frmPersonelHesap : Form
    {
        FormOperations formO = new FormOperations();
        public frmPersonelHesap()
        {
            InitializeComponent();
        }
        int EhliyetID=0;
        int TarihID=0;

        public void Temizle()
        {
            mskTC.Clear();
            txtPersonelAdi.Clear();
            txtPersonelSoyad.Clear();
            mskTel.Clear();
        }
        public void dtgList()
        {
            formO.DatagridDoldur(dataGridView1, "SP_PersonelListele");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
             if (mskTC.Text.Length < 11 || mskTC.Text.Length < 11)
            {
                MessageBox.Show("TC 11 Haneden Küçük olamaz");
                Temizle();
            }
            else if (formO.VeriVarMi("SP_PersonelVarmi","@TC",mskTC.Text))
            {
                formO.PersonelEkle("SP_PersonelEkle", mskTC, txtPersonelAdi, txtPersonelSoyad, mskTel, txtPersonelMail, dateTimePicker1, cmbEhliyetTürü, richPersonelAdres, dateGirisTarih);
                MessageBox.Show("Personel Eklendi!!");
                Temizle();
                cmbEhliyetTürü.Items.Clear();
                dtgList();
            }
            else
            {
                MessageBox.Show("Aynı Kayıt  Mevcut!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();

            }
            dtgList();
        }

        private void frmPersonelHesap_Load(object sender, EventArgs e)
        {
           
            formO.ComboboxFill("SP_EhliyetSinifiListele",cmbEhliyetTürü,"EhliyetSinifi");
            dtgList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (mskTC.Text.Length < 11 || mskTC.Text.Length < 11)
            {
                MessageBox.Show("TC 11 Haneden Küçük olamaz");
                Temizle();
            }
            else if (formO.VeriVarMi("SP_PersonelKontrol", "@TC", mskTC.Text))
            {
                formO.PersonelGüncellee("SP_PersonelGuncelle", mskTC, txtPersonelAdi, txtPersonelSoyad, mskTel, txtPersonelMail, dateTimePicker1, cmbEhliyetTürü, richPersonelAdres, dateGirisTarih, dateTimePicker1);
                Temizle();
                cmbEhliyetTürü.Items.Clear();
                formO.DatagridDoldur(dataGridView1, "SP_PersonelListele");
            }
            else if (formO.VeriVarMi("SP_PersonelVarmi", "@TC", mskTC.Text))
            {
                formO.PersonelGüncellee("SP_PersonelGuncelle", mskTC, txtPersonelAdi, txtPersonelSoyad, mskTel, txtPersonelMail, dateTimePicker1, cmbEhliyetTürü, richPersonelAdres, dateGirisTarih, dateTimePicker1);
                Temizle();
                cmbEhliyetTürü.Items.Clear();
                formO.DatagridDoldur(dataGridView1, "SP_PersonelListele");
            }
            else
            {
                MessageBox.Show("Aynı Kayıt  Mevcut!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();

            }
            dtgList();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TarihID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[13].Value);
            EhliyetID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
            PersoneID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            mskTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPersonelAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPersonelSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mskTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime( dataGridView1.CurrentRow.Cells[5].Value.ToString());
            richPersonelAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPersonelMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbEhliyetTürü.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dateGirisTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            dateTimePicker3.Value = Convert.ToDateTime( dataGridView1.CurrentRow.Cells[11].Value.ToString());

        }
        int PersoneID;
        private void btnSil_Click(object sender, EventArgs e)
        {
            formO.Sil("SP_PersonelSil", "@PersoneID", PersoneID);
            MessageBox.Show("Personel Silindi!!");
            dtgList();
        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
