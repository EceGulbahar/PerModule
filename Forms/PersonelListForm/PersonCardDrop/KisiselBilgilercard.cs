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

namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    public partial class KisiselBilgilercard : Form

    {
        int eklemeid = 0;
        int depid = 0;
        int adresid = 0;
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
            SqlCommand doldur = new SqlCommand("SELECT DepAdi FROM Departmans", baglan);
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
            DTSertifikaT.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT.Format = DateTimePickerFormat.Short;
            DTSertifikaT1.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT1.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT1.Format = DateTimePickerFormat.Short;
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

        private void btnPersonnelCikarKB_Click(object sender, EventArgs e)
        {

        }

        


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

                string sqlperekle = "insert into Personnels(PerTckn,PerAd,PerSoyad,PerDogumTarihi,PerDogumYeri,PerUyruk,PerEhliyetS,PerCinsiyet,PerMail,PerTel,PerKanGrubu,PerMedeniHali,PerSicilNo,PerBaslamaT,PerDEhliyetAlis,PerSigaraK,PerAskerlik,PerIBAN) values(@PerTckn,@PerAd,@PerSoyad,@PerDogumTarihi,@PerDogumYeri,@PerUyruk,@PerEhliyetS,@PerCinsiyet,@PerMail,@PerTel,@PerKanGrubu,@PerMedeniHali,@PerSicilNo,@PerBaslamaT,@PerDEhliyetAlis,@PerSigaraK,@PerAskerlik,@PerIBAN)";
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
                //perekle.Parameters.AddWithValue("@PerAdres", txtEvAdresi.Text);
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

                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
                //temizle();
                this.Hide();
            }

           }

        private void btnPersonnelGuncelleKB_Click(object sender, EventArgs e)
        {

        }

        private void btnPerEkleKB_Click(object sender, EventArgs e)
        {
            try
            {
                YokEkle();
                Depidcek();
                Adresidcek();
                this.Alert("Personel ekleme başarılı", Form_Alert.enmType.Success);
            }
            catch 
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
        }

        public void btnguncellegizle()
        {
            btnPerEkleKB.Visible = true;
            btnPersonnelGuncelleKB.Visible=false;
        }

        public void Depidcek()
        {
            DateTime dtbaslangictarihi = DateTime.Now;
            if (String.IsNullOrEmpty(txtAdKB.Text) || String.IsNullOrEmpty(txtSoyadKB.Text) || String.IsNullOrEmpty(txtDogumYeriKB.Text) || String.IsNullOrEmpty(DTDogumTarihiKB.Text) || String.IsNullOrEmpty(dropCinsiyetKB.Text) || String.IsNullOrEmpty(txtUyrukKB.Text) || String.IsNullOrEmpty(dropSEhliyetKB.Text) || String.IsNullOrEmpty(DTEhliyetA.Text) || String.IsNullOrEmpty(txtTcknKB.Text) || String.IsNullOrEmpty(dropKanGrubuKB.Text) || String.IsNullOrEmpty(dropMedeniHalKB.Text) || String.IsNullOrEmpty(dropSigaraKKB.Text) || String.IsNullOrEmpty(txtSicilNoKB.Text) || String.IsNullOrEmpty(DropKBDepDoldurKB.Text) || String.IsNullOrEmpty(txtRolKB.Text) || String.IsNullOrEmpty(txtEpostaKB.Text) || String.IsNullOrEmpty(dropAskerlikKB.Text) || String.IsNullOrEmpty(txtIBANKB.Text) || String.IsNullOrEmpty(txtCepTelKB.Text) || String.IsNullOrEmpty(txtEvAdresi.Text) || String.IsNullOrEmpty(txtUlkeKB.Text) || String.IsNullOrEmpty(txtSehirKB.Text))
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
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
                commanddepidal.Parameters.AddWithValue("@Eklemeid", depid);
                baglan.Close();
            }
        }

        public void Adresidcek()
        {
            DateTime dtbaslangictarihi = DateTime.Now;
            if (String.IsNullOrEmpty(txtAdKB.Text) || String.IsNullOrEmpty(txtSoyadKB.Text) || String.IsNullOrEmpty(txtDogumYeriKB.Text) || String.IsNullOrEmpty(DTDogumTarihiKB.Text) || String.IsNullOrEmpty(dropCinsiyetKB.Text) || String.IsNullOrEmpty(txtUyrukKB.Text) || String.IsNullOrEmpty(dropSEhliyetKB.Text) || String.IsNullOrEmpty(DTEhliyetA.Text) || String.IsNullOrEmpty(txtTcknKB.Text) || String.IsNullOrEmpty(dropKanGrubuKB.Text) || String.IsNullOrEmpty(dropMedeniHalKB.Text) || String.IsNullOrEmpty(dropSigaraKKB.Text) || String.IsNullOrEmpty(txtSicilNoKB.Text) || String.IsNullOrEmpty(DropKBDepDoldurKB.Text) || String.IsNullOrEmpty(txtRolKB.Text) || String.IsNullOrEmpty(txtEpostaKB.Text) || String.IsNullOrEmpty(dropAskerlikKB.Text) || String.IsNullOrEmpty(txtIBANKB.Text) || String.IsNullOrEmpty(txtCepTelKB.Text) || String.IsNullOrEmpty(txtEvAdresi.Text) || String.IsNullOrEmpty(txtUlkeKB.Text) || String.IsNullOrEmpty(txtSehirKB.Text))
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                baglan.Open();
                SqlCommand commandadresid = new SqlCommand("SELECT TOP 1 id FROM Adreses ORDER BY id DESC", baglan);
                commandadresid.ExecuteScalar();
                SqlDataReader reader = commandadresid.ExecuteReader();

                // Verileri işle
                while (reader.Read())
                {
                    adresid = reader.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader.Close();

                SqlCommand commandadresidal = new SqlCommand("update Personnels set Adresid=@Adresid where id=@Eklemeid", baglan);
                commandadresidal.Parameters.AddWithValue("@Adresid", adresid);
                commandadresidal.Parameters.AddWithValue("@Eklemeid", adresid);
                baglan.Close();
            }
        }

        public void Eklemeidcek()
        {
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
                SqlDataReader reader = commandpersonnelid.ExecuteReader();

                // Verileri işle
                while (reader.Read())
                {
                    eklemeid = reader.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader.Close();
                baglan.Close();
            }
        }
    }
}
