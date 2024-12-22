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
    public partial class frmMusteriSec : Form
    {
        public int MusteriID = 0;
        public string tc;
        public string ad;
        public string soyad;
        public string telefon;
        public string email;
        public string cinsiyet;
        public string dogum;
        public string ehliyetSinifi;
        public string ehliyetNo;
        public string ehliyetTarihi;
        public string adres;
        FormOperations formO = new FormOperations();
        
        public frmMusteriSec()
        {
            InitializeComponent();
        }

        private void frmMusteriSec_Load(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_MusteriListele");
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            telefon = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            email = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cinsiyet = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dogum = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ehliyetSinifi = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ehliyetNo = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            ehliyetTarihi = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
          
            
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    

        private void btnSec_Click(object sender, EventArgs e)
        {

            if (MusteriID == 0)
            {

            }
            else
            {
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }


    }
}
