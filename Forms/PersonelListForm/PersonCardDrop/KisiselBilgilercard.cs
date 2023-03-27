using PerModule.Forms.DepartmanForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerModule.Forms.PersonelListForm;

namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    public partial class KisiselBilgilercard : Form

    {
        string tckn = PersonelList.tcno;
        bool kayitkontrol = false;
        //kayıt var mı yok mu?

        int personid;
        string pertckn;
        string adi;
        string soyadi;
        DateTime dogumtarihi;
        int maasid;
        string cinsiyeti;
        string maili;
        string teli;
        string gorseli;
        //boşsa null atadık yukarıda
        int egitimbilgileriid;
        string kangrubu;
        string medenihali;
        int adresiid;
        DateTime isegirist;
        DateTime? istenayrilist;
        string ayrilmasebebi;
        int depiid;
        string nicki;
        string sifresi;
        string yetkisi;
        string dogumyeri;
        string uyrugu;
        string ehliyetseviyesi;
        string sicilnosu;
        DateTime? ehliyetalist;
        string sigarasi;
        string askerligi;
        string ibani;
        int mesaisiid;
        string isteli;
        string wpteli;
        string yakini1adsoyadi;
        string yakini1teli;
        string yakini1derecesi;
        string yakini2adsoyadi;
        string yakini2teli;
        string yakini2derecesi;
        string sertifikasi1adi;
        string sertifikasi1kurum;
        DateTime? sertifikasi1tarihi;
        string sertifikasi2adi;
        string sertifikasi2kurum;
        DateTime? sertifikasi2tarihi;

        string yabanciDil1;
        string yabanciDil1Düzey;
        string yabanciDil2;
        string yabanciDil2Düzey;
        string yabanciDil3;
        string yabanciDil3Düzey;
        //is yeri
        string IsYeri1;
        string IsUnvan1;
        DateTime? IseGirisD1;
        DateTime? IstenCikis1;
        string IstenAyrilis1;

        string IsYeri2;
        string IsUnvan2;
        DateTime? IseGirisD2;
        DateTime? IstenCikis2;
        string IstenAyrilis2;

        string IsYeri3;
        string IsUnvan3;
        DateTime? IseGirisD3;
        DateTime? IstenCikis3;
        string IstenAyrilis3;

        string IsYeri4;
        string IsUnvan4;
        DateTime? IseGirisD4;
        DateTime? IstenCikis4;
        string IstenAyrilis4; 


        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public KisiselBilgilercard()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

         public void dropDepartmansDoldur()
        {
            DropKBDepDoldurKB.Items.Clear();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand doldur = new SqlCommand("SELECT Departmanlar FROM DepartmanDrop", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                DropKBDepDoldurKB.Items.Add(dr[0]);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        public void temizlekb()
        {
            txtAdKB.Clear();
            txtSoyadKB.Clear();
            txtDogumYeriKB.Clear();
            txtUyrukKB.Clear();
            //...
        }

        public void CikarGizle()
        {
            btnPersonnelCikarKB.Visible = false;
        }
        public void CloseGizle()
        {
            btnClose.Visible = false;
        }

        public void KisiselBilgilercard_Load(object sender, EventArgs e)
        {
            dropDepartmansDoldur();

            txtTcknKB.MaxLength = 11;
            txtIBANKB.MaxLength = 26;
            txtCepTelKB.MaxLength = 12;
            txtIsTelKB.MaxLength = 12;
            txtWhatsAppTelKB.MaxLength = 12;
            txtYakin1KB.MaxLength = 12;
            txtYakin2KB.MaxLength = 12;
            txtSicilNoKB.MaxLength = 26;
            txtBaslamaYiliKB.MaxLength = 4;
            txtBitirmeYiliKB.MaxLength = 4;

            DateTime dtdogumtarihi = DateTime.Now;
            int yil = int.Parse(dtdogumtarihi.ToString("yyyy"));
            int ay = int.Parse(dtdogumtarihi.ToString("MM"));
            int gun = int.Parse(dtdogumtarihi.ToString("dd"));

            DTDogumTarihiKB.MinDate = new DateTime(1960, 1, 1);
            DTDogumTarihiKB.MaxDate = new DateTime(yil - 18, ay, gun);
            DTDogumTarihiKB.Format = DateTimePickerFormat.Short;
            DTEhliyetA.Format = DateTimePickerFormat.Short;
            DTEhliyetA.MinDate= new DateTime(1938, 11, 10);
            DTSertifikaT1.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT1.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT1.Format = DateTimePickerFormat.Short;
            DTSertifikaT2.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT2.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT2.Format = DateTimePickerFormat.Short;
            DTSertifikaT1.Format = DateTimePickerFormat.Short;
            DTSertifikaT2.Format = DateTimePickerFormat.Short;

            dtIseGiris1.Format = DateTimePickerFormat.Short;
            dtIseGiris2.Format = DateTimePickerFormat.Short;
            dtIseGiris3.Format = DateTimePickerFormat.Short;
            dtIseGiris4.Format = DateTimePickerFormat.Short;

            dtIstenCikis1.Format = DateTimePickerFormat.Short;
            dtIstenCikis2.Format = DateTimePickerFormat.Short;
            dtIstenCikis3.Format = DateTimePickerFormat.Short;
            dtIstenCikis4.Format = DateTimePickerFormat.Short;

            DTisegirist.Format = DateTimePickerFormat.Short;
            /*if (dropSEhliyetKB.Text == "Yok")
            {
                DTEhliyetA.Enabled = false;
                DTEhliyetA.Value = DTEhliyetA.MinDate;
            }
            else
            {
                DTEhliyetA.Enabled = true;
            }*/
        }

        public void kbdegisken()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            // tüm satırları seç
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personnels where PerTckn=@tckn", baglan);
            cmd.Parameters.AddWithValue("@tckn", tckn);
            SqlDataReader readercmd = cmd.ExecuteReader();

            // satırları oku ve değişkenlere ata
            while (readercmd.Read())
            {
                personid = (int)readercmd["id"];
                pertckn = (string)readercmd["PerTckn"];
                adi = (string)readercmd["PerAd"];
                soyadi = (string)readercmd["PerSoyad"];
                dogumtarihi = (DateTime)readercmd["PerDogumTarihi"];
                maasid = readercmd.IsDBNull(readercmd.GetOrdinal("PerMaas")) ? 0 : int.Parse(readercmd["PerMaas"].ToString());
                cinsiyeti = (string)readercmd["PerCinsiyet"];
                maili = (string)readercmd["PerMail"];
                teli = (string)readercmd["PerTel"];
                gorseli = readercmd.IsDBNull(readercmd.GetOrdinal("PerGorsel")) ? null : (string)readercmd["PerGorsel"];
                //boşsa null atadık yukarıda
                egitimbilgileriid = (int)readercmd["PerEgitimBilgileri"];
                kangrubu = (string)readercmd["PerKanGrubu"];
                medenihali = (string)readercmd["PerMedeniHali"];
                adresiid = (int)readercmd["Adresid"];
                isegirist = (DateTime)readercmd["PerBaslamaT"];
                istenayrilist = readercmd.IsDBNull(readercmd.GetOrdinal("PerAyrilisT")) ? (DateTime?)null : (DateTime)readercmd["PerAyrilisT"];
                ayrilmasebebi = readercmd.IsDBNull(readercmd.GetOrdinal("PerAyrilmaSebebi")) ? null : (string)readercmd["PerAyrilmaSebebi"];
                depiid = (int)readercmd["Departmanid"];
                nicki = (string)readercmd["PerNickName"];
                sifresi = (string)readercmd["PerPassword"];
                yetkisi = (string)readercmd["PerYetki"];
                dogumyeri = (string)readercmd["PerDogumYeri"];
                uyrugu = (string)readercmd["PerUyruk"];
                ehliyetseviyesi = (string)readercmd["PerEhliyetS"];
                sicilnosu = (string)readercmd["PerSicilNo"];
                ehliyetalist = readercmd.IsDBNull(readercmd.GetOrdinal("PerDEhliyetAlis")) ? (DateTime?)null : (DateTime)readercmd["PerDEhliyetAlis"];
                sigarasi = (string)readercmd["PerSigaraK"];
                askerligi = (string)readercmd["PerAskerlik"];
                ibani = (string)readercmd["PerIBAN"];
                mesaisiid = (int)readercmd["Mesaiid"];
                isteli = (string)readercmd["PerIsTel"];
                wpteli = (string)readercmd["PerWpTel"];
                yakini1adsoyadi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini1AdSoyad")) ? null : (string)readercmd["Yakini1AdSoyad"];
                yakini1teli = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini1Tel")) ? null : (string)readercmd["Yakini1Tel"];
                yakini1derecesi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini1Derece")) ? null : (string)readercmd["Yakini1Derece"];
                yakini2adsoyadi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini2AdSoyad")) ? null : (string)readercmd["Yakini2AdSoyad"];
                yakini2teli = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini2Tel")) ? null : (string)readercmd["Yakini2Tel"];
                yakini2derecesi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini2Derece")) ? null : (string)readercmd["Yakini2Derece"];
                sertifikasi1adi = readercmd.IsDBNull(readercmd.GetOrdinal("SertifikaLisans1Ad")) ? null : (string)readercmd["SertifikaLisans1Ad"];
                sertifikasi1kurum = readercmd.IsDBNull(readercmd.GetOrdinal("SertifikaLisans1VerenKurum")) ? null : (string)readercmd["SertifikaLisans1VerenKurum"];
                sertifikasi1tarihi = readercmd.IsDBNull(readercmd.GetOrdinal("SertifikaLisans1Tarihi")) ? (DateTime?)null : (DateTime)readercmd["SertifikaLisans1Tarihi"];
                sertifikasi2adi = readercmd.IsDBNull(readercmd.GetOrdinal("SertifikaLisans2Ad")) ? null : (string)readercmd["SertifikaLisans2Ad"];
                sertifikasi2kurum = readercmd.IsDBNull(readercmd.GetOrdinal("SertifikaLisans2VerenKurum")) ? null : (string)readercmd["SertifikaLisans2VerenKurum"];
                sertifikasi2tarihi = readercmd.IsDBNull(readercmd.GetOrdinal("SertifikaLisans2Tarihi")) ? (DateTime?)null : (DateTime)readercmd["SertifikaLisans2Tarihi"];
                //dil bilmeyebilir burası düzeltilecek
                yabanciDil1 = (string)readercmd["YabanciDil1"];
                yabanciDil1Düzey = (string)readercmd["YabanciDil1Düzey"];
                yabanciDil2 = readercmd.IsDBNull(readercmd.GetOrdinal("YabanciDil2")) ? null : (string)readercmd["YabanciDil2"];
                yabanciDil2Düzey = readercmd.IsDBNull(readercmd.GetOrdinal("YabanciDil2Düzey")) ? null : (string)readercmd["YabanciDil2Düzey"];
                yabanciDil3 = readercmd.IsDBNull(readercmd.GetOrdinal("YabanciDil3")) ? null : (string)readercmd["YabanciDil3"];
                yabanciDil3Düzey = readercmd.IsDBNull(readercmd.GetOrdinal("YabanciDil3Düzey")) ? null : (string)readercmd["YabanciDil3Düzey"];
                //is yeri
                IsYeri1 = readercmd.IsDBNull(readercmd.GetOrdinal("IsYeri1")) ? null : (string)readercmd["IsYeri1"];
                IsUnvan1 = readercmd.IsDBNull(readercmd.GetOrdinal("IsUnvan1")) ? null : (string)readercmd["IsUnvan1"];
                IseGirisD1 = readercmd.IsDBNull(readercmd.GetOrdinal("IseGirisD1")) ? (DateTime?)null : (DateTime)readercmd["IseGirisD1"];
                IstenCikis1 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenCikis1")) ? (DateTime?)null : (DateTime)readercmd["IstenCikis1"];
                IstenAyrilis1 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenAyrilis1")) ? null : (string)readercmd["IstenAyrilis1"];

                IsYeri2 = readercmd.IsDBNull(readercmd.GetOrdinal("IsYeri2")) ? null : (string)readercmd["IsYeri2"];
                IsUnvan2 = readercmd.IsDBNull(readercmd.GetOrdinal("IsUnvan2")) ? null : (string)readercmd["IsUnvan2"];
                IseGirisD2 = readercmd.IsDBNull(readercmd.GetOrdinal("IseGirisD2")) ? (DateTime?)null : (DateTime)readercmd["IseGirisD2"];
                IstenCikis2 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenCikis2")) ? (DateTime?)null : (DateTime)readercmd["IstenCikis2"];
                IstenAyrilis2 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenAyrilis2")) ? null : (string)readercmd["IstenAyrilis2"];

                IsYeri3 = readercmd.IsDBNull(readercmd.GetOrdinal("IsYeri3")) ? null : (string)readercmd["IsYeri3"];
                IsUnvan3 = readercmd.IsDBNull(readercmd.GetOrdinal("IsUnvan3")) ? null : (string)readercmd["IsUnvan3"];
                IseGirisD3 = readercmd.IsDBNull(readercmd.GetOrdinal("IseGirisD3")) ? (DateTime?)null : (DateTime)readercmd["IseGirisD3"];
                IstenCikis3 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenCikis3")) ? (DateTime?)null : (DateTime)readercmd["IstenCikis3"];
                IstenAyrilis3 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenAyrilis3")) ? null : (string)readercmd["IstenAyrilis3"];

                IsYeri4 = readercmd.IsDBNull(readercmd.GetOrdinal("IsYeri4")) ? null : (string)readercmd["IsYeri4"];
                IsUnvan4 = readercmd.IsDBNull(readercmd.GetOrdinal("IsUnvan4")) ? null : (string)readercmd["IsUnvan4"];
                IseGirisD4 = readercmd.IsDBNull(readercmd.GetOrdinal("IseGirisD4")) ? (DateTime?)null : (DateTime)readercmd["IseGirisD4"];
                IstenCikis4 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenCikis4")) ? (DateTime?)null : (DateTime)readercmd["IstenCikis4"];
                IstenAyrilis4 = readercmd.IsDBNull(readercmd.GetOrdinal("IstenAyrilis4")) ? null : (string)readercmd["IstenAyrilis4"];
                // değişkenlerle yapılacak işlemler

            }
            // bağlantıyı kapat
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

        }
    
        public void kbdoldur()//eksik BİLGİLERİ YERİNE KOYMA
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand tcnilekb = new SqlCommand("select * from Personnels where PerTckn=@tcno", baglan);
            tcnilekb.Parameters.AddWithValue("@tcno", PersonelList.tcno);
            SqlDataReader tcnokbokuma = tcnilekb.ExecuteReader();
            while (tcnokbokuma.Read())
            {
                txtTcknKB.Text = tcnokbokuma.GetValue(1).ToString();
                txtAdKB.Text = tcnokbokuma.GetValue(2).ToString();
                txtSoyadKB.Text = tcnokbokuma.GetValue(3).ToString();
                DTDogumTarihiKB.Text = tcnokbokuma.GetValue(4).ToString();
                //maas
                dropCinsiyetKB.Text = tcnokbokuma.GetValue(6).ToString();
                txtEpostaKB.Text = tcnokbokuma.GetValue(7).ToString();
                txtCepTelKB.Text = tcnokbokuma.GetValue(8).ToString();
                //gorsel
                //egitim
                dropKanGrubuKB.Text = tcnokbokuma.GetValue(11).ToString();
                dropMedeniHalKB.Text = tcnokbokuma.GetValue(12).ToString();
                //adres
                DTisegirist.Text = tcnokbokuma.GetValue(14).ToString();
                //ayrılıst
                //ayrılma sebebi
                //departnanid
                //nick
                //password
                dropYetki.Text = tcnokbokuma.GetValue(20).ToString();
                txtDogumYeriKB.Text = tcnokbokuma.GetValue(21).ToString();
                txtUyrukKB.Text = tcnokbokuma.GetValue(22).ToString();
                dropSEhliyetKB.Text = tcnokbokuma.GetValue(23).ToString();
                txtSicilNoKB.Text = tcnokbokuma.GetValue(24).ToString();
                DTEhliyetA.Text = tcnokbokuma.GetValue(25).ToString();
                dropSigaraKKB.Text = tcnokbokuma.GetValue(26).ToString();
                dropAskerlikKB.Text = tcnokbokuma.GetValue(27).ToString();
                txtIBANKB.Text = tcnokbokuma.GetValue(28).ToString();
                //mesai
                txtIsTelKB.Text = isteli;
                txtWhatsAppTelKB.Text = wpteli;
                txtYakiniadsoyad1.Text = yakini1adsoyadi;
                txtYakin1KB.Text = yakini1teli;
                txtYakinderece1.Text = yakini1derecesi;
                txtYakiniadsoyad2.Text = yakini2adsoyadi;
                txtYakin2KB.Text = yakini2teli;
                txtYakinderece2.Text = yakini2derecesi;
                txtSertifika1.Text = sertifikasi1adi;
                txtSertverenkurum1.Text = sertifikasi1kurum;
                DTSertifikaT1.Text = tcnokbokuma.GetValue(40).ToString();
                txtSertifika2.Text = sertifikasi2adi;
                txtSertverenkurum2.Text = sertifikasi2kurum;
                DTSertifikaT2.Text = tcnokbokuma.GetValue(43).ToString();
                txtYabanciDil1.Text = yabanciDil1;
                dropYabanciDilDuzey1.Text = yabanciDil1Düzey;
                txtYabanciDil2.Text = yabanciDil2;
                dropYabanciDilDuzey2.Text = yabanciDil2Düzey;
                txtYabanciDil3.Text = yabanciDil3;
                dropYabanciDilDuzey3.Text = yabanciDil3Düzey;
                txtIsYeri1.Text = IsYeri1;
                txtIsUnvan1.Text = IsUnvan1;
                dtIseGiris1.Text = tcnokbokuma.GetValue(52).ToString();
                dtIstenCikis1.Text = tcnokbokuma.GetValue(53).ToString();
                txtIsAyrilis1.Text = IstenAyrilis1;
                txtIsYeri2.Text = IsYeri2;
                txtIsUnvan2.Text = IsUnvan2;
                dtIseGiris2.Text = tcnokbokuma.GetValue(57).ToString();
                dtIstenCikis2.Text = tcnokbokuma.GetValue(58).ToString();
                txtIsAyrilis2.Text = IstenAyrilis2;
                txtIsYeri3.Text = IsYeri3;
                txtIsUnvan3.Text = IsUnvan3;
                dtIseGiris3.Text = tcnokbokuma.GetValue(62).ToString();
                dtIstenCikis3.Text = tcnokbokuma.GetValue(63).ToString();
                txtIsAyrilis3.Text = IstenAyrilis3;
                txtIsYeri4.Text = IsYeri4;
                txtIsUnvan4.Text = IsUnvan4;
                dtIseGiris4.Text = tcnokbokuma.GetValue(67).ToString();
                dtIstenCikis4.Text = tcnokbokuma.GetValue(68).ToString();
                txtIsAyrilis4.Text = IstenAyrilis4;
            }

            SqlCommand kbdolduradres = new SqlCommand("select * from Adreses where id=@adresiid", baglan);
            kbdolduradres.Parameters.AddWithValue("@adresiid", adresiid);
            SqlDataReader adresokuma = kbdolduradres.ExecuteReader();
            while (adresokuma.Read())
            {
                txtUlkeKB.Text=adresokuma.GetValue(1).ToString();
                txtSehirKB.Text = adresokuma.GetValue(2).ToString();
                txtEvAdresi.Text = adresokuma.GetValue(3).ToString();
            }

            SqlCommand kbdolduregitim = new SqlCommand("select * from Egitims where id=@egitim", baglan);
            kbdolduregitim.Parameters.AddWithValue("@egitim", egitimbilgileriid);
            SqlDataReader egitimokuma = kbdolduregitim.ExecuteReader();
            while (egitimokuma.Read())
            {
                int sonemi = Convert.ToInt32(egitimokuma.GetValue(1).ToString());
                if (sonemi == 1)
                {
                    checkSonEgitimmi.Checked = true;
                }
                else
                {
                    checkSonEgitimmi.Checked = false;
                }
                dropEgitimDurumu.Text = egitimokuma.GetValue(2).ToString();
                txtMezunOlunanOkul.Text = egitimokuma.GetValue(3).ToString();
                txtBolumKB.Text = egitimokuma.GetValue(4).ToString();
                txtBaslamaYiliKB.Text = egitimokuma.GetValue(5).ToString();
                txtBitirmeYiliKB.Text = egitimokuma.GetValue(6).ToString();
            }

            SqlCommand kbdoldurdepartmans = new SqlCommand("select * from Departmans where id=@departmaniid", baglan);
            kbdoldurdepartmans.Parameters.AddWithValue("@departmaniid", depiid);
            SqlDataReader depokuma = kbdoldurdepartmans.ExecuteReader();
            while (depokuma.Read())
            {
                DropKBDepDoldurKB.Text = depokuma.GetValue(1).ToString();
                txtRolKB.Text = depokuma.GetValue(2).ToString();
            }

            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            
        }
        

        private void txtKimlikNoKB_TextChanged(object sender, EventArgs e)
        {
            /*if(txtKimlikNoKB.Text.Length <11 )
            {
                this.Alert("Kimlik no 11 karakterli olmalı!", Form_Alert.enmType.Warning);
            }*/
        }

        private void txtKimlikNoKB_KeyPress(object sender, KeyPressEventArgs e)//sadece sayı girilmesi için
        {
            if(((int)e.KeyChar>=48 && (int)e.KeyChar<=57) || (int)e.KeyChar==8)
                e.Handled = false;
            else
                e.Handled=true;
        }

        private void txtSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCepTelKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtIsTelKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtWhatsAppTelKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int egitimdid;
        int adresbid;
        int departmanibid;
        int mesaibid;
        private void btnPersonnelCikarKB_Click(object sender, EventArgs e)
        {
            string tckn = PersonelList.tcno;
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                //personelden silme
                SqlCommand persil = new SqlCommand("DELETE FROM Personnels where PerTckn=@tckn", baglan);
                persil.Parameters.AddWithValue("@tckn", tckn);
                persil.ExecuteNonQuery();
                //personelin adresini,mesaisini,egitimini,departmansını çekme
                SqlCommand persilcek = new SqlCommand("SELECT PerEgitimBilgileri,Adresid,Departmanid,Mesaiid FROM Personnels where PerTckn=@tckn", baglan);
                persilcek.Parameters.AddWithValue("@tckn", tckn);
                SqlDataReader readercmda = persilcek.ExecuteReader();
                // satırları oku ve değişkenlere ata
                while (readercmda.Read())
                {
                    egitimdid = (int)readercmda["PerEgitimBilgileri"];
                    adresbid = (int)readercmda["Adresid"];
                    departmanibid = (int)readercmda["Departmanid"];
                    mesaibid = (int)readercmda["Mesaiid"];
                   
                }
                SqlCommand persilegitim = new SqlCommand("DELETE FROM Egitims where id=@eid", baglan);
                persilegitim.Parameters.AddWithValue("@eid", egitimdid);
                persilegitim.ExecuteNonQuery();

                SqlCommand persiladres = new SqlCommand("DELETE FROM Adreses where id=@aid", baglan);
                persiladres.Parameters.AddWithValue("@aid", adresbid);
                persiladres.ExecuteNonQuery();

                SqlCommand persildepartmans = new SqlCommand("DELETE FROM Departmans where id=@did", baglan);
                persildepartmans.Parameters.AddWithValue("@did", departmanibid);
                persildepartmans.ExecuteNonQuery();

                SqlCommand persilmesaisi = new SqlCommand("DELETE FROM MesaiTakvimi where id=@mid", baglan);
                persilmesaisi.Parameters.AddWithValue("@mid", mesaibid);
                persilmesaisi.ExecuteNonQuery();

                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }

                this.Alert("Personel çıkarma başarılı!", Form_Alert.enmType.Success);
                //ayrılma sebebi aç.
                PersonCard personCard = new PersonCard();
                personCard.Close();
                PersonelList perlist = new PersonelList();
                perlist.searchyenile();
            }
            catch 
            {
                this.Alert("Bir şeyler ters gitti!", Form_Alert.enmType.Error);
            }
            
        }
        int pzt = 0;
        int sali = 0;
        int cmb = 0;
        int pmb = 0;
        int cuma = 0;
        int cmt = 0;
        int pzr = 0;
        //0 yok 1 var
        string yetkikb;
        // yetki--> 2 kurucu
        //          1 yetkili
        //          0 personel
        int edurum;
        public void YokEkle()
        {
            
            if (String.IsNullOrEmpty(txtAdKB.Text) || String.IsNullOrEmpty(txtSoyadKB.Text) || String.IsNullOrEmpty(txtDogumYeriKB.Text) || String.IsNullOrEmpty(DTDogumTarihiKB.Text) || String.IsNullOrEmpty(dropCinsiyetKB.Text) || String.IsNullOrEmpty(txtUyrukKB.Text) || String.IsNullOrEmpty(dropSEhliyetKB.Text) || String.IsNullOrEmpty(DTEhliyetA.Text) || String.IsNullOrEmpty(txtTcknKB.Text) || String.IsNullOrEmpty(dropKanGrubuKB.Text) || String.IsNullOrEmpty(dropMedeniHalKB.Text) || String.IsNullOrEmpty(dropSigaraKKB.Text) || String.IsNullOrEmpty(txtSicilNoKB.Text) || String.IsNullOrEmpty(DropKBDepDoldurKB.Text) || String.IsNullOrEmpty(txtRolKB.Text) || String.IsNullOrEmpty(txtEpostaKB.Text) || String.IsNullOrEmpty(dropAskerlikKB.Text) || String.IsNullOrEmpty(txtIBANKB.Text) || String.IsNullOrEmpty(txtCepTelKB.Text) || String.IsNullOrEmpty(txtEvAdresi.Text) || String.IsNullOrEmpty(txtUlkeKB.Text) || String.IsNullOrEmpty(txtSehirKB.Text))
            {
                //this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                string sqlperekle = "insert into Personnels(PerTckn,PerAd,PerSoyad,PerDogumTarihi,PerDogumYeri,PerUyruk,PerEhliyetS,PerCinsiyet,PerMail,PerTel,PerKanGrubu,PerMedeniHali,PerSicilNo,PerBaslamaT,PerDEhliyetAlis,PerSigaraK,PerAskerlik,PerIBAN,PerYetki,PerIsTel,PerWpTel,Yakini1AdSoyad,Yakini1Tel,Yakini1Derece,Yakini2AdSoyad,Yakini2Tel,Yakini2Derece,SertifikaLisans1Ad,SertifikaLisans1VerenKurum,SertifikaLisans1Tarihi,SertifikaLisans2Ad,SertifikaLisans2VerenKurum,SertifikaLisans2Tarihi,YabanciDil1,YabanciDil1Düzey,YabanciDil2,YabanciDil2Düzey,YabanciDil3,YabanciDil3Düzey,IsYeri1,IsUnvan1,IseGirisD1,IstenCikis1,IstenAyrilis1,IsYeri2,IsUnvan2,IseGirisD2,IstenCikis2,IstenAyrilis2,IsYeri3,IsUnvan3,IseGirisD3,IstenCikis3,IstenAyrilis3,IsYeri4,IsUnvan4,IseGirisD4,IstenCikis4,IstenAyrilis4) values(@PerTckn,@PerAd,@PerSoyad,@PerDogumTarihi,@PerDogumYeri,@PerUyruk,@PerEhliyetS,@PerCinsiyet,@PerMail,@PerTel,@PerKanGrubu,@PerMedeniHali,@PerSicilNo,@PerBaslamaT,@PerDEhliyetAlis,@PerSigaraK,@PerAskerlik,@PerIBAN,@PerYetki,@PerIsTel,@PerWpTel,@Yakini1AdSoyad,@Yakini1Tel,@Yakini1Derece,@Yakini2AdSoyad,@Yakini2Tel,@Yakini2Derece,@SertifikaLisans1Ad,@SertifikaLisans1VerenKurum,@SertifikaLisans1Tarihi,@SertifikaLisans2Ad,@SertifikaLisans2VerenKurum,@SertifikaLisans2Tarihi,@YabanciDil1,@YabanciDil1Düzey,@YabanciDil2,@YabanciDil2Düzey,@YabanciDil3,@YabanciDil3Düzey,@IsYeri1,@IsUnvan1,@IseGirisD1,@IstenCikis1,@IstenAyrilis1,@IsYeri2,@IsUnvan2,@IseGirisD2,@IstenCikis2,@IstenAyrilis2,@IsYeri3,@IsUnvan3,@IseGirisD3,@IstenCikis3,@IstenAyrilis3,@IsYeri4,@IsUnvan4,@IseGirisD4,@IstenCikis4,@IstenAyrilis4)";
                SqlCommand perekle = new SqlCommand(sqlperekle, baglan);
                
                perekle.Parameters.AddWithValue("@PerTckn", txtTcknKB.Text);
                perekle.Parameters.AddWithValue("@PerAd", txtAdKB.Text);
                perekle.Parameters.AddWithValue("@PerSoyad", txtSoyadKB.Text);
                perekle.Parameters.AddWithValue("@PerDogumTarihi", DTDogumTarihiKB.Value);
                perekle.Parameters.AddWithValue("@PerDogumYeri", txtDogumYeriKB.Text);
                perekle.Parameters.AddWithValue("@PerUyruk", txtUyrukKB.Text);
                perekle.Parameters.AddWithValue("@PerEhliyetS", dropSEhliyetKB.Text);
                perekle.Parameters.AddWithValue("@PerDEhliyetAlis", DTEhliyetA.Value);
                perekle.Parameters.AddWithValue("@PerCinsiyet", dropCinsiyetKB.Text);
                perekle.Parameters.AddWithValue("@PerMail", txtEpostaKB.Text);
                perekle.Parameters.AddWithValue("@PerTel", txtCepTelKB.Text);
                perekle.Parameters.AddWithValue("@PerSicilNo", txtSicilNoKB.Text);
                perekle.Parameters.AddWithValue("@PerSigaraK", dropSigaraKKB.Text);
                perekle.Parameters.AddWithValue("@PerAskerlik", dropAskerlikKB.Text);
                perekle.Parameters.AddWithValue("@PerIBAN", txtIBANKB.Text ?? (object)DBNull.Value);
                
                perekle.Parameters.AddWithValue("@PerKanGrubu", dropKanGrubuKB.Text);
                perekle.Parameters.AddWithValue("@PerMedeniHali", dropMedeniHalKB.Text);
                perekle.Parameters.AddWithValue("@PerIsTel", txtIsTelKB.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@PerWpTel", txtWhatsAppTelKB.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@PerBaslamaT", DTisegirist.Value);

                perekle.Parameters.AddWithValue("@Yakini1AdSoyad", txtYakiniadsoyad1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@Yakini1Tel", txtYakin1KB.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@Yakini1Derece", txtYakinderece1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@Yakini2AdSoyad", txtYakiniadsoyad2.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@Yakini2Tel", txtYakin2KB.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@Yakini2Derece", txtYakinderece2.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@SertifikaLisans1Ad", txtSertifika1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@SertifikaLisans1VerenKurum", txtSertverenkurum1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@SertifikaLisans1Tarihi", DTSertifikaT1.Value);
                perekle.Parameters.AddWithValue("@SertifikaLisans2Ad", txtSertifika2.Text ?? (object)DBNull.Value );
                perekle.Parameters.AddWithValue("@SertifikaLisans2VerenKurum", txtSertverenkurum2.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@SertifikaLisans2Tarihi", DTSertifikaT2.Value);
                perekle.Parameters.AddWithValue("@YabanciDil1", txtYabanciDil1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@YabanciDil1Düzey", dropYabanciDilDuzey1.Text);
                perekle.Parameters.AddWithValue("@YabanciDil2", txtYabanciDil2.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@YabanciDil2Düzey", dropYabanciDilDuzey2.Text);
                perekle.Parameters.AddWithValue("@YabanciDil3", txtYabanciDil3.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@YabanciDil3Düzey", dropYabanciDilDuzey3.Text);
                perekle.Parameters.AddWithValue("@IsYeri1", txtIsYeri1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IsUnvan1", txtIsUnvan1.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IseGirisD1", dtIseGiris1.Value);
                perekle.Parameters.AddWithValue("@IstenCikis1", dtIstenCikis1.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis1", txtIsAyrilis1.Text ?? (object)DBNull.Value);

                perekle.Parameters.AddWithValue("@IsYeri2", txtIsYeri2.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IsUnvan2", txtIsUnvan2.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IseGirisD2", dtIseGiris2.Value);
                perekle.Parameters.AddWithValue("@IstenCikis2", dtIstenCikis2.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis2", txtIsAyrilis2.Text ?? (object)DBNull.Value);

                perekle.Parameters.AddWithValue("@IsYeri3", txtIsYeri3.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IsUnvan3", txtIsUnvan3.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IseGirisD3", dtIseGiris3.Value);
                perekle.Parameters.AddWithValue("@IstenCikis3", dtIstenCikis3.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis3", txtIsAyrilis3.Text ?? (object)DBNull.Value);

                perekle.Parameters.AddWithValue("@IsYeri4", txtIsYeri4.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IsUnvan4", txtIsUnvan4.Text ?? (object)DBNull.Value);
                perekle.Parameters.AddWithValue("@IseGirisD4", dtIseGiris4.Value);
                perekle.Parameters.AddWithValue("@IstenCikis4", dtIstenCikis4.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis4", txtIsAyrilis4.Text ?? (object)DBNull.Value);

                if (dropYetki.Text== "Kurucu")
                {
                    yetkikb = "Kurucu";
                }
                else if (dropYetki.Text == "Yetkili")
                {
                    yetkikb = "Yetkili";
                }
                else if(dropYetki.Text == "Personel")
                {
                    yetkikb = "Personel";
                }
                perekle.Parameters.AddWithValue("@PerYetki", yetkikb);
                perekle.ExecuteNonQuery();

                string sqlperekledepartman = "insert into Departmans(DepAdi,DepRolu) values(@DepAdi,@DepRolu)";
                SqlCommand perekledepartman = new SqlCommand(sqlperekledepartman, baglan);
                perekledepartman.Parameters.AddWithValue("@DepAdi", DropKBDepDoldurKB.Text);
                perekledepartman.Parameters.AddWithValue("@DepRolu", txtRolKB.Text ?? (object)DBNull.Value);
                perekledepartman.ExecuteNonQuery();

                string sqlperekleadres = "insert into Adreses(AdresUlke,AdresSehir,AdresEv) values(@AdresUlke,@AdresSehir,@AdresEv)";
                SqlCommand perekleadres = new SqlCommand(sqlperekleadres, baglan);
                perekleadres.Parameters.AddWithValue("@AdresUlke", txtUlkeKB.Text);
                perekleadres.Parameters.AddWithValue("@AdresSehir", txtSehirKB.Text);
                perekleadres.Parameters.AddWithValue("@AdresEv", txtEvAdresi.Text);
                perekleadres.ExecuteNonQuery();

                //mesai takvimi
                if (checkPzt.Checked==true)
                {
                    pzt = 1;
                }
                if (checkSali.Checked == true)
                {
                    sali = 1;
                }
                if (checkCarsamba.Checked == true)
                {
                    cmb = 1;
                }
                if (checkPersmb.Checked == true)
                {
                    pmb = 1;
                }
                if (checkCuma.Checked == true)
                {
                    cuma = 1;
                }
                if (checkCumartesi.Checked == true)
                {
                    cmt = 1;
                }
                if (checkPzr.Checked == true)
                {
                    pzr = 1;
                }
                string sqlmesaiekle = "insert into MesaiTakvimi(pzt,sali,cmb,pmb,cuma,cmt,pzr) values(@pzt,@sali,@cmb,@pmb,@cuma,@cmt,@pzr)";
                SqlCommand mesaiekle = new SqlCommand(sqlmesaiekle, baglan);
                mesaiekle.Parameters.AddWithValue("@pzt", pzt);
                mesaiekle.Parameters.AddWithValue("@sali", sali);
                mesaiekle.Parameters.AddWithValue("@cmb", cmb);
                mesaiekle.Parameters.AddWithValue("@pmb", pmb);
                mesaiekle.Parameters.AddWithValue("@cuma", cuma);
                mesaiekle.Parameters.AddWithValue("@cmt", cmt);
                mesaiekle.Parameters.AddWithValue("@pzr", pzr);
                mesaiekle.ExecuteNonQuery();


                //egitim
                string sqlegitimekle = "insert into Egitims(SonEgitim,EgitimDurumu,MezunOlunanOkul,Bolum,EBBaslamaYili,EBBitirmeYili) values(@SonEgitim,@EgitimDurumu,@MezunOlunanOkul,@Bolum,@EBBaslamaYili,@EBBitirmeYili)";
                SqlCommand egitimekle = new SqlCommand(sqlegitimekle, baglan);
                if (checkSonEgitimmi.Checked == true)
                {
                    edurum = 1;
                }
                else
                {
                    edurum = 0;
                }
                egitimekle.Parameters.AddWithValue("@SonEgitim", edurum);
                egitimekle.Parameters.AddWithValue("@EgitimDurumu", dropEgitimDurumu.Text);
                egitimekle.Parameters.AddWithValue("@MezunOlunanOkul", txtMezunOlunanOkul.Text);
                egitimekle.Parameters.AddWithValue("@Bolum", txtBolumKB.Text);
                egitimekle.Parameters.AddWithValue("@EBBaslamaYili", txtBaslamaYiliKB.Text);
                egitimekle.Parameters.AddWithValue("@EBBitirmeYili", txtBitirmeYiliKB.Text);
                egitimekle.ExecuteNonQuery();

                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
                //temizle();
            }
         }

        private void btnPersonnelGuncelleKB_Click(object sender, EventArgs e)
        {
            varguncelle();
        }

        public void varguncelle()
            //EKSİK
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                string sqlguncelle = "update Personnels set PerAd=@PerAd,PerSoyad=@PerSoyad, PerCinsiyet=@PerCinsiyet, PerDogumTarihi=PerDogumTarihi, PerMail=@PerMail, PerTel=@PerTel, PerMedeniHali=@PerMedeniHali, PerKanGrubu=@PerKanGrubu,PerNickName=@PerNickName,PerPassword=@PerPassword,PerYetki=@PerYetki,PerDogumYeri=@PerDogumYeri,PerUyruk=@PerUyruk,PerEhliyetS=@PerEhliyetS,PerSicilNo=@PerSicilNo,PerDEhliyetAlis=@PerDEhliyetAlis,PerSigaraK=@PerSigaraK,PerAskerlik=@PerAskerlik,PerIBAN=@PerIBAN,PerIsTel=@PerIsTel,PerWpTel=@PerWpTel,Yakini1AdSoyad=@Yakini1AdSoyad,Yakini1Tel=@Yakini1Tel,Yakini1Derece=@Yakini1Derece,Yakini2AdSoyad=@Yakini2AdSoyad,Yakini2Tel=@Yakini2Tel,Yakini2Derece=@Yakini2Derece,SertifikaLisans1Ad=@SertifikaLisans1Ad,SertifikaLisans1VerenKurum=@SertifikaLisans1VerenKurum,SertifikaLisans1Tarihi=@SertifikaLisans1Tarihi,SertifikaLisans2Ad=@SertifikaLisans2Ad,SertifikaLisans2VerenKurum=SertifikaLisans2VerenKurum,SertifikaLisans2Tarihi=@SertifikaLisans2Tarihi,YabanciDil1=@YabanciDil1,YabanciDil1Düzey=@YabanciDil1Düzey,YabanciDil2=@YabanciDil2,YabanciDil2Düzey=@YabanciDil2Düzey, YabanciDil3=@YabanciDil3,YabanciDil3Düzey=@YabanciDil3Düzey,IsYeri1=@IsYeri1,IsUnvan1=@IsUnvan1,IseGirisD1=@IseGirisD1,IstenCikis1=@IstenCikis1,IstenAyrilis1=@IstenAyrilis1,IsYeri2=@IsYeri2,IsUnvan2=@IsUnvan2,IseGirisD2=@IseGirisD2,IstenCikis2=@IstenCikis2,IstenAyrilis2=@IstenAyrilis2,IsYeri3=@IsYeri3,IsUnvan3=@IsUnvan3,IseGirisD3=@IseGirisD3,IstenCikis3=@IstenCikis3,IstenAyrilis3=@IstenAyrilis3,IsYeri4=@IsYeri4,IsUnvan4=@IsUnvan4,IseGirisD4=@IseGirisD4,IstenCikis4=@IstenCikis4,IstenAyrilis4=@IstenAyrilis4 where PerTckn=@tckn";
                SqlCommand guncelle = new SqlCommand(sqlguncelle, baglan);
                guncelle.Parameters.AddWithValue("@tckn", tckn);
                guncelle.Parameters.AddWithValue("@PerAd", txtAdKB.Text);
                guncelle.Parameters.AddWithValue("@PerSoyad", txtSoyadKB.Text);
                guncelle.Parameters.AddWithValue("@PerDogumTarihi", DTDogumTarihiKB.Value);
                guncelle.Parameters.AddWithValue("@PerDogumYeri", txtDogumYeriKB.Text);
                guncelle.Parameters.AddWithValue("@PerUyruk", txtUyrukKB.Text);
                guncelle.Parameters.AddWithValue("@PerEhliyetS", dropSEhliyetKB.Text);
                guncelle.Parameters.AddWithValue("@PerDEhliyetAlis", DTEhliyetA.Value);
                guncelle.Parameters.AddWithValue("@PerCinsiyet", dropCinsiyetKB.Text);
                guncelle.Parameters.AddWithValue("@PerMail", txtEpostaKB.Text);
                guncelle.Parameters.AddWithValue("@PerTel", txtCepTelKB.Text);
                guncelle.Parameters.AddWithValue("@PerSicilNo", txtSicilNoKB.Text);
                guncelle.Parameters.AddWithValue("@PerSigaraK", dropSigaraKKB.Text);
                guncelle.Parameters.AddWithValue("@PerAskerlik", dropAskerlikKB.Text);
                guncelle.Parameters.AddWithValue("@PerIBAN", txtIBANKB.Text);
                guncelle.Parameters.AddWithValue("@PerKanGrubu", dropKanGrubuKB.Text);
                guncelle.Parameters.AddWithValue("@PerMedeniHali", dropMedeniHalKB.Text);
                guncelle.Parameters.AddWithValue("@PerIsTel", txtIsTelKB.Text);
                guncelle.Parameters.AddWithValue("@PerWpTel", txtWhatsAppTelKB.Text);
                
                guncelle.Parameters.AddWithValue("@Yakini1AdSoyad", txtYakiniadsoyad1.Text);
                guncelle.Parameters.AddWithValue("@Yakini1Tel", txtYakin1KB.Text);
                guncelle.Parameters.AddWithValue("@Yakini1Derece", txtYakinderece1.Text);
                guncelle.Parameters.AddWithValue("@Yakini2AdSoyad", txtYakiniadsoyad2.Text);
                guncelle.Parameters.AddWithValue("@Yakini2Tel", txtYakin2KB.Text);
                guncelle.Parameters.AddWithValue("@Yakini2Derece", txtYakinderece2.Text);
                guncelle.Parameters.AddWithValue("@SertifikaLisans1Ad", txtSertifika1.Text);
                guncelle.Parameters.AddWithValue("@SertifikaLisans1VerenKurum", txtSertverenkurum1.Text);
                guncelle.Parameters.AddWithValue("@SertifikaLisans1Tarihi", DTSertifikaT1.Text);
                guncelle.Parameters.AddWithValue("@SertifikaLisans2Ad", txtSertifika2.Text);
                guncelle.Parameters.AddWithValue("@SertifikaLisans2VerenKurum", txtSertverenkurum2.Text);
                guncelle.Parameters.AddWithValue("@SertifikaLisans2Tarihi", DTSertifikaT2.Text);
                guncelle.Parameters.AddWithValue("@YabanciDil1", txtYabanciDil1.Text);
                guncelle.Parameters.AddWithValue("@YabanciDil1Düzey", dropYabanciDilDuzey1.Text);
                guncelle.Parameters.AddWithValue("@YabanciDil2", txtYabanciDil2.Text);
                guncelle.Parameters.AddWithValue("@YabanciDil2Düzey", dropYabanciDilDuzey2.Text);
                guncelle.Parameters.AddWithValue("@YabanciDil3", txtYabanciDil3.Text);
                guncelle.Parameters.AddWithValue("@YabanciDil3Düzey", dropYabanciDilDuzey3.Text);
                guncelle.Parameters.AddWithValue("@IsYeri1", txtIsYeri1.Text);
                guncelle.Parameters.AddWithValue("@IsUnvan1", txtIsUnvan1.Text);
                guncelle.Parameters.AddWithValue("@IseGirisD1", dtIseGiris1.Value);
                guncelle.Parameters.AddWithValue("@IstenCikis1", dtIstenCikis1.Value);
                guncelle.Parameters.AddWithValue("@IstenAyrilis1", txtIsAyrilis1.Text);

                guncelle.Parameters.AddWithValue("@IsYeri2", txtIsYeri2.Text);
                guncelle.Parameters.AddWithValue("@IsUnvan2", txtIsUnvan2.Text);
                guncelle.Parameters.AddWithValue("@IseGirisD2", dtIseGiris2.Value);
                guncelle.Parameters.AddWithValue("@IstenCikis2", dtIstenCikis2.Value);
                guncelle.Parameters.AddWithValue("@IstenAyrilis2", txtIsAyrilis2.Text);

                guncelle.Parameters.AddWithValue("@IsYeri3", txtIsYeri3.Text);
                guncelle.Parameters.AddWithValue("@IsUnvan3", txtIsUnvan3.Text);
                guncelle.Parameters.AddWithValue("@IseGirisD3", dtIseGiris3.Value);
                guncelle.Parameters.AddWithValue("@IstenCikis3", dtIstenCikis3.Value);
                guncelle.Parameters.AddWithValue("@IstenAyrilis3", txtIsAyrilis3.Text);

                guncelle.Parameters.AddWithValue("@IsYeri4", txtIsYeri4.Text);
                guncelle.Parameters.AddWithValue("@IsUnvan4", txtIsUnvan4.Text);
                guncelle.Parameters.AddWithValue("@IseGirisD4", dtIseGiris4.Value);
                guncelle.Parameters.AddWithValue("@IstenCikis4", dtIstenCikis4.Value);
                guncelle.Parameters.AddWithValue("@IstenAyrilis4", txtIsAyrilis4.Text);
                guncelle.ExecuteNonQuery();

                
            }
            catch 
            {

                
            }
        }

        string tcknkb;
        public void btnPerEkleKB_Click(object sender, EventArgs e)
        {
            //TCKİMLİK KONTROLÜ
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand sqlkayitk = new SqlCommand("select * from Personnels where PerTckn=@PerTckn",baglan);
            sqlkayitk.Parameters.AddWithValue("@PerTckn", txtTcknKB.Text);
            SqlDataReader kayitokuma = sqlkayitk.ExecuteReader();
            while(kayitokuma.Read())
            {
                kayitkontrol = true;
                break;
            }
            if (kayitkontrol==false)
            {
                if(txtTcknKB.Text.Length<11 || txtTcknKB.Text=="")
                {
                    this.Alert("Kimlik Numarası Girişi Hatalı", Form_Alert.enmType.Warning);
                    txtTcknKB.Clear();
                }
                else
                {
                    //try
                    //{
                        YokEkle();
                        Depidcek();
                        this.Alert("Personel ekleme başarılı", Form_Alert.enmType.Success);
                        this.Close();
                        PersonelList perlist = new PersonelList();
                        perlist.searchyenile();
                    //}
                    //catch
                    //{
                    //    this.Alert("Bir şeyler ters gitti", Form_Alert.enmType.Error);
                   // }
                }  
            }
            else if(kayitkontrol == true)
            {
                this.Alert("Kimlik Numarası Zaten Kayıtlı", Form_Alert.enmType.Warning);
            }

            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        public void btnguncellegizle()
        {
            btnPerEkleKB.Visible = true;
            btnPersonnelGuncelleKB.Visible=false;
        }

        int eklemeid = 0;
        int depid = 0;
        int adresid = 0;
        int mesaiid = 0;
        int egitimbilgisiid = 0;
        public void Depidcek()
        {
            
            if (String.IsNullOrEmpty(txtAdKB.Text) || String.IsNullOrEmpty(txtSoyadKB.Text) || String.IsNullOrEmpty(txtDogumYeriKB.Text) || String.IsNullOrEmpty(DTDogumTarihiKB.Text) || String.IsNullOrEmpty(dropCinsiyetKB.Text) || String.IsNullOrEmpty(txtUyrukKB.Text) || String.IsNullOrEmpty(dropSEhliyetKB.Text) || String.IsNullOrEmpty(DTEhliyetA.Text) || String.IsNullOrEmpty(txtTcknKB.Text) || String.IsNullOrEmpty(dropKanGrubuKB.Text) || String.IsNullOrEmpty(dropMedeniHalKB.Text) || String.IsNullOrEmpty(dropSigaraKKB.Text) || String.IsNullOrEmpty(txtSicilNoKB.Text) || String.IsNullOrEmpty(DropKBDepDoldurKB.Text) || String.IsNullOrEmpty(txtRolKB.Text) || String.IsNullOrEmpty(txtEpostaKB.Text) || String.IsNullOrEmpty(dropAskerlikKB.Text) || String.IsNullOrEmpty(txtIBANKB.Text) || String.IsNullOrEmpty(txtCepTelKB.Text) || String.IsNullOrEmpty(txtEvAdresi.Text) || String.IsNullOrEmpty(txtUlkeKB.Text) || String.IsNullOrEmpty(txtSehirKB.Text))
            {
                //this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand commandpersonnelid = new SqlCommand("SELECT TOP 1 id FROM Personnels ORDER BY id DESC", baglan);
                commandpersonnelid.ExecuteScalar();
                SqlDataReader reader2 = commandpersonnelid.ExecuteReader();

                // Verileri işle
                while (reader2.Read())
                {
                    eklemeid = reader2.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader2.Close();
                

                
                SqlCommand commanddepid = new SqlCommand("SELECT TOP 1 id FROM Departmans ORDER BY id DESC", baglan);
                commanddepid.ExecuteScalar();
                SqlDataReader reader = commanddepid.ExecuteReader();

                // Verileri işle
                while (reader.Read())
                {
                    depid = reader.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader.Close();

                SqlCommand commanddepidal = new SqlCommand("update Personnels set Departmanid=@Departmanid where id=@Eklemeid", baglan);
                commanddepidal.Parameters.AddWithValue("@Departmanid", depid);
                commanddepidal.Parameters.AddWithValue("@Eklemeid", eklemeid);
                commanddepidal.ExecuteNonQuery();
                

                
                SqlCommand commandadresid = new SqlCommand("SELECT TOP 1 id FROM Adreses ORDER BY id DESC", baglan);
                commandadresid.ExecuteScalar();
                SqlDataReader reader1 = commandadresid.ExecuteReader();

                // Verileri işle
                while (reader1.Read())
                {
                    adresid = reader1.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader1.Close();

                SqlCommand commandadresidal = new SqlCommand("update Personnels set Adresid=@Adresid where id=@Eklemeid", baglan);
                commandadresidal.Parameters.AddWithValue("@Adresid", adresid);
                commandadresidal.Parameters.AddWithValue("@Eklemeid", eklemeid);
                commandadresidal.ExecuteNonQuery();
                

                
                SqlCommand mesaitakvimiid = new SqlCommand("SELECT TOP 1 id FROM MesaiTakvimi ORDER BY id DESC", baglan);
                mesaitakvimiid.ExecuteScalar();
                SqlDataReader reader3 = mesaitakvimiid.ExecuteReader();

                // Verileri işle
                while (reader3.Read())
                {
                    mesaiid = reader3.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader3.Close();

                SqlCommand mesaiidekle = new SqlCommand("update Personnels set Mesaiid=@Mesaiid where id=@Eklemeid", baglan);
                mesaiidekle.Parameters.AddWithValue("@Mesaiid", mesaiid);
                mesaiidekle.Parameters.AddWithValue("@Eklemeid", eklemeid);
                mesaiidekle.ExecuteNonQuery();


                //egitim

                SqlCommand egitimiidal = new SqlCommand("SELECT TOP 1 id FROM Egitims ORDER BY id DESC", baglan);
                egitimiidal.ExecuteScalar();
                SqlDataReader reader4 = egitimiidal.ExecuteReader();

                // Verileri işle
                while (reader4.Read())
                {
                    egitimbilgisiid = reader4.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader4.Close();

                SqlCommand egitimidekle = new SqlCommand("update Personnels set PerEgitimBilgileri=@PerEgitimBilgileri where id=@Eklemeid", baglan);
                egitimidekle.Parameters.AddWithValue("@PerEgitimBilgileri", egitimbilgisiid);
                egitimidekle.Parameters.AddWithValue("@Eklemeid", eklemeid);
                egitimidekle.ExecuteNonQuery();
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }
        
        
        private void dropSEhliyetKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dropSEhliyetKB.Text == "Yok")
            {
                DTEhliyetA.Enabled = false;
                DTEhliyetA.Value = DTEhliyetA.MinDate;
            }
            else
            {
                DTEhliyetA.Enabled = true;
            }
        }
    }
}
