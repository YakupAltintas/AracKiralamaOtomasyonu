
namespace AracKiralamaOtomasyonu1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKapa = new System.Windows.Forms.Label();
            this.lblPersonelHesap = new System.Windows.Forms.Label();
            this.lblOdemeRapor = new System.Windows.Forms.Label();
            this.lblOdaKayit = new System.Windows.Forms.Label();
            this.araMainPanel = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Button();
            this.btnPersonelHesap = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnOdaKayit = new System.Windows.Forms.Button();
            this.btnOgrKayit = new System.Windows.Forms.Button();
            this.lblOgrKayit = new System.Windows.Forms.Label();
            this.kasaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracDetayEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDurumRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Aracİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçTeslimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKayıtListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıHesaplarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mainAraPanel = new System.Windows.Forms.Panel();
            this.mainPanelGovde = new System.Windows.Forms.Panel();
            this.araMainPanel.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKapa
            // 
            this.lblKapa.AutoSize = true;
            this.lblKapa.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapa.Location = new System.Drawing.Point(810, 88);
            this.lblKapa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKapa.Name = "lblKapa";
            this.lblKapa.Size = new System.Drawing.Size(55, 20);
            this.lblKapa.TabIndex = 11;
            this.lblKapa.Text = "Kapat";
            // 
            // lblPersonelHesap
            // 
            this.lblPersonelHesap.AutoSize = true;
            this.lblPersonelHesap.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonelHesap.Location = new System.Drawing.Point(595, 90);
            this.lblPersonelHesap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonelHesap.Name = "lblPersonelHesap";
            this.lblPersonelHesap.Size = new System.Drawing.Size(125, 20);
            this.lblPersonelHesap.TabIndex = 9;
            this.lblPersonelHesap.Text = "Personel Hesap";
            // 
            // lblOdemeRapor
            // 
            this.lblOdemeRapor.AutoSize = true;
            this.lblOdemeRapor.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdemeRapor.Location = new System.Drawing.Point(418, 90);
            this.lblOdemeRapor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeRapor.Name = "lblOdemeRapor";
            this.lblOdemeRapor.Size = new System.Drawing.Size(111, 20);
            this.lblOdemeRapor.TabIndex = 7;
            this.lblOdemeRapor.Text = "Teslim Rapor";
            // 
            // lblOdaKayit
            // 
            this.lblOdaKayit.AutoSize = true;
            this.lblOdaKayit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaKayit.Location = new System.Drawing.Point(210, 90);
            this.lblOdaKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaKayit.Name = "lblOdaKayit";
            this.lblOdaKayit.Size = new System.Drawing.Size(157, 20);
            this.lblOdaKayit.TabIndex = 5;
            this.lblOdaKayit.Text = "Araç Kayıt && Listele";
            // 
            // araMainPanel
            // 
            this.araMainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.araMainPanel.Controls.Add(this.lblKapat);
            this.araMainPanel.Controls.Add(this.lblKapa);
            this.araMainPanel.Controls.Add(this.btnPersonelHesap);
            this.araMainPanel.Controls.Add(this.lblPersonelHesap);
            this.araMainPanel.Controls.Add(this.btnOdeme);
            this.araMainPanel.Controls.Add(this.lblOdemeRapor);
            this.araMainPanel.Controls.Add(this.btnOdaKayit);
            this.araMainPanel.Controls.Add(this.lblOdaKayit);
            this.araMainPanel.Controls.Add(this.btnOgrKayit);
            this.araMainPanel.Controls.Add(this.lblOgrKayit);
            this.araMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.araMainPanel.Location = new System.Drawing.Point(0, 129);
            this.araMainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.araMainPanel.Name = "araMainPanel";
            this.araMainPanel.Size = new System.Drawing.Size(1344, 114);
            this.araMainPanel.TabIndex = 9;
            // 
            // lblKapat
            // 
            this.lblKapat.BackColor = System.Drawing.Color.Azure;
            this.lblKapat.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources.icons8_logout_64;
            this.lblKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lblKapat.ImageKey = "(none)";
            this.lblKapat.Location = new System.Drawing.Point(778, 4);
            this.lblKapat.Margin = new System.Windows.Forms.Padding(4);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(123, 80);
            this.lblKapat.TabIndex = 10;
            this.lblKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblKapat.UseVisualStyleBackColor = false;
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // btnPersonelHesap
            // 
            this.btnPersonelHesap.BackColor = System.Drawing.Color.Azure;
            this.btnPersonelHesap.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources.icons8_user_account_64;
            this.btnPersonelHesap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPersonelHesap.ImageKey = "(none)";
            this.btnPersonelHesap.Location = new System.Drawing.Point(594, 4);
            this.btnPersonelHesap.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelHesap.Name = "btnPersonelHesap";
            this.btnPersonelHesap.Size = new System.Drawing.Size(123, 80);
            this.btnPersonelHesap.TabIndex = 8;
            this.btnPersonelHesap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelHesap.UseVisualStyleBackColor = false;
            this.btnPersonelHesap.Click += new System.EventHandler(this.btnPersonelHesap_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.Azure;
            this.btnOdeme.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources.icons8_align_right_641;
            this.btnOdeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOdeme.ImageKey = "(none)";
            this.btnOdeme.Location = new System.Drawing.Point(410, 4);
            this.btnOdeme.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(123, 80);
            this.btnOdeme.TabIndex = 6;
            this.btnOdeme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnOdaKayit
            // 
            this.btnOdaKayit.BackColor = System.Drawing.Color.Azure;
            this.btnOdaKayit.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources.icons8_sedan_64;
            this.btnOdaKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOdaKayit.ImageKey = "(none)";
            this.btnOdaKayit.Location = new System.Drawing.Point(226, 4);
            this.btnOdaKayit.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaKayit.Name = "btnOdaKayit";
            this.btnOdaKayit.Size = new System.Drawing.Size(123, 80);
            this.btnOdaKayit.TabIndex = 4;
            this.btnOdaKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdaKayit.UseVisualStyleBackColor = false;
            this.btnOdaKayit.Click += new System.EventHandler(this.btnOdaKayit_Click);
            // 
            // btnOgrKayit
            // 
            this.btnOgrKayit.BackColor = System.Drawing.Color.Azure;
            this.btnOgrKayit.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources.icons8_save_64;
            this.btnOgrKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOgrKayit.ImageKey = "(none)";
            this.btnOgrKayit.Location = new System.Drawing.Point(42, 4);
            this.btnOgrKayit.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrKayit.Name = "btnOgrKayit";
            this.btnOgrKayit.Size = new System.Drawing.Size(123, 80);
            this.btnOgrKayit.TabIndex = 2;
            this.btnOgrKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrKayit.UseVisualStyleBackColor = false;
            this.btnOgrKayit.Click += new System.EventHandler(this.btnOgrKayit_Click);
            // 
            // lblOgrKayit
            // 
            this.lblOgrKayit.AutoSize = true;
            this.lblOgrKayit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrKayit.Location = new System.Drawing.Point(13, 90);
            this.lblOgrKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrKayit.Name = "lblOgrKayit";
            this.lblOgrKayit.Size = new System.Drawing.Size(181, 20);
            this.lblOgrKayit.TabIndex = 3;
            this.lblOgrKayit.Text = "Müşteri Kayıt && Listele";
            // 
            // kasaİşlemleriToolStripMenuItem
            // 
            this.kasaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiralamaRaporToolStripMenuItem});
            this.kasaİşlemleriToolStripMenuItem.Name = "kasaİşlemleriToolStripMenuItem";
            this.kasaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(179, 33);
            this.kasaİşlemleriToolStripMenuItem.Text = "Kasa İşlemleri";
            // 
            // kiralamaRaporToolStripMenuItem
            // 
            this.kiralamaRaporToolStripMenuItem.Name = "kiralamaRaporToolStripMenuItem";
            this.kiralamaRaporToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kiralamaRaporToolStripMenuItem.Text = "Kiralama Rapor";
            // 
            // aracDetayEkleToolStripMenuItem
            // 
            this.aracDetayEkleToolStripMenuItem.Name = "aracDetayEkleToolStripMenuItem";
            this.aracDetayEkleToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.aracDetayEkleToolStripMenuItem.Text = "Arac Özellik Tanımlama";
            this.aracDetayEkleToolStripMenuItem.Click += new System.EventHandler(this.aracDetayEkleToolStripMenuItem_Click);
            // 
            // odaDurumRaporuToolStripMenuItem
            // 
            this.odaDurumRaporuToolStripMenuItem.Name = "odaDurumRaporuToolStripMenuItem";
            this.odaDurumRaporuToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.odaDurumRaporuToolStripMenuItem.Text = "Araç Durum Rapor";
            this.odaDurumRaporuToolStripMenuItem.Click += new System.EventHandler(this.odaDurumRaporuToolStripMenuItem_Click);
            // 
            // araçKiralamaToolStripMenuItem
            // 
            this.araçKiralamaToolStripMenuItem.Name = "araçKiralamaToolStripMenuItem";
            this.araçKiralamaToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.araçKiralamaToolStripMenuItem.Text = "Araç Kiralama";
            this.araçKiralamaToolStripMenuItem.Click += new System.EventHandler(this.araçKiralamaToolStripMenuItem_Click);
            // 
            // odaKayıtToolStripMenuItem
            // 
            this.odaKayıtToolStripMenuItem.Name = "odaKayıtToolStripMenuItem";
            this.odaKayıtToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.odaKayıtToolStripMenuItem.Text = "Araç Kayıt && Liste";
            this.odaKayıtToolStripMenuItem.Click += new System.EventHandler(this.odaKayıtToolStripMenuItem_Click);
            // 
            // Aracİslemleri
            // 
            this.Aracİslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçKayıtToolStripMenuItem,
            this.odaKayıtToolStripMenuItem,
            this.araçKiralamaToolStripMenuItem,
            this.odaDurumRaporuToolStripMenuItem,
            this.aracDetayEkleToolStripMenuItem,
            this.araçTeslimToolStripMenuItem});
            this.Aracİslemleri.Name = "Aracİslemleri";
            this.Aracİslemleri.Size = new System.Drawing.Size(177, 33);
            this.Aracİslemleri.Text = "Araç İşlemleri";
            this.Aracİslemleri.Click += new System.EventHandler(this.Aracİslemleri_Click);
            // 
            // araçKayıtToolStripMenuItem
            // 
            this.araçKayıtToolStripMenuItem.Name = "araçKayıtToolStripMenuItem";
            this.araçKayıtToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.araçKayıtToolStripMenuItem.Text = "Araç Kayıt";
            this.araçKayıtToolStripMenuItem.Click += new System.EventHandler(this.araçKayıtToolStripMenuItem_Click);
            // 
            // araçTeslimToolStripMenuItem
            // 
            this.araçTeslimToolStripMenuItem.Name = "araçTeslimToolStripMenuItem";
            this.araçTeslimToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.araçTeslimToolStripMenuItem.Text = "Araç Teslim";
            this.araçTeslimToolStripMenuItem.Click += new System.EventHandler(this.araçTeslimToolStripMenuItem_Click);
            // 
            // personelHesapToolStripMenuItem
            // 
            this.personelHesapToolStripMenuItem.Name = "personelHesapToolStripMenuItem";
            this.personelHesapToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.personelHesapToolStripMenuItem.Text = "Personel Hesap";
            this.personelHesapToolStripMenuItem.Click += new System.EventHandler(this.personelHesapToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelHesapToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(221, 33);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // öToolStripMenuItem
            // 
            this.öToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriKayıtListeleToolStripMenuItem});
            this.öToolStripMenuItem.Name = "öToolStripMenuItem";
            this.öToolStripMenuItem.Size = new System.Drawing.Size(211, 33);
            this.öToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriKayıtListeleToolStripMenuItem
            // 
            this.müşteriKayıtListeleToolStripMenuItem.Name = "müşteriKayıtListeleToolStripMenuItem";
            this.müşteriKayıtListeleToolStripMenuItem.Size = new System.Drawing.Size(339, 34);
            this.müşteriKayıtListeleToolStripMenuItem.Text = "Müşteri Kayıt Düzenle";
            this.müşteriKayıtListeleToolStripMenuItem.Click += new System.EventHandler(this.müşteriKayıtListeleToolStripMenuItem_Click);
            // 
            // kullanıcıHesaplarıToolStripMenuItem
            // 
            this.kullanıcıHesaplarıToolStripMenuItem.Name = "kullanıcıHesaplarıToolStripMenuItem";
            this.kullanıcıHesaplarıToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.kullanıcıHesaplarıToolStripMenuItem.Text = "Kullanıcı hesapları";
            this.kullanıcıHesaplarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıHesaplarıToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıHesaplarıToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
            this.systemToolStripMenuItem.Text = "Sistem";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightGray;
            this.menuStripMain.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.öToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.Aracİslemleri,
            this.kasaİşlemleriToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1344, 37);
            this.menuStripMain.TabIndex = 7;
            this.menuStripMain.Text = "Ana Menü";
            // 
            // mainAraPanel
            // 
            this.mainAraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainAraPanel.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources._4;
            this.mainAraPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainAraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainAraPanel.Location = new System.Drawing.Point(0, 37);
            this.mainAraPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainAraPanel.Name = "mainAraPanel";
            this.mainAraPanel.Size = new System.Drawing.Size(1344, 92);
            this.mainAraPanel.TabIndex = 8;
            // 
            // mainPanelGovde
            // 
            this.mainPanelGovde.BackColor = System.Drawing.Color.CadetBlue;
            this.mainPanelGovde.BackgroundImage = global::AracKiralamaOtomasyonu1.Properties.Resources._4;
            this.mainPanelGovde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanelGovde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelGovde.Location = new System.Drawing.Point(0, 0);
            this.mainPanelGovde.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanelGovde.Name = "mainPanelGovde";
            this.mainPanelGovde.Size = new System.Drawing.Size(1344, 682);
            this.mainPanelGovde.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 682);
            this.Controls.Add(this.araMainPanel);
            this.Controls.Add(this.mainAraPanel);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.mainPanelGovde);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.araMainPanel.ResumeLayout(false);
            this.araMainPanel.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lblKapat;
        private System.Windows.Forms.Label lblKapa;
        private System.Windows.Forms.Button btnPersonelHesap;
        private System.Windows.Forms.Label lblPersonelHesap;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Label lblOdemeRapor;
        private System.Windows.Forms.Button btnOdaKayit;
        private System.Windows.Forms.Label lblOdaKayit;
        private System.Windows.Forms.Panel araMainPanel;
        private System.Windows.Forms.Button btnOgrKayit;
        private System.Windows.Forms.Label lblOgrKayit;
        private System.Windows.Forms.Panel mainAraPanel;
        private System.Windows.Forms.ToolStripMenuItem kasaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracDetayEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDurumRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Aracİslemleri;
        private System.Windows.Forms.ToolStripMenuItem personelHesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıHesaplarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.Panel mainPanelGovde;
        private System.Windows.Forms.ToolStripMenuItem araçKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKayıtListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçTeslimToolStripMenuItem;
    }
}