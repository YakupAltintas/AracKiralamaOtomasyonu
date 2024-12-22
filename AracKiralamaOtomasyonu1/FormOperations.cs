using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace AracKiralamaOtomasyonu1
{
    class FormOperations
    {
        string imagepath;
        static SqlConnection con = SQLConnection.ConnectionControl();
        static DataSet ds;
        public void ImageSelect(OpenFileDialog _openfolder, PictureBox _arac)
        {
            _openfolder.Title = "Resim Seç";
            _openfolder.Filter = "Jpeg Dosyaları(*.Jpeg)|*.jpeg| Jpg Dosyaları(*.Jpg)|*.jpg| Png Dosyaları(*.png)|*.png||";
            if (_openfolder.ShowDialog() == DialogResult.OK)
            {
                _arac.Image = Image.FromFile(_openfolder.FileName);
                imagepath = _openfolder.FileName;
            }
        }
        public void AracAdd(OpenFileDialog _openfolder, PictureBox _arac,  string _StoredProcedure,
            TextBox txtPlaka, ComboBox cmbAracTipi, ComboBox cmbModel, ComboBox cmbRenk, ComboBox cmbYakitTuru,
            ComboBox cmbEhliyet, ComboBox cmbVites, ComboBox cmbYil, TextBox txtAracRuhsatNo, TextBox txtKm, TextBox txtSGunluk,
             TextBox txtSHaftalik, TextBox txtSAylik, TextBox txtSYillik, TextBox txtDGunluk, TextBox txtDHaftalik,
            TextBox txtDAylik, TextBox txtDYillik)
        {

            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] gorsel = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Plaka",txtPlaka.Text);
            cmd.Parameters.AddWithValue("@AracTipi", cmbAracTipi.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@Model", cmbModel.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@Renk", cmbRenk.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@Vites", cmbVites.SelectedIndex + 1);
            cmd.Parameters.Add("@Gorsel", SqlDbType.Image, gorsel.Length).Value = gorsel;
            cmd.Parameters.AddWithValue("@Yil", cmbYil.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@YakitTuru",cmbYakitTuru.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@Ehliyet",cmbEhliyet.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@AracRuhsatNo",txtAracRuhsatNo.Text);
            cmd.Parameters.AddWithValue("@Km",txtKm.Text);
            cmd.Parameters.AddWithValue("@SGunluk", txtSGunluk.Text);
            cmd.Parameters.AddWithValue("@SHaftalik",txtSHaftalik.Text);
            cmd.Parameters.AddWithValue("@SAylik", txtSAylik.Text);
            cmd.Parameters.AddWithValue("@SYillik",txtSYillik.Text);
            cmd.Parameters.AddWithValue("@DGunluk", txtDGunluk.Text);
            cmd.Parameters.AddWithValue("@DHaftalik", txtDHaftalik.Text);
            cmd.Parameters.AddWithValue("@DAylik", txtDAylik.Text);
            cmd.Parameters.AddWithValue("@DYillik", txtDYillik.Text); 
            cmd.Parameters.AddWithValue("@KiraDurumu",0); 
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void AracGuncelle(OpenFileDialog _openfolder, PictureBox _arac, string _StoredProcedure,
            TextBox txtPlaka, ComboBox cmbMarka, ComboBox cmbAracTipi, ComboBox cmbModel, ComboBox cmbRenk, ComboBox cmbYakitTuru,
            ComboBox cmbEhliyet, ComboBox cmbVites, ComboBox cmbYil, TextBox txtAracRuhsatNo, TextBox txtKm, TextBox txtSGunluk,
             TextBox txtSHaftalik, TextBox txtSAylik, TextBox txtSYillik, TextBox txtDGunluk, TextBox txtDHaftalik,
            TextBox txtDAylik, TextBox txtDYillik , int SehiriciID,int GorselID,int SehirDisiID,int AracBilgiID)
        {
            try
            {
                SQLConnection.ConnectionOpen(con);
                SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
                cmd.CommandText = _StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;

                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] gorsel = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();
                cmd.Parameters.Add("@Gorsel", SqlDbType.Image, gorsel.Length).Value = gorsel;
                cmd.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@Marka", cmbMarka.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@AracTipi", cmbAracTipi.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Model", cmbModel.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Renk", cmbRenk.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Vites", cmbVites.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Yil", cmbYil.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@YakitTuru", cmbYakitTuru.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Ehliyet", cmbEhliyet.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@AracRuhsatNo", txtAracRuhsatNo.Text);
                cmd.Parameters.AddWithValue("@Km", txtKm.Text);
                cmd.Parameters.AddWithValue("@SGunluk", txtSGunluk.Text);
                cmd.Parameters.AddWithValue("@SHaftalik", txtSHaftalik.Text);
                cmd.Parameters.AddWithValue("@SAylik", txtSAylik.Text);
                cmd.Parameters.AddWithValue("@SYillik", txtSYillik.Text);
                cmd.Parameters.AddWithValue("@DGunluk", txtDGunluk.Text);
                cmd.Parameters.AddWithValue("@DHaftalik", txtDHaftalik.Text);
                cmd.Parameters.AddWithValue("@DAylik", txtDAylik.Text);
                cmd.Parameters.AddWithValue("@DYillik", txtDYillik.Text);
                cmd.Parameters.AddWithValue("@SehiriciID", SehiriciID);
                cmd.Parameters.AddWithValue("@GorselID", GorselID);
                cmd.Parameters.AddWithValue("@SehirDisiID", SehirDisiID);
                cmd.Parameters.AddWithValue("@AracBilgiID", AracBilgiID);
                cmd.ExecuteNonQuery();
                SQLConnection.ConnectionClose(con);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            
        }
        public void ResimY(PictureBox pic,DataGridView dgw,int kolonno)
        { 
            byte[] resim = new byte[0];
            resim =(byte[])dgw.CurrentRow.Cells[kolonno].Value; ;
            MemoryStream ms = new MemoryStream(resim);
            pic.Image = Image.FromStream(ms);

            //SQLConnection.ConnectionOpen(con);
            //SqlCommand cmd = new SqlCommand(SP, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    if (dr["Gorsel"] != null)
            //    {
            //        byte[] resim = new byte[0];
            //        resim = (byte[])dr["Gorsel"];
            //        MemoryStream ms = new MemoryStream(resim);
            //        pic.Image = Image.FromStream(ms);
            //        dr.Close();
            //        cmd.Dispose();
            //        SQLConnection.ConnectionClose(con);
            //    }
            //}
        }
        public void Guncelle(string StoreProcedure,string SpParamValue,string Value1, string SpParamValue2, int Value2)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(SpParamValue, con);
            cmd.CommandText = StoreProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(SpParamValue, Value1);
            cmd.Parameters.AddWithValue(SpParamValue2, Value2);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void Guncelle2(string StoreProcedure, string SpParamValue, string Value1, string SpParamValue2,
            int Value2, string SpParamValue3, int Value3)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(SpParamValue, con);
            cmd.CommandText = StoreProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(SpParamValue, Value1);
            cmd.Parameters.AddWithValue(SpParamValue2, Value2);
            cmd.Parameters.AddWithValue(SpParamValue3, Value3);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void MusteriEkle(string _StoredProcedure,MaskedTextBox TC, TextBox Ad, TextBox Soyad, MaskedTextBox Telefon, RichTextBox Adres, TextBox Email, ComboBox Cinsiyet,
            DateTimePicker DogumTarihi,MaskedTextBox EhliyetNo, ComboBox EhliyetID, DateTimePicker EhliyetTarihi)
        {
            string _cinsiyet="";
            if (Cinsiyet.SelectedIndex == 0)
            {
                _cinsiyet = "E";
            }
            else
            {
                _cinsiyet = "K";
            }
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", TC.Text);
            cmd.Parameters.AddWithValue("@Ad",Ad.Text );
            cmd.Parameters.AddWithValue("@Soyad", Soyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", Telefon.Text);
            cmd.Parameters.AddWithValue("@Adres", Adres.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", _cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", DogumTarihi.Value);
            cmd.Parameters.AddWithValue("@EhliyetNo",EhliyetNo.Text);
            cmd.Parameters.AddWithValue("@EhliyetID", EhliyetID.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@EhliyetTarihi", EhliyetTarihi.Value);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
     
        public void OzellikEkle1(string _StoredProcedure,string SpParamName,TextBox Value)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(SpParamName,Value.Text.ToUpper());
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void OzellikEkle2(string _StoredProcedure, string SpParamName, TextBox Value, string SpParamName2, int Value2)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(SpParamName, Value.Text.ToUpper());
            cmd.Parameters.AddWithValue(SpParamName2, Value2);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }

        public void MusteriUpdate(string _StoredProcedure, MaskedTextBox TC, TextBox Ad, TextBox Soyad, MaskedTextBox Telefon, RichTextBox Adres, TextBox Email, ComboBox Cinsiyet,
           DateTimePicker DogumTarihi, MaskedTextBox EhliyetNo, ComboBox EhliyetID, DateTimePicker EhliyetTarihi,int MusteriID)
        {
            string _cinsiyet = "";
            if (Cinsiyet.SelectedIndex == 0)
            {
                _cinsiyet = "E";
            }
            else
            {
                _cinsiyet = "K";
            }
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
            cmd.Parameters.AddWithValue("@TC", TC.Text);
            cmd.Parameters.AddWithValue("@Ad", Ad.Text);
            cmd.Parameters.AddWithValue("@Soyad", Soyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", Telefon.Text);
            cmd.Parameters.AddWithValue("@Adres", Adres.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", _cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", DogumTarihi.Value);
            cmd.Parameters.AddWithValue("@EhliyetNo", EhliyetNo.Text);
            cmd.Parameters.AddWithValue("@EhliyetID", EhliyetID.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@EhliyetTarihi", EhliyetTarihi.Value);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void MusteriYenidenEkle(string _StoredProcedure, MaskedTextBox TC, TextBox Ad, TextBox Soyad, MaskedTextBox Telefon, RichTextBox Adres, TextBox Email, ComboBox Cinsiyet,
         DateTimePicker DogumTarihi, MaskedTextBox EhliyetNo, ComboBox EhliyetID, DateTimePicker EhliyetTarihi)
        {
            string _cinsiyet = "";
            if (Cinsiyet.SelectedIndex == 0)
            {
                _cinsiyet = "E";
            }
            else
            {
                _cinsiyet = "K";
            }
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", TC.Text);
            cmd.Parameters.AddWithValue("@Ad", Ad.Text);
            cmd.Parameters.AddWithValue("@Soyad", Soyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", Telefon.Text);
            cmd.Parameters.AddWithValue("@Adres", Adres.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", _cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", DogumTarihi.Value);
            cmd.Parameters.AddWithValue("@EhliyetNo", EhliyetNo.Text);
            cmd.Parameters.AddWithValue("@EhliyetID", EhliyetID.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@EhliyetTarihi", EhliyetTarihi.Value);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }

      
        public DataGridView DatagridDoldur(DataGridView mydataGrid, string _StoredProcedure)
        {
            SQLConnection.ConnectionOpen(con);
            SqlDataAdapter sqldt = new SqlDataAdapter(_StoredProcedure, con);
            ds = new DataSet();
            DataTable dataTable = new DataTable();
            sqldt.Fill(ds, _StoredProcedure);
            mydataGrid.DataSource = ds.Tables[_StoredProcedure];
            SQLConnection.ConnectionClose(con);
            return mydataGrid;
        }
        public DataGridView DatagridDoldur2(DataGridView mydataGrid, string _StoredProcedure, int ID)
        {
            SQLConnection.ConnectionOpen(con);
            SqlDataAdapter sqldt = new SqlDataAdapter(_StoredProcedure, con);
            sqldt.SelectCommand.Parameters.Add("@MarkaID", SqlDbType.Int).Value = ID;
            sqldt.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            DataTable dataTable = new DataTable();
            sqldt.Fill(ds, _StoredProcedure);
            mydataGrid.DataSource = ds.Tables[_StoredProcedure];
            SQLConnection.ConnectionClose(con);
            return mydataGrid;
        }
        public DataGridView DatagridDoldur3(DataGridView mydataGrid, string _StoredProcedure,string SPvalue ,string ID)
        {
            SQLConnection.ConnectionOpen(con);
            SqlDataAdapter sqldt = new SqlDataAdapter(_StoredProcedure, con);
            sqldt.SelectCommand.Parameters.Add(SPvalue, ID) ;
            sqldt.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            DataTable dataTable = new DataTable();
            sqldt.Fill(ds, _StoredProcedure);
            mydataGrid.DataSource = ds.Tables[_StoredProcedure];
            SQLConnection.ConnectionClose(con);
            return mydataGrid;
        }

        public void Sil(string _StoredProcedure, string _ProcedureValue, int data)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandText = _StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(_ProcedureValue, data);
            command.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }

        public void Arama(string _StoredProcedure, DataGridView mygrid, string ParametrsValue, string Value)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(ParametrsValue, Value);
            SqlDataAdapter adtr = new SqlDataAdapter(command);
            DataTable dtb = new DataTable();
            adtr.Fill(dtb);
            mygrid.DataSource = dtb;
        }
        public void Arama2(string _StoredProcedure, DataGridView mygrid, string ParametrsValue, string Value, string ParametrsValue2, int Value2)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(ParametrsValue, Value);
            command.Parameters.AddWithValue(ParametrsValue2, Value2);
            SqlDataAdapter adtr = new SqlDataAdapter(command);
            DataTable dtb = new DataTable();
            adtr.Fill(dtb);
            mygrid.DataSource = dtb;
        }
        public void TxtAracDoldur(string _StoredProcedure, TextBox txtPlaka, ComboBox Marka, ComboBox Model, ComboBox AracTipi,
            
          ComboBox Renk, ComboBox Vites, ComboBox Yakit, ComboBox Ehliyet, ComboBox Yil, TextBox Km, TextBox AracRuhsatNo,
          TextBox SehiriciGunluk, TextBox SehiriciHaftalik, TextBox SehiriciAylik, TextBox SehiriciYillik, TextBox SehirDisiGunluk,
          TextBox SehirDisiHaftalik, TextBox SehirDisiAylik, TextBox SehirDisiYillik, PictureBox Gorsel, ComboBox KiraDurumu,int AracBilgiID)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AracBilgiID", AracBilgiID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPlaka.Text = (dr[1]).ToString();
                Marka.Text = (dr[2]).ToString();
                Model.Text = (dr[3]).ToString();
                AracRuhsatNo.Text = (dr[4]).ToString();
                Renk.Text = (dr[5]).ToString();
                Km.Text = (dr[6]).ToString();
                if (Convert.ToString(dr[7]) == "False")
                {
                    KiraDurumu.Text = "Kiralanmamış";
                }
                else
                {
                    KiraDurumu.Text = "Kiralanmış";
                }
                AracTipi.Text = (dr[8]).ToString();
                SehirDisiGunluk.Text = (dr[9]).ToString();
                SehirDisiHaftalik.Text = (dr[10]).ToString();
                SehirDisiAylik.Text = (dr[11]).ToString();
                SehirDisiYillik.Text = (dr[12]).ToString();
                SehiriciGunluk.Text = (dr[13]).ToString();
                SehiriciHaftalik.Text = (dr[14]).ToString();
                SehiriciAylik.Text = (dr[15]).ToString();
                SehiriciYillik.Text = (dr[16]).ToString();
                Yil.Text = (dr[17]).ToString();
                Yakit.Text = (dr[18]).ToString();
                Ehliyet.Text = (dr[19]).ToString();
                Vites.Text = (dr[20]).ToString();              
            }
            dr.Close();
            SQLConnection.ConnectionClose(con);
        }
        public void TxtMusteriDoldur(string _StoredProcedure, Label Ad, Label Soyad, Label Cinsiyet, Label DogumT, Label Telefon,
            Label Mail, Label EhliyetSinifi, Label EhliyetNO, Label EhliyetTarihi, Label Adres, TextBox TC)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", TC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ad.Text = (dr[2]).ToString();
                Soyad.Text = (dr[3]).ToString(); 
                Telefon.Text = (dr[4]).ToString();
                Adres.Text = (dr[5]).ToString();
                Mail.Text = (dr[6]).ToString();
                if (Convert.ToString(dr[7]) == "E")
                {
                    Cinsiyet.Text = "Erkek";
                }
                else
                {
                    Cinsiyet.Text = "Kadın";
                }
                DogumT.Text = (dr[8]).ToString();  
                EhliyetSinifi.Text = (dr[10]).ToString();
                EhliyetNO.Text = (dr[11]).ToString();
                EhliyetTarihi.Text = (dr[12]).ToString();
                
            }
            dr.Close();
            SQLConnection.ConnectionClose(con);
        }
        public bool VeriVarMi(string _StoredProcedure, string TableColumName, string data)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandText = _StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(TableColumName, data);
            SqlDataReader varmi = command.ExecuteReader();
            if (varmi.Read())
            {
                SQLConnection.ConnectionClose(con);
                return false; // Veri tabanında var
            }
            else
            {
                SQLConnection.ConnectionClose(con);
                return true; // Veri tabanında  yok
            }
        }
        public void AracCek(string SP,string plaka,int AracID,int SehiriciID,int SehirdisiID,int GorselID)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(SP, con);
            command.CommandText = SP;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Plaka", plaka);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                AracID = Convert.ToInt32(dr[0]);
                SehiriciID = Convert.ToInt32(dr[0]);
                SehirdisiID = Convert.ToInt32(dr[0]);
                GorselID = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            SQLConnection.ConnectionClose(con);
        }
        public bool VeriVarMi2(string _StoredProcedure, string TableColumName, string data, string TableColumName2, int data2)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandText = _StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(TableColumName, data);
            command.Parameters.AddWithValue(TableColumName2, data2);
            SqlDataReader varmi = command.ExecuteReader();
            if (varmi.Read())
            {
                SQLConnection.ConnectionClose(con);
                return false; // Veri tabanında var
            }
            else
            {
                SQLConnection.ConnectionClose(con);
                return true; // Veri tabanında  yok
            }
        }
        public void ComboboxFill2( string _StoreProcedure, ComboBox cmb,ComboBox cmbbaglantili, string EklenecekID)
        {
                SQLConnection.ConnectionOpen(con);
                SqlCommand cmd = new SqlCommand(_StoreProcedure, con);
                cmd.CommandText = _StoreProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(EklenecekID, Convert.ToInt32(cmbbaglantili.SelectedIndex) + 1);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[1]);
                }
                con.Close();
                dr.Close();
        }
        public void ComboboxFill(string _StoreProcedure, ComboBox cmb,string Columname)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoreProcedure, con);
            cmd.CommandText = _StoreProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {         
                    cmb.Items.Add(dr[Columname]);                           
            }
            dr.Close();
            con.Close();
        }
        public void DataReaderFiil(string _StoredProcedure, int MusteriID, TextBox txtTC, Label lblAd, Label lblSoyad, Label lblCinsiyet, Label lblDogumT, Label lblTelefon
            , Label lblEmail, Label lblEhliyetSinifi, Label lblEhliyetNo, Label lblEhliyetTarihi, Label lblAdres)

        {
           
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tc", txtTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MusteriID = Convert.ToInt32((dr[0]));
                lblAd.Text = (dr[2]).ToString();
                lblSoyad.Text = (dr[3]).ToString();
                lblCinsiyet.Text = (dr[7]).ToString();
                lblDogumT.Text = (dr[8]).ToString();
                lblTelefon.Text = (dr[4]).ToString();
                lblEmail.Text = (dr[6]).ToString();
                lblEhliyetSinifi.Text = (dr[10]).ToString();
                lblEhliyetNo.Text = (dr[11]).ToString();
                lblEhliyetTarihi.Text = (dr[12]).ToString();
                lblAdres.Text = (dr[5]).ToString();
            }
            dr.Close();
            SQLConnection.ConnectionClose(con);

        }
        public int Comboboxİndex(ComboBox cmb)
        {
           return  Convert.ToInt32(cmb.SelectedIndex);
        }
      public void KiraEkle(string _StoredProcedure,int AracID,int MusteriID,DateTimePicker AlısTarihi, DateTimePicker TeslimTarihi,float Fiyat)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AracBilgiID", AracID);
            cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
            cmd.Parameters.AddWithValue("@AlisTarihi", AlısTarihi.Value);
            cmd.Parameters.AddWithValue("@TeslimTarihi", TeslimTarihi.Value);
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void PersonelGüncellee(string _StoredProcedure, MaskedTextBox maskedTextBox1, TextBox txtPersonelAdi, TextBox txtPersonelSoyad, MaskedTextBox txtPersonelTelefon, TextBox txtPersonelMail, DateTimePicker dateTimePicker1, ComboBox cmbEhliyetTürü, RichTextBox richPersonelAdres
           , DateTimePicker dateGirisTarih, DateTimePicker dateTimePicker3)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Ad", txtPersonelAdi.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtPersonelTelefon.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@EhliyetSinifi", cmbEhliyetTürü.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@Adres", richPersonelAdres.Text);
            cmd.Parameters.AddWithValue("@Email", txtPersonelMail.Text);
            cmd.Parameters.AddWithValue("@Tarih1", dateGirisTarih.Value);
            cmd.Parameters.AddWithValue("@Tarih2", dateTimePicker3.Value);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void PersonelEkle(string _StoredProcedure, MaskedTextBox maskedTextBox1, TextBox txtPersonelAdi, TextBox txtPersonelSoyad, MaskedTextBox txtPersonelTelefon, TextBox txtPersonelMail,
            DateTimePicker dateTimePicker1, ComboBox cmbEhliyetTürü, RichTextBox richPersonelAdres, DateTimePicker dateGirisTarih)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Ad", txtPersonelAdi.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtPersonelTelefon.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@EhliyetSinifi", cmbEhliyetTürü.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@Adres", richPersonelAdres.Text);
            cmd.Parameters.AddWithValue("@Email", txtPersonelMail.Text);
            cmd.Parameters.AddWithValue("@Tarih1", dateGirisTarih.Value);;        
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void TeslimAl(string _StoredProcedure,int PersonelID,int KiraID,int Km,int AracBilgiID)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand cmd = new SqlCommand(_StoredProcedure, con);
            cmd.CommandText = _StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
            cmd.Parameters.AddWithValue("@KiraID", KiraID);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@Km",Km);
            cmd.Parameters.AddWithValue("@AracBilgiID", AracBilgiID);
            cmd.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }
        public void KullaniciEkle(string _StoredProcedure, KullanicilarProp kullaniciProperties)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandText = _StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciProperties.KullaniciAdi);
            command.Parameters.AddWithValue("@Sifre", Sha512Enctriyption.SHA512Enctriyption(kullaniciProperties.Sifre));
            command.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }

        public void Delete(string _StoredProcedure, string _ProcedureValue, string data)
        {
            try
            {
                SQLConnection.ConnectionOpen(con);
                SqlCommand command = new SqlCommand(_StoredProcedure, con);
                command.CommandText = _StoredProcedure;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(_ProcedureValue, data);

                command.ExecuteNonQuery();
                SQLConnection.ConnectionClose(con);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }

        public void KullaniciGüncelle(string _StoredProcedure, KullanicilarProp kullaniciProperties)
        {
            SQLConnection.ConnectionOpen(con);
            SqlCommand command = new SqlCommand(_StoredProcedure, con);
            command.CommandText = _StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@KullaniciID", kullaniciProperties.KullaniciID);
            //command.Parameters.AddWithValue("@KullaniciAdi", kullaniciProperties.KullaniciAdi);
            command.Parameters.AddWithValue("@Sifre", Sha512Enctriyption.SHA512Enctriyption(kullaniciProperties.Sifre));
            command.ExecuteNonQuery();
            SQLConnection.ConnectionClose(con);
        }

    }
}
