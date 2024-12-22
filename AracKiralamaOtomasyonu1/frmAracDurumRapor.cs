using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmAracDurumRapor : Form
    {
        public frmAracDurumRapor()
        {
            InitializeComponent();
        }
        FormOperations formO = new FormOperations();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAracDurumRapor_Load(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_AracDurumRapor");
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtPlaka.Text)))
            {
                formO.Arama("SP_AracDurumRaporPlakaLİKE", dataGridView1, "@Plaka", txtPlaka.Text);
            }
            else
            {
                formO.DatagridDoldur(dataGridView1, "SP_AracDurumRapor");
            }
        }

   
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcelGonder_Click(object sender, EventArgs e)
        {
            csExceleGonder excel = new csExceleGonder();
            excel.Excel(dataGridView1);
        }
    }
}
