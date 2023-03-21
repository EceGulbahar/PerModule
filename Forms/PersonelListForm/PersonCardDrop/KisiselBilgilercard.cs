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
            

            DateTime dtdogumtarihi = DateTime.Now;
            int yil = int.Parse(dtdogumtarihi.ToString("yyyy"));
            int ay = int.Parse(dtdogumtarihi.ToString("MM"));
            int gun = int.Parse(dtdogumtarihi.ToString("dd"));

            DTDogumTarihiKB.MinDate = new DateTime(1960,1,1);
            DTDogumTarihiKB.MaxDate = new DateTime(yil - 18, ay, gun);
            DTDogumTarihiKB.Format = DateTimePickerFormat.Short;
            DTEhliyetA.MinDate = new DateTime(1960, 1, 1);
            DTEhliyetA.MaxDate = new DateTime(yil - 18, ay, gun);
            DTEhliyetA.Format = DateTimePickerFormat.Short;
            DTSertifikaT1.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT1.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT1.Format = DateTimePickerFormat.Short;
            DTSertifikaT2.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT2.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT2.Format = DateTimePickerFormat.Short;
            DTSertifikaT1.Format = DateTimePickerFormat.Short;
            DTSertifikaT2.Format = DateTimePickerFormat.Short;

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            // tüm satırları seç
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personnels where PerTckn=@tckn", baglan);
            cmd.Parameters.AddWithValue("@tckn",tckn);
            SqlDataReader readercmd = cmd.ExecuteReader();

            // satırları oku ve değişkenlere ata
            while (readercmd.Read())
            {
                int personid = (int)readercmd["id"];
                string pertckn = (string)readercmd["PerTckn"];
                string adi = (string)readercmd["PerAd"];
                string soyadi = (string)readercmd["PerSoyad"];
                DateTime dogumtarihi = (DateTime)readercmd["PerDogumTarihi"];
                int maasid = (int)readercmd["PerMaas"];
                string cinsiyeti = (string)readercmd["PerCinsiyet"];
                string maili = (string)readercmd["PerMail"];
                string teli = (string)readercmd["PerTel"];
                string gorseli = readercmd.IsDBNull(readercmd.GetOrdinal("PerGorsel")) ? null : (string)readercmd["PerGorsel"];
                //boşsa null atadık yukarıda
                int egitimbilgileriid = (int)readercmd["PerEgitimBilgileri"];
                string kangrubu = (string)readercmd["PerKanGrubu"];
                string medenihali = (string)readercmd["PerMedeniHali"];
                int adresiid = (int)readercmd["Adresid"];
                DateTime isegirist = (DateTime)readercmd["PerBaslamaT"];
                DateTime? istenayrilist = readercmd.IsDBNull(readercmd.GetOrdinal("PerAyrilisT")) ? (DateTime?)null : (DateTime)readercmd["PerAyrilisT"];
                string ayrilmasebebi = readercmd.IsDBNull(readercmd.GetOrdinal("PerAyrilmaSebebi")) ? null : (string)readercmd["PerAyrilmaSebebi"];
                int depiid = (int)readercmd["Departmanid"];
                string nicki = (string)readercmd["PerNickName"];
                string sifresi = (string)readercmd["PerPassword"];
                string yetkisi = (string)readercmd["PerYetki"];
                string dogumyeri = (string)readercmd["PerDogumYeri"];
                string uyrugu = (string)readercmd["PerUyruk"];
                string ehliyetseviyesi = (string)readercmd["PerEhliyetS"];
                string sicilnosu = (string)readercmd["PerSicilNo"];
                DateTime? ehliyetalist = readercmd.IsDBNull(readercmd.GetOrdinal("PerDEhliyetAlis")) ? (DateTime?)null : (DateTime)readercmd["PerDEhliyetAlis"];
                string sigarasi = (string)readercmd["PerSigaraK"];
                string askerligi = (string)readercmd["PerAskerlik"];
                string ibani = (string)readercmd["PerIBAN"];
                int mesaisiid = (int)readercmd["Mesaiid"];
                string isteli = (string)readercmd["PerIsTel"];
                string wpteli = (string)readercmd["PerWpTel"];
                string yakini1adsoyadi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini1AdSoyad")) ? null : (string)readercmd["Yakini1AdSoyad"];
                string yakini1teli = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini1Tel")) ? null : (string)readercmd["Yakini1Tel"];
                string yakini1derecesi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini1Derece")) ? null : (string)readercmd["Yakini1Derece"];
                string yakini2adsoyadi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini2AdSoyad")) ? null : (string)readercmd["Yakini2AdSoyad"];
                string yakini2teli = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini2Tel")) ? null : (string)readercmd["Yakini2Tel"];
                string yakini2derecesi = readercmd.IsDBNull(readercmd.GetOrdinal("Yakini2Derece")) ? null : (string)readercmd["Yakini2Derece"];
                string sertifikasi1adi = (string)readercmd["SertifikaLisans1Ad"];
                string sertifikasi1kurum = (string)readercmd["SertifikaLisans1VerenKurum"];
                DateTime sertifikasi1tarihi = (DateTime)readercmd["SertifikaLisans1Tarihi"];
                string sertifikasi2adi = (string)readercmd["SertifikaLisans2Ad"];
                string sertifikasi2kurum = (string)readercmd["SertifikaLisans2VerenKurum"];
                DateTime sertifikasi2tarihi = (DateTime)readercmd["SertifikaLisans2Tarihi"];
                //dil bilmeyebilir burası düzeltilecek
                string yabanciDil1 = (string)readercmd["YabanciDil1"];
                string yabanciDil1Düzey = (string)readercmd["YabanciDil1Düzey"];
                string yabanciDil2 = (string)readercmd["YabanciDil2"];
                string yabanciDil2Düzey = (string)readercmd["YabanciDil2Düzey"];
                string yabanciDil3 = (string)readercmd["YabanciDil3"];
                string yabanciDil3Düzey = (string)readercmd["YabanciDil3Düzey"];
                string IsYeri1 = (string)readercmd["IsYeri1"];
                string IsUnvan1 = (string)readercmd["IsUnvan1"];
                DateTime IseGirisD1 = (DateTime)readercmd["IseGirisD1"];
                DateTime IstenCikis1 = (DateTime)readercmd["IstenCikis1"];
                string IstenAyrilis1 = (string)readercmd["IstenAyrilis1"];
                string IsYeri2 = (string)readercmd["IsYeri2"];
                string IsUnvan2 = (string)readercmd["IsUnvan2"];
                DateTime IseGirisD2 = (DateTime)readercmd["IseGirisD2"];
                DateTime IstenCikis2 = (DateTime)readercmd["IstenCikis2"];
                string IstenAyrilis2 = (string)readercmd["IstenAyrilis2"];
                string IsYeri3 = (string)readercmd["IsYeri3"];
                string IsUnvan3 = (string)readercmd["IsUnvan3"];
                DateTime IseGirisD3 = (DateTime)readercmd["IseGirisD3"];
                DateTime IstenCikis3 = (DateTime)readercmd["IstenCikis3"];
                string IstenAyrilis3 = (string)readercmd["IstenAyrilis3"];
                string IsYeri4 = (string)readercmd["IsYeri4"];
                string IsUnvan4 = (string)readercmd["IsUnvan4"];
                DateTime IseGirisD4 = (DateTime)readercmd["IseGirisD4"];
                DateTime IstenCikis4 = (DateTime)readercmd["IstenCikis4"];
                string IstenAyrilis4 = (string)readercmd["IstenAyrilis4"];
                // değişkenlerle yapılacak işlemler

            }
            // bağlantıyı kapat
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

        }
        public void kbdoldur()//eksik
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
                dropCinsiyetKB.Text = tcnokbokuma.GetValue(6).ToString();
                txtEpostaKB.Text = tcnokbokuma.GetValue(7).ToString();
                txtCepTelKB.Text = tcnokbokuma.GetValue(8).ToString();
                dropKanGrubuKB.Text = tcnokbokuma.GetValue(11).ToString();
                dropMedeniHalKB.Text = tcnokbokuma.GetValue(12).ToString();
                DTisegirist.Text = tcnokbokuma.GetValue(14).ToString();
                dropYetki.Text = tcnokbokuma.GetValue(20).ToString();
                txtDogumYeriKB.Text = tcnokbokuma.GetValue(21).ToString();
                txtUyrukKB.Text = tcnokbokuma.GetValue(22).ToString();
                dropSEhliyetKB.Text = tcnokbokuma.GetValue(23).ToString();
                txtSicilNoKB.Text = tcnokbokuma.GetValue(24).ToString();
                DTEhliyetA.Text = tcnokbokuma.GetValue(25).ToString();
                dropSigaraKKB.Text = tcnokbokuma.GetValue(26).ToString();
                dropAskerlikKB.Text = tcnokbokuma.GetValue(27).ToString();
                txtIBANKB.Text = tcnokbokuma.GetValue(28).ToString();

            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }
        public void kbvericek()
        {
            PersonelList.tcno = txtAdKB.Text;
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

        
        private void btnPersonnelCikarKB_Click(object sender, EventArgs e)//silme Çalışmıyor
        {
            string tckn = PersonelList.tcno;
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand persil = new SqlCommand("DELETE FROM Personnels where PerTckn=@tckn", baglan);
                persil.Parameters.AddWithValue("@tckn", tckn);
                persil.ExecuteNonQuery();
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
        public void YokEkle()
        {
            
            DateTime dtbaslangictarihi = DateTime.Now;
            
            if (String.IsNullOrEmpty(txtAdKB.Text) || String.IsNullOrEmpty(txtSoyadKB.Text) || String.IsNullOrEmpty(txtDogumYeriKB.Text) || String.IsNullOrEmpty(DTDogumTarihiKB.Text) || String.IsNullOrEmpty(dropCinsiyetKB.Text) || String.IsNullOrEmpty(txtUyrukKB.Text) || String.IsNullOrEmpty(dropSEhliyetKB.Text) || String.IsNullOrEmpty(DTEhliyetA.Text) || String.IsNullOrEmpty(txtTcknKB.Text) || String.IsNullOrEmpty(dropKanGrubuKB.Text) || String.IsNullOrEmpty(dropMedeniHalKB.Text) || String.IsNullOrEmpty(dropSigaraKKB.Text) || String.IsNullOrEmpty(txtSicilNoKB.Text) || String.IsNullOrEmpty(DropKBDepDoldurKB.Text) || String.IsNullOrEmpty(txtRolKB.Text) || String.IsNullOrEmpty(txtEpostaKB.Text) || String.IsNullOrEmpty(dropAskerlikKB.Text) || String.IsNullOrEmpty(txtIBANKB.Text) || String.IsNullOrEmpty(txtCepTelKB.Text) || String.IsNullOrEmpty(txtEvAdresi.Text) || String.IsNullOrEmpty(txtUlkeKB.Text) || String.IsNullOrEmpty(txtSehirKB.Text))
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                string sqlperekle = "insert into Personnels(PerTckn,PerAd,PerSoyad,PerDogumTarihi,PerDogumYeri,PerUyruk,PerEhliyetS,PerCinsiyet,PerMail,PerTel,PerKanGrubu,PerMedeniHali,PerSicilNo,PerBaslamaT,PerDEhliyetAlis,PerSigaraK,PerAskerlik,PerIBAN,PerYetki,PerIsTel,PerWpTel,Yakini1AdSoyad,Yakini1Tel,Yakini1Derece,Yakini2AdSoyad,Yakini2Tel,Yakini2Derece,SertifikaLisans1Ad,SertifikaLisans1VerenKurum,SertifikaLisans1Tarihi,SertifikaLisans2Ad,SertifikaLisans2VerenKurum,SertifikaLisans2Tarihi,YabanciDil1,YabanciDil1Düzey,YabanciDil2,YabanciDil2Düzey,YabanciDil3,YabanciDil3Düzey,IsYeri1,IsUnvan1,IseGirisD1,IstenCikis1,IstenAyrilis1,IsYeri2,IsUnvan2,IseGirisD2,IstenCikis2,IstenAyrilis2,IsYeri3,IsUnvan3,IseGirisD3,IstenCikis3,IstenAyrilis3,IsYeri4,IsUnvan4,IseGirisD4,IstenCikis4,IstenAyrilis4) " +
                    "values(@PerTckn,@PerAd,@PerSoyad,@PerDogumTarihi,@PerDogumYeri,@PerUyruk,@PerEhliyetS,@PerCinsiyet,@PerMail,@PerTel,@PerKanGrubu,@PerMedeniHali,@PerSicilNo,@PerBaslamaT,@PerDEhliyetAlis,@PerSigaraK,@PerAskerlik,@PerIBAN,@PerYetki,@PerIsTel,@PerWpTel,@Yakini1AdSoyad,@Yakini1Tel,@Yakini1Derece,@Yakini2AdSoyad,@Yakini2Tel,@Yakini2Derece,@SertifikaLisans1Ad,@SertifikaLisans1VerenKurum,@SertifikaLisans1Tarihi,@SertifikaLisans2Ad,@SertifikaLisans2VerenKurum,@SertifikaLisans2Tarihi,@YabanciDil1,@YabanciDil1Düzey,@YabanciDil2,@YabanciDil2Düzey,@YabanciDil3,@YabanciDil3Düzey,@IsYeri1,@IsUnvan1,@IseGirisD1,@IstenCikis1,@IstenAyrilis1,@IsYeri2,@IsUnvan2,@IseGirisD2,@IstenCikis2,@IstenAyrilis2,@IsYeri3,@IsUnvan3,@IseGirisD3,@IstenCikis3,@IstenAyrilis3,@IsYeri4,@IsUnvan4,@IseGirisD4,@IstenCikis4,@IstenAyrilis4)";
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
                perekle.Parameters.AddWithValue("@PerIBAN", txtIBANKB.Text);
                //perekle.Parameters.AddWithValue("@Departmanid", departmanid);
                perekle.Parameters.AddWithValue("@PerKanGrubu", dropKanGrubuKB.Text);
                perekle.Parameters.AddWithValue("@PerMedeniHali", dropMedeniHalKB.Text);
                perekle.Parameters.AddWithValue("@PerIsTel", txtIsTelKB.Text);
                perekle.Parameters.AddWithValue("@PerWpTel", txtWhatsAppTelKB.Text);
                perekle.Parameters.AddWithValue("@PerBaslamaT", dtbaslangictarihi);

                perekle.Parameters.AddWithValue("@Yakini1AdSoyad", txtYakiniadsoyad1.Text);
                perekle.Parameters.AddWithValue("@Yakini1Tel", txtYakin1KB.Text);
                perekle.Parameters.AddWithValue("@Yakini1Derece", txtYakinderece1.Text);
                perekle.Parameters.AddWithValue("@Yakini2AdSoyad", txtYakiniadsoyad2.Text);
                perekle.Parameters.AddWithValue("@Yakini2Tel", txtYakin2KB.Text);
                perekle.Parameters.AddWithValue("@Yakini2Derece", txtYakinderece2.Text);
                perekle.Parameters.AddWithValue("@SertifikaLisans1Ad", txtSertifika1.Text);
                perekle.Parameters.AddWithValue("@SertifikaLisans1VerenKurum", txtSertverenkurum1.Text);
                perekle.Parameters.AddWithValue("@SertifikaLisans1Tarihi", DTSertifikaT1.Text);
                perekle.Parameters.AddWithValue("@SertifikaLisans2Ad", txtSertifika2.Text);
                perekle.Parameters.AddWithValue("@SertifikaLisans2VerenKurum", txtSertverenkurum2.Text);
                perekle.Parameters.AddWithValue("@SertifikaLisans2Tarihi", DTSertifikaT2.Text);
                perekle.Parameters.AddWithValue("@YabanciDil1", txtYabanciDil1.Text);
                perekle.Parameters.AddWithValue("@YabanciDil1Düzey", dropYabanciDilDuzey1.Text);
                perekle.Parameters.AddWithValue("@YabanciDil2", txtYabanciDil2.Text);
                perekle.Parameters.AddWithValue("@YabanciDil2Düzey", dropYabanciDilDuzey2.Text);
                perekle.Parameters.AddWithValue("@YabanciDil3", txtYabanciDil3.Text);
                perekle.Parameters.AddWithValue("@YabanciDil3Düzey", dropYabanciDilDuzey3.Text);
                perekle.Parameters.AddWithValue("@IsYeri1", txtIsYeri1.Text);
                perekle.Parameters.AddWithValue("@IsUnvan1", txtIsUnvan1.Text);
                perekle.Parameters.AddWithValue("@IseGirisD1", dtIseGiris1.Value);
                perekle.Parameters.AddWithValue("@IstenCikis1", dtIstenCikis1.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis1", txtIsAyrilis1.Text);

                perekle.Parameters.AddWithValue("@IsYeri2", txtIsYeri2.Text);
                perekle.Parameters.AddWithValue("@IsUnvan2", txtIsUnvan2.Text);
                perekle.Parameters.AddWithValue("@IseGirisD2", dtIseGiris2.Value);
                perekle.Parameters.AddWithValue("@IstenCikis2", dtIstenCikis2.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis2", txtIsAyrilis2.Text);

                perekle.Parameters.AddWithValue("@IsYeri3", txtIsYeri3.Text);
                perekle.Parameters.AddWithValue("@IsUnvan3", txtIsUnvan3.Text);
                perekle.Parameters.AddWithValue("@IseGirisD3", dtIseGiris3.Value);
                perekle.Parameters.AddWithValue("@IstenCikis3", dtIstenCikis3.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis3", txtIsAyrilis3.Text);

                perekle.Parameters.AddWithValue("@IsYeri4", txtIsYeri4.Text);
                perekle.Parameters.AddWithValue("@IsUnvan4", txtIsUnvan4.Text);
                perekle.Parameters.AddWithValue("@IseGirisD4", dtIseGiris4.Value);
                perekle.Parameters.AddWithValue("@IstenCikis4", dtIstenCikis4.Value);
                perekle.Parameters.AddWithValue("@IstenAyrilis4", txtIsAyrilis4.Text);

                perekle.ExecuteNonQuery();

                string sqlperekledepartman = "insert into Departmans(DepAdi,DepRolu) values(@DepAdi,@DepRolu)";
                SqlCommand perekledepartman = new SqlCommand(sqlperekledepartman, baglan);
                perekledepartman.Parameters.AddWithValue("@DepAdi", DropKBDepDoldurKB.Text);
                perekledepartman.Parameters.AddWithValue("@DepRolu", txtRolKB.Text);
                perekledepartman.ExecuteNonQuery();

                string sqlperekleadres = "insert into Adreses(AdresUlke,AdresSehir,AdresEv) values(@AdresUlke,@AdresSehir,@AdresEv)";
                SqlCommand perekleadres = new SqlCommand(sqlperekleadres,baglan);
                perekleadres.Parameters.AddWithValue("@AdresUlke", txtUlkeKB.Text);
                perekleadres.Parameters.AddWithValue("@AdresSehir", txtSehirKB.Text);
                perekleadres.Parameters.AddWithValue("@AdresEv", txtEvAdresi.Text);
                perekleadres.ExecuteNonQuery();

                if (dropYetki.Text== "Kurucu")
                {
                    yetkikb = "Kurucu";
                }
                else if (dropYetki.Text == "Yetkili")
                {
                    yetkikb = "Yetkili";
                }
                if (dropYetki.Text == "Personel")
                {
                    yetkikb = "Personel";
                }
                perekle.Parameters.AddWithValue("@PerYetki", yetkikb);
                //mesai takvimi
                if(checkPzt.Checked==true)
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


                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
                //temizle();
            }
         }

        private void btnPersonnelGuncelleKB_Click(object sender, EventArgs e)
        {

        }

        public void varguncelle()
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
            baglan.Open();
            SqlCommand sqlkayitk = new SqlCommand("select * from Personnels where PerTckn=@PerTckn",baglan);
            sqlkayitk.Parameters.AddWithValue("@PerTckn", txtTcknKB.Text);
            SqlDataReader kayitokuma = sqlkayitk.ExecuteReader();
            while(kayitokuma.Read())
            {
                kayitkontrol = true;
                break;
            }
            baglan.Close();
            if(kayitkontrol==false)
            {
                if(txtTcknKB.Text.Length<11 || txtTcknKB.Text=="")
                {
                    this.Alert("Kimlik Numarası Girişi Hatalı", Form_Alert.enmType.Warning);
                    txtTcknKB.Clear();
                }
                else
                {
                    try
                    {
                        YokEkle();
                        Depidcek();
                        this.Alert("Personel ekleme başarılı", Form_Alert.enmType.Success);
                        this.Close();
                        PersonelList perlist = new PersonelList();
                        perlist.searchyenile();
                    }
                    catch
                    {
                        this.Alert("Bir şeyler ters gitti", Form_Alert.enmType.Error);
                    }
                }  
            }
            else if(kayitkontrol == true)
            {
                this.Alert("Kimlik Numarası Zaten Kayıtlı", Form_Alert.enmType.Warning);
            }

        }

        public void btnguncellegizle()
        {
            btnPerEkleKB.Visible = true;
            btnPersonnelGuncelleKB.Visible=false;
        }

        public void Depidcek()
        {
            int eklemeid = 0;
            int depid = 0;
            int adresid = 0;
            int mesaiid = 0;
            DateTime dtbaslangictarihi = DateTime.Now;
            if (String.IsNullOrEmpty(txtAdKB.Text) || String.IsNullOrEmpty(txtSoyadKB.Text) || String.IsNullOrEmpty(txtDogumYeriKB.Text) || String.IsNullOrEmpty(DTDogumTarihiKB.Text) || String.IsNullOrEmpty(dropCinsiyetKB.Text) || String.IsNullOrEmpty(txtUyrukKB.Text) || String.IsNullOrEmpty(dropSEhliyetKB.Text) || String.IsNullOrEmpty(DTEhliyetA.Text) || String.IsNullOrEmpty(txtTcknKB.Text) || String.IsNullOrEmpty(dropKanGrubuKB.Text) || String.IsNullOrEmpty(dropMedeniHalKB.Text) || String.IsNullOrEmpty(dropSigaraKKB.Text) || String.IsNullOrEmpty(txtSicilNoKB.Text) || String.IsNullOrEmpty(DropKBDepDoldurKB.Text) || String.IsNullOrEmpty(txtRolKB.Text) || String.IsNullOrEmpty(txtEpostaKB.Text) || String.IsNullOrEmpty(dropAskerlikKB.Text) || String.IsNullOrEmpty(txtIBANKB.Text) || String.IsNullOrEmpty(txtCepTelKB.Text) || String.IsNullOrEmpty(txtEvAdresi.Text) || String.IsNullOrEmpty(txtUlkeKB.Text) || String.IsNullOrEmpty(txtSehirKB.Text))
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                baglan.Open();
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
                baglan.Close();

                baglan.Open();
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
                baglan.Close();

                baglan.Open();
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
                baglan.Close();

                baglan.Open();
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
                baglan.Close();

            }
        }

    }
}
