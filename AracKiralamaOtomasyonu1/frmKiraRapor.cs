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
    public partial class frmKiraRapor : Form
    {
        public frmKiraRapor()
        {
            InitializeComponent();
        }
        FormOperations formO = new FormOperations();
        csExceleGonder exceleGonder = new csExceleGonder();
        private void button1_Click(object sender, EventArgs e)
        {
            exceleGonder.Excel(dataGridView1);
        }

        private void frmKiraRapor_Load(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_TeslimRapor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskTC_TextChanged(object sender, EventArgs e)
        {
            formO.DatagridDoldur3(dataGridView1, "SP_KiraRaporLike", "@MusteriTC", mskTC.Text);
        }

        private void mskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
