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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void müşteriGenelToplamlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void personelHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelHesap frmPersonelHesap = new frmPersonelHesap();
            frmPersonelHesap.Show();        }

        private void Aracİslemleri_Click(object sender, EventArgs e)
        {

        }

        private void odaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracListele_Kayit frmAracListele_Kayit = new frmAracListele_Kayit();
            frmAracListele_Kayit.Show();
        }

        private void araçKiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKiralama Kiralama = new frmKiralama();

            Kiralama.Show();
        }

        private void odaDurumRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracDurumRapor frmAracDurumRapor = new frmAracDurumRapor();
            frmAracDurumRapor.Show();
        }

        private void aracDetayEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracOzellikTanimlama frmAracOzellikTanimlama = new frmAracOzellikTanimlama();
            frmAracOzellikTanimlama.Show();
        }

        private void kasaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kasaGiderRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOgrKayit_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriKayit_Listele = new frmMusteriEkle();
            frmMusteriKayit_Listele.Show();
        }

        private void btnOdaKayit_Click(object sender, EventArgs e)
        {
            frmAracListele_Kayit frmAracListele_Kayit = new frmAracListele_Kayit();
            frmAracListele_Kayit.Show();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            frmKiraRapor frmKira = new frmKiraRapor();
            frmKira.Show();
        }

        private void btnPersonelHesap_Click(object sender, EventArgs e)
        {
            frmPersonelHesap frmPersonelHesap = new frmPersonelHesap();
            frmPersonelHesap.Show();
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void araçKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracKayit aracKayit = new frmAracKayit();
            aracKayit.Show();
        }

        private void müşteriKayıtListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriKayit_Listele = new frmMusteriEkle();
            frmMusteriKayit_Listele.Show();
        }

        private void araçTeslimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracTeslim aracTeslim = new frmAracTeslim();
            aracTeslim.Show();
        }

        private void kullanıcıHesaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciHesapalari frmKullaniciHesapalari = new frmKullaniciHesapalari();
            frmKullaniciHesapalari.Show();
        }
    }
}
