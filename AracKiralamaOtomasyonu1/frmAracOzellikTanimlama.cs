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
    public partial class frmAracOzellikTanimlama : Form
    {
        FormOperations formO = new FormOperations();
      
        public frmAracOzellikTanimlama()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            formO.ComboboxFill("SP_MarkaListele", comboBox1,"MarkaAdi");
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_MarkaListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = true;          
            txtMarkaAra.Visible = true;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;
        }

        private void btnAracTipi_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_AracTipiListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = true;
            txtAracTipiAra.Visible = true;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;

        }

        private void btnVites_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_VitesListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = true;
            txtVitesAra.Visible = true;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;
        }

        private void btnYil_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_YilListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = true;
            txtYilAra.Visible = true;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_RenkListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = true;
            txtRenkAra.Visible = true;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;
        }

        private void btnEhliyetSinifi_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_EhliyetSinifiListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = true;
            txtEhliyetSinifiAra.Visible = true;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;
        }

        private void btnYakit_Click(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_YakitTuruListele");
            this.dataGridView1.Columns[0].Visible = false;
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = true;
            txtYakitTuruAra.Visible = true;
            lblModel.Visible = false;
            txtModelAra.Visible = false;
            MarkaIDG = 0;
            ModelIDG = 0;
            AracTipiIDG = 0;
            VitesIDG = 0;
            YilIDG = 0;
            RenkIDG = 0;
            EhliyetIDG = 0;
            YakitIDG = 0;
        }
        
        private void btnModel_Click_1(object sender, EventArgs e)
        {

            if (MarkaID !=0 )
            {
                formO.DatagridDoldur2(dataGridView1, "SP_ModelListele", MarkaID);
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[2].Visible = false;
                lblMarka.Visible = false;
                txtMarkaAra.Visible = false;
                lblAracTipi.Visible = false;
                txtAracTipiAra.Visible = false;
                lblVites.Visible = false;
                txtVitesAra.Visible = false;
                lblYil.Visible = false;
                txtYilAra.Visible = false;
                lblRenk.Visible = false;
                txtRenkAra.Visible = false;
                lblEhliyet.Visible = false;
                txtEhliyetSinifiAra.Visible = false;
                lblYakit.Visible = false;
                txtYakitTuruAra.Visible = false;
                lblModel.Visible = true;
                txtModelAra.Visible = true;
                MarkaIDG = 0;
                ModelIDG = 0;
                AracTipiIDG = 0;
                VitesIDG = 0;
                YilIDG = 0;
                RenkIDG = 0;
                EhliyetIDG = 0;
                YakitIDG = 0;
            }
            else
            {
                MessageBox.Show("Lütfen Marka seçiniz!!");
            }
        }
        int MarkaID = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkaID = comboBox1.SelectedIndex + 1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((formO.VeriVarMi("SP_MarkaListele", "@MarkaAdi", txtMarka.Text)))
            {
                txtMarka.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtMarka.Text)))
                {
                    formO.OzellikEkle1("SP_MarkaEkle", "@Marka",txtMarka);
                    MessageBox.Show("Marka Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_MarkaListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtMarka.Clear();
                }
            }
            else
            {
                MessageBox.Show("Marka Mecut!");
                txtMarka.Clear();
            }
            //----------------------------------------
            if ((formO.VeriVarMi("SP_AracTipiListele", "@AracTipi", txtAracTipi.Text)))
            {
                txtAracTipi.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtAracTipi.Text)))
                {
                    formO.OzellikEkle1("SP_AracTipiEkle", "@AracTipi", txtAracTipi);
                    MessageBox.Show("Araç Tipi Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_AracTipiListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtAracTipi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Araç Tipi  Mecut!");
                txtAracTipi.Clear();
            }
            //------------------------------------
        
            if ((formO.VeriVarMi("SP_VitesListele", "@VitesTuru", txtVites.Text)))
            {
                txtVites.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtVites.Text)))
                {
                    formO.OzellikEkle1("SP_VitesEkle", "@VitesTuru", txtVites);
                    MessageBox.Show("Vites Türü Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_VitesListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtVites.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vites Türü Mecut!");
                txtVites.Clear();
            }
            //----------------------------
            if ((formO.VeriVarMi("SP_YilListele", "@Yil", txtYil.Text)))
            {
                txtYil.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtYil.Text)))
                {
                    formO.OzellikEkle1("SP_YilEkle", "@Yil", txtYil);
                    MessageBox.Show("Yıl  Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_YilListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtYil.Clear();
                }
            }
            else
            {
                MessageBox.Show(" Yıl Mecut!");
                txtYil.Clear();
            }
            //--------------------------------------
            if ((formO.VeriVarMi("SP_RenkListele", "@Renk", txtRenk.Text)))
            {
                txtRenk.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtRenk.Text)))
                {
                    formO.OzellikEkle1("SP_RenkEkle", "@Renk", txtRenk);
                    MessageBox.Show("Renk  Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_RenkListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtRenk.Clear();
                }
            }
            else
            {
                MessageBox.Show(" Renk Mecut!");
                txtRenk.Clear();
            }
            //--------------------------------------
            if ((formO.VeriVarMi("SP_EhliyetSinifiListele", "@EhliyetSinifi", txtEhliyetSinifi.Text)))
            {
                txtEhliyetSinifi.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtEhliyetSinifi.Text)))
                {
                    formO.OzellikEkle1("SP_EhliyetSinifiEkle", "@EhliyetSinifi", txtEhliyetSinifi);
                    MessageBox.Show("Ehliyet Sınıfı  Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_EhliyetSinifiListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtEhliyetSinifi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ehliyet Sınıfı  Mecut!");
                txtEhliyetSinifi.Clear();
            }
            //---------------------------------------------------------------
            if ((formO.VeriVarMi("SP_YakitTuruListele", "@YakitTuru", txtYakit.Text)))
            {
                txtYakit.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtYakit.Text)))
                {
                    formO.OzellikEkle1("SP_YakitTuruEkle", "@YakitTuru", txtYakit);
                    MessageBox.Show("Yakıt Türü  Eklendi!");
                    formO.DatagridDoldur(dataGridView1, "SP_YakitTuruListele");
                    this.dataGridView1.Columns[0].Visible = false;
                    txtYakit.Clear();
                }
            }
            else
            {
                MessageBox.Show("Yakıt Türü Mecut!");
                txtYakit.Clear();
            }
            //----------------------------------------------------------------
            if ((formO.VeriVarMi2("SP_ModelListele", "@Model", txtModel.Text,"@MarkaID",MarkaID)))
            {
                txtModel.Text.TrimEnd();
                if (!(String.IsNullOrEmpty(txtModel.Text)))
                {
                    formO.OzellikEkle2("SP_ModelEkle", "@Model", txtModel,"MarkaID",MarkaID);
                    MessageBox.Show($"{comboBox1.SelectedItem} Markasına Ait Model  Eklendi!");
                    formO.DatagridDoldur2(dataGridView1, "SP_ModelListele", MarkaID);
                    this.dataGridView1.Columns[0].Visible = false;
                    this.dataGridView1.Columns[2].Visible = false;
                    txtModel.Clear();
                }
            }
            else
            {
                MessageBox.Show($"{comboBox1.SelectedItem} Markasına Ait Model Mecut!");
                txtModel.Clear();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAracOzellikTanimlama_Load(object sender, EventArgs e)
        {
            lblMarka.Visible = false;
            txtMarkaAra.Visible = false;
            lblAracTipi.Visible = false;
            txtAracTipiAra.Visible = false;
            lblVites.Visible = false;
            txtVitesAra.Visible = false;
            lblYil.Visible = false;
            txtYilAra.Visible = false;
            lblRenk.Visible = false;
            txtRenkAra.Visible = false;
            lblEhliyet.Visible = false;
            txtEhliyetSinifiAra.Visible = false;
            lblYakit.Visible = false;
            txtYakitTuruAra.Visible = false;
            lblModel.Visible = false;
            txtModelAra.Visible = false;    

        }

        private void txtMarkaAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtMarkaAra.Text)))
            {
                formO.Arama("SP_MarkaAra", dataGridView1, "@MarkaAdi", txtMarkaAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_MarkaListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void txtAracTipiAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtAracTipiAra.Text)))
            {
                formO.Arama("SP_AracTipiAra", dataGridView1, "@AracTipi", txtAracTipiAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_AracTipiListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void txtVitesAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtVitesAra.Text)))
            {
                formO.Arama("SP_VitesAra", dataGridView1, "@VitesTuru", txtVitesAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_VitesListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void txtYilAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtYilAra.Text)))
            {
                formO.Arama("SP_YilAra", dataGridView1, "@Yil", txtYilAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_YilListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void txtRenkAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtRenkAra.Text)))
            {
                formO.Arama("SP_RenkAra", dataGridView1, "@Yil", txtRenkAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_RenkListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

    
        private void txtEhliyetSinifiAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtEhliyetSinifiAra.Text)))
            {
                formO.Arama("SP_EhliyetSinifiAra", dataGridView1, "@EhliyetSinifi", txtEhliyetSinifiAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_EhliyetSinifiListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }
        private void txtYakitTuruAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtYakitTuruAra.Text)))
            {
                formO.Arama("SP_YakitTuruAra", dataGridView1, "@YakitTuru", txtYakitTuruAra.Text);
                this.dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_YakitTuruListele");
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void txtModelAra_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtModelAra.Text)))
            {
                formO.Arama2("SP_ModelAra", dataGridView1, "@Model", txtModelAra.Text, "@MarkaID", MarkaID);
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[2].Visible = false;
            }
            else
            {
                formO.DatagridDoldur2(dataGridView1, "SP_ModelListele", MarkaID);
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[2].Visible = false;
            }
        }

        int MarkaIDG=0;
        int ModelIDG = 0;
        int AracTipiIDG = 0;
        int VitesIDG = 0;
        int YilIDG = 0;
        int RenkIDG = 0;
        int EhliyetIDG = 0;
        int YakitIDG = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[0].HeaderText =="MarkaID")
            {
                MarkaIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dataGridView1.Columns[0].HeaderText == "AracTipiID")
            {
                AracTipiIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtAracTipi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            
            else if (dataGridView1.Columns[0].HeaderText == "VitesID")
            {
                VitesIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtVites.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dataGridView1.Columns[0].HeaderText == "YilID")
            {
                YilIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtYil.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dataGridView1.Columns[0].HeaderText == "RenkID")
            {
                RenkIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtRenk.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dataGridView1.Columns[0].HeaderText == "EhliyetID")
            {
                EhliyetIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtEhliyetSinifi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dataGridView1.Columns[0].HeaderText == "YakitID")
            {
                YakitIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtYakit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dataGridView1.Columns[0].HeaderText == "ModelID")
            {
                ModelIDG = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtModel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

            
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (MarkaIDG != 0 && !(String.IsNullOrEmpty(txtMarka.Text)) && String.IsNullOrEmpty(txtModel.Text))
            {
                formO.Guncelle("SP_MarkaGuncelle", "MarkaAdi", txtMarka.Text, "MarkaID", MarkaIDG);
                MessageBox.Show("Marka Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_MarkaListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtMarka.Clear();
            }
            else if ( AracTipiIDG!= 0 && !(String.IsNullOrEmpty(txtAracTipi.Text)))
            {
                formO.Guncelle("SP_AracTipiGuncelle", "@AracTipi", txtAracTipi.Text, "@AracTipiID", AracTipiIDG);
                MessageBox.Show("Araç Tipi Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_AracTipiListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtAracTipi.Clear();
            }
            else if (VitesIDG != 0 && !(String.IsNullOrEmpty(txtVites.Text)))
            {
                formO.Guncelle("SP_VitesGuncelle", "@VitesTuru", txtVites.Text, "@VitesID", VitesIDG);
                MessageBox.Show("Vites Türü Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_VitesListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtVites.Clear();
            }
            else if (YilIDG != 0 && !(String.IsNullOrEmpty(txtYil.Text)))
            {
                formO.Guncelle("SP_YilGuncelle", "@Yil", txtYil.Text, "@VitesID", YilIDG);
                MessageBox.Show("Yil Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_YilListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtYil.Clear();
            }
            else if (RenkIDG != 0 && !(String.IsNullOrEmpty(txtRenk.Text)))
            {
                formO.Guncelle("SP_RenkGuncelle", "@Renk", txtRenk.Text, "@RenkID", RenkIDG);
                MessageBox.Show("Renk Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_RenkListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtRenk.Clear();
            }
            else if (EhliyetIDG != 0 && !(String.IsNullOrEmpty(txtEhliyetSinifi.Text)))
            {
                formO.Guncelle("SP_EhliyetSinifiGuncelle", "@EhliyetSinifi", txtEhliyetSinifi.Text, "@EhliyetID", EhliyetIDG);
                MessageBox.Show("Ehliyet Sınıfı Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_EhliyetSinifiListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtEhliyetSinifi.Clear();
            }
            else if (YakitIDG != 0 && !(String.IsNullOrEmpty(txtYakit.Text)))
            {
                formO.Guncelle("SP_YakitGuncelle", "@Yakit", txtYakit.Text, "@YakitID", YakitIDG);
                MessageBox.Show("Yakit Güncellendi!");
                formO.DatagridDoldur(dataGridView1, "SP_YakitTuruListele");
                this.dataGridView1.Columns[0].Visible = false;
                txtEhliyetSinifi.Clear();
            }
            else if (ModelIDG != 0 && !(String.IsNullOrEmpty(txtModel.Text)))
            {
                formO.Guncelle2("SP_ModelGuncelle", "@Model", txtModel.Text, "@ModelID", ModelIDG,"@MarkaID", comboBox1.SelectedIndex + 1);
                MessageBox.Show("Model Güncellendi!");
                formO.DatagridDoldur2(dataGridView1, "SP_ModelListele",comboBox1.SelectedIndex+1);
                this.dataGridView1.Columns[0].Visible = false;
                txtEhliyetSinifi.Clear();
            }

        }

    }                                                                 
                                                                       
}                                                                    
                                                                                             