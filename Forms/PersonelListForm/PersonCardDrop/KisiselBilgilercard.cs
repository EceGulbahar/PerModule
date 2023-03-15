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

                string sqlperekle = "insert into Personnels(PerTckn,PerAd,PerSoyad,PerDogumTarihi,PerDogumYeri,PerUyruk,PerEhliyetS,PerCinsiyet,PerMail,PerTel,PerKanGrubu,PerMedeniHali,PerSicilNo,PerBaslamaT,PerDEhliyetAlis,PerSigaraK,PerAskerlik,PerIBAN,PerYetki,PerIsTel,PerWpTel,Yakini1AdSoyad,Yakini1Tel,Yakini1Derece,Yakini2AdSoyad,Yakini2Tel,Yakini2Derece,SertifikaLisans1Ad,SertifikaLisans1VerenKurum,SertifikaLisans1Tarihi,SertifikaLisans2Ad,SertifikaLisans2VerenKurum,SertifikaLisans2Tarihi) " +
                    "values(@PerTckn,@PerAd,@PerSoyad,@PerDogumTarihi,@PerDogumYeri,@PerUyruk,@PerEhliyetS,@PerCinsiyet,@PerMail,@PerTel,@PerKanGrubu,@PerMedeniHali,@PerSicilNo,@PerBaslamaT,@PerDEhliyetAlis,@PerSigaraK,@PerAskerlik,@PerIBAN,@PerYetki,@PerIsTel,@PerWpTel,@Yakini1AdSoyad,@Yakini1Tel,@Yakini1Derece,@Yakini2AdSoyad,@Yakini2Tel,@Yakini2Derece,@SertifikaLisans1Ad,@SertifikaLisans1VerenKurum,@SertifikaLisans1Tarihi,@SertifikaLisans2Ad,@SertifikaLisans2VerenKurum,@SertifikaLisans2Tarihi)";
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
                perekle.Parameters.AddWithValue("@PerBaslamaT", dtbaslangictarihi);
                perekle.Parameters.AddWithValue("@PerBaslamaT", dtbaslangictarihi);
                perekle.Parameters.AddWithValue("@PerBaslamaT", dtbaslangictarihi);

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
