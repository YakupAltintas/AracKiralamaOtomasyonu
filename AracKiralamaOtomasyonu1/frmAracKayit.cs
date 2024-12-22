using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmAracKayit : Form
    {
        SqlConnection con = SQLConnection.ConnectionControl();
        FormOperations formO = new FormOperations();
        int ModelID;
        public int AracBilgiID;
        public int SehiriciID;
        public int SehirdisiID;
        public int GorselID;
        public frmAracKayit()
        {
            InitializeComponent();
        }

       

        private void frmAracKayit_Load(object sender, EventArgs e)
        {
            //this.label18 = new System.Windows.Forms.Label();
        }
          
        private void brnResimSec_Click(object sender, EventArgs e)
        {
            formO.ImageSelect(openFileDialog1, picArac);        
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            if (!formO.VeriVarMi("SP_AracKontrol", "@Plaka", txtPlaka.Text) && picArac.Image != null && !String.IsNullOrEmpty(cmbAracTip.Text) && !String.IsNullOrEmpty(cmbRenk.Text) && !String.IsNullOrEmpty(txtPlaka.Text)
                && !String.IsNullOrEmpty(cmbMarka.Text) && !String.IsNullOrEmpty(cmbModel.Text) && !String.IsNullOrEmpty(cmbVites.Text) && !String.IsNullOrEmpty(cmbYakitTur.Text)
                && !String.IsNullOrEmpty(cmbEhliyet.Text) && !String.IsNullOrEmpty(cmbYil.Text) && !String.IsNullOrEmpty(txtKm.Text) && !String.IsNullOrEmpty(txtAracRuhsat.Text)
                && !String.IsNullOrEmpty(txtSGunluk.Text) && !String.IsNullOrEmpty(txtSHaftalik.Text) && !String.IsNullOrEmpty(txtSAylik.Text) && !String.IsNullOrEmpty(txtSYillik.Text)
                && !String.IsNullOrEmpty(txtDGunluk.Text) && !String.IsNullOrEmpty(txtDHaftalik.Text) && !String.IsNullOrEmpty(txtDAylik.Text) && !String.IsNullOrEmpty(txtDYillik.Text))

            {
                int AracBilgiID2 = 0, SehiriciID2 = 0, SehirdisiID2 = 0, GorselID2 = 0;
                formO.AracCek("SP_AracCek", txtPlaka.Text, AracBilgiID, SehiriciID, SehirdisiID, GorselID);
                formO.AracGuncelle(openFileDialog1, picArac, "SP_AracUpdate", txtPlaka, cmbMarka, cmbAracTip, cmbModel, cmbRenk,
                cmbYakitTur, cmbEhliyet, cmbVites, cmbYil, txtAracRuhsat, txtKm, txtSGunluk, txtSHaftalik, txtSAylik, txtSYillik, txtDGunluk,
                txtDHaftalik, txtDAylik, txtDYillik, SehiriciID, GorselID, SehirdisiID, AracBilgiID);
                MessageBox.Show("Kayıt Güncellendi!");
            }
            else if (picArac.Image != null && !String.IsNullOrEmpty(cmbAracTip.Text) && !String.IsNullOrEmpty(cmbRenk.Text) && !String.IsNullOrEmpty(txtPlaka.Text)
                &&!String.IsNullOrEmpty(cmbMarka.Text) && !String.IsNullOrEmpty(cmbModel.Text) &&! String.IsNullOrEmpty(cmbVites.Text) && !String.IsNullOrEmpty(cmbYakitTur.Text)
                &&!String.IsNullOrEmpty(cmbEhliyet.Text)&&! String.IsNullOrEmpty(cmbYil.Text) && !String.IsNullOrEmpty(txtKm.Text) && !String.IsNullOrEmpty(txtAracRuhsat.Text)
                &&!String.IsNullOrEmpty(txtSGunluk.Text)&&! String.IsNullOrEmpty(txtSHaftalik.Text) && !String.IsNullOrEmpty(txtSAylik.Text) &&!String.IsNullOrEmpty(txtSYillik.Text)
                &&!String.IsNullOrEmpty(txtDGunluk.Text)&& !String.IsNullOrEmpty(txtDHaftalik.Text) &&! String.IsNullOrEmpty(txtDAylik.Text) && !String.IsNullOrEmpty(txtDYillik.Text))
            {     
                formO.AracAdd(openFileDialog1, picArac, "SP_AracEkle", txtPlaka, cmbAracTip, cmbModel, cmbRenk,
            cmbYakitTur, cmbEhliyet, cmbVites, cmbYil, txtAracRuhsat, txtKm, txtSGunluk, txtSHaftalik, txtSAylik, txtSYillik, txtDGunluk,
            txtDHaftalik, txtDAylik, txtDYillik);
                MessageBox.Show("Kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }
 
        private void cmbMarka_Click(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            ModelID = formO.Comboboxİndex(cmbMarka);
            formO.ComboboxFill("SP_MarkaListele", cmbMarka, "MarkaAdi");
        }

        private void cmbAracTip_Click(object sender, EventArgs e)
        {
            cmbAracTip.Items.Clear();
            formO.ComboboxFill("SP_AracTipiListele", cmbAracTip,"AracTipi");
        }

        private void cmbVites_Click(object sender, EventArgs e)
        {
            cmbVites.Items.Clear();
            formO.ComboboxFill("SP_VitesListele", cmbVites, "VitesTuru");
        }

        private void cmbRenk_Click(object sender, EventArgs e)
        {
            cmbRenk.Items.Clear();
            formO.ComboboxFill("SP_RenkListele", cmbRenk, "Renk");
        }

        private void cmbYakitTur_Click(object sender, EventArgs e)
        {
            cmbYakitTur.Items.Clear();
            formO.ComboboxFill("SP_YakitTuruListele", cmbYakitTur, "YakitTuru");
        }

        private void cmbEhliyet_Click(object sender, EventArgs e)
        {
            cmbEhliyet.Items.Clear();
            formO.ComboboxFill("SP_EhliyetSinifiListele", cmbEhliyet, "EhliyetSinifi");
        }

        private void cmbYil_Click(object sender, EventArgs e)
        {
            cmbYil.Items.Clear();
            formO.ComboboxFill("SP_YilListele", cmbYil, "Yil");
        }

     

        private void cmbModel_Click(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            formO.ComboboxFill2("SP_ModelListele",cmbModel,cmbMarka,"@MarkaID");
            
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (picArac.Image != null && !String.IsNullOrEmpty(cmbAracTip.Text) && !String.IsNullOrEmpty(cmbRenk.Text) && !String.IsNullOrEmpty(txtPlaka.Text)
               && !String.IsNullOrEmpty(cmbMarka.Text) && !String.IsNullOrEmpty(cmbModel.Text) && !String.IsNullOrEmpty(cmbVites.Text) && !String.IsNullOrEmpty(cmbYakitTur.Text)
               && !String.IsNullOrEmpty(cmbEhliyet.Text) && !String.IsNullOrEmpty(cmbYil.Text) && !String.IsNullOrEmpty(txtKm.Text) && !String.IsNullOrEmpty(txtAracRuhsat.Text)
               && !String.IsNullOrEmpty(txtSGunluk.Text) && !String.IsNullOrEmpty(txtSHaftalik.Text) && !String.IsNullOrEmpty(txtSAylik.Text) && !String.IsNullOrEmpty(txtSYillik.Text)
               && !String.IsNullOrEmpty(txtDGunluk.Text) && !String.IsNullOrEmpty(txtDHaftalik.Text) && !String.IsNullOrEmpty(txtDAylik.Text) && !String.IsNullOrEmpty(txtDYillik.Text))
            {
                formO.AracGuncelle(openFileDialog1, picArac, "SP_AracUpdate", txtPlaka, cmbMarka, cmbAracTip, cmbModel, cmbRenk,
                cmbYakitTur, cmbEhliyet, cmbVites, cmbYil, txtAracRuhsat, txtKm, txtSGunluk, txtSHaftalik, txtSAylik, txtSYillik, txtDGunluk,
                txtDHaftalik, txtDAylik, txtDYillik, SehiriciID, GorselID, SehirdisiID, AracBilgiID);
                MessageBox.Show("Kayıt Güncellendi!");
            }
            else
            {
                MessageBox.Show("Tüm kısımları doldurduğunuzdan emin olun!");
            }
        }

        private void txtDYillik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAracRuhsat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
