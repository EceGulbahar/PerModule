using PerModule.Forms.PersonelListForm;
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
using PerModule.Forms.LoginForm;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Documents;

namespace PerModule.Forms.OzlukDosyasiRaporlariForm
{
    public partial class Mesai : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public DateTime?  Tarih;
        public int isiyapankullanici, DonemAy, DonemYil;
        public decimal MesaiSaatUcreti, Tutar;
        public string OdenmeDurumu, Aciklama,  BaslangicSaati, BitisSaati, MesaiTuru;

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnMesaiekle_Click(object sender, EventArgs e)
        {
            if (dropPersonnel.Text == null)
            {
                this.Alert("Personel Seçiniz", Form_Alert.enmType.Warning);
            }
            else
            {
                if (kayitaramadurumu == true)
                {
                    this.Alert("Personele Ait Mesai Zaten Bulunuyor", Form_Alert.enmType.Warning);
                    
                }
                else if (kayitaramadurumu == false)
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    //Numeric
                    
                    SqlCommand mesaiekle = new SqlCommand("insert into Mesai(KullaniciID,Personnelid,BaslangicSaati,BitisSaati,MesaiSaatUcreti,Tutar,DonemAy,DonemYil,OdenmeDurumu,Aciklama,Tarih,MesaiTuru) values(@KullaniciID,@Personnelid,@BaslangicSaati,@BitisSaati,@MesaiSaatUcreti,@Tutar,@DonemAy,@DonemYil,@OdenmeDurumu,@Aciklama,@Tarih,@MesaiTuru)", baglan);
                    mesaiekle.Parameters.AddWithValue("@KullaniciID", Login.kullanici);
                    mesaiekle.Parameters.AddWithValue("@Personnelid", personid);
                    mesaiekle.Parameters.AddWithValue("@BaslangicSaati", hbaslangic);
                    mesaiekle.Parameters.AddWithValue("@BitisSaati", hbitis);
                    mesaiekle.Parameters.AddWithValue("@MesaiSaatUcreti", MsaatUcreti);
                    mesaiekle.Parameters.AddWithValue("@Tutar", htutar);
                    mesaiekle.Parameters.AddWithValue("@DonemAy", Convert.ToInt32(dropDonemAy.Text));
                    mesaiekle.Parameters.AddWithValue("@DonemYil", Convert.ToInt32(dropDonemYil.Text));
                    mesaiekle.Parameters.AddWithValue("@OdenmeDurumu", "mesai eklendi,ödenmedi");
                    mesaiekle.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    mesaiekle.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    mesaiekle.Parameters.AddWithValue("@MesaiTuru", dropMesaiTuru.Text);
                    mesaiekle.ExecuteNonQuery();
                    this.Alert("Mesai Ekleme Başarılı", Form_Alert.enmType.Success);
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }
        public double MsaatUcreti;
        public double htutar;
        string hbaslangic;
        string hbitis;
        public void txtSaatlik_TextChanged(object sender, EventArgs e)
        {
            if(DTBaslangicTarihi.Text!= null && DTBitisTarihi.Text != null && DTSaatBaslangic.Text != null && DTSaatBitis.Text != null)
            {
                try
                {
                    hbaslangic = DTBaslangicTarihi.Text + " " + DTSaatBaslangic.Text;
                    hbitis = DTBitisTarihi.Text + " " + DTSaatBitis.Text;
                    TimeSpan saatfarki = DateTime.Parse(hbitis) - DateTime.Parse(hbaslangic);
                    MsaatUcreti = double.Parse(txtSaatlik.Text);
                    htutar = saatfarki.TotalHours * MsaatUcreti;
                    txtTutar.Text = htutar.ToString("0.00");
                }
                catch
                {
                    txtTutar.Text = null;
                }
            }
            else
            {
                txtTutar.Text = null;
                this.Alert("Tarihleri Ve Saatleri Boş Bırakamazsınız", Form_Alert.enmType.Success);
            }
        }

        private void txtSaatlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnMesaisil_Click(object sender, EventArgs e)
        {
            if(dropPersonnel.Text == null)
            {
                this.Alert("Personel Seçiniz", Form_Alert.enmType.Warning);
            }
            else
            {
                if(kayitaramadurumu==true)
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    SqlCommand deletemesai = new SqlCommand("DELETE FROM Mesai where Personnelid=@id", baglan);
                    deletemesai.Parameters.AddWithValue("@id", personid);
                    deletemesai.ExecuteNonQuery();
                    this.Alert("Mesai Silme Başarılı", Form_Alert.enmType.Success);
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
                else
                    this.Alert("Personele Ait Mesai Bulunmuyor", Form_Alert.enmType.Warning);
            }
        }

        
        public Mesai()
        {
            InitializeComponent();
        }

        int yil = DateTime.Now.Year;
        public int personid;
        public void Mesai_Load(object sender, EventArgs e)
        {
            for (int i = yil; i <= yil + 5; i++)
            {
                dropDonemYil.Items.Add(i);
            }

            //personeldrop
            dropPersonnel.Items.Clear();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand doldur = new SqlCommand("SELECT PerAd,PerSoyad FROM Personnels", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                dropPersonnel.Items.Add(dr[0] + " " + dr[1]);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

        }

        int say;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        int say1;
        bool kayitaramadurumu = false;
        string bolunenadi;
        string bolunsoyadi;
        //MESAİ TÜRÜ EKLENECEK
        private void dropPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropMesaiTuru.Text = " ";
            txtSaatlik.Text = " ";
            txtTutar.Text = " ";
            dropDonemAy.Text = " ";
            dropDonemYil.Text = " ";
            txtAciklama.Text = " ";
            DTBaslangicTarihi.Value = DateTime.Now;
            DTSaatBaslangic.Text = null;
            DTBitisTarihi.Value = DateTime.Now;
            DTSaatBitis.Text = null;
            kayitaramadurumu = false;
            if (dropPersonnel.Text != null)
            {
                string bol = dropPersonnel.Text;
                int bolsayi = bol.IndexOf(" ");
                bolunenadi = bol.Substring(0, bolsayi);
                bolunsoyadi = bol.Substring(bolsayi+1);       

                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand selectk = new SqlCommand("SELECT id FROM Personnels WHERE PerAd=@PerAd AND PerSoyad=@PerSoyad", baglan);
                selectk.Parameters.AddWithValue("@PerAd", bolunenadi.Trim());
                selectk.Parameters.AddWithValue("@PerSoyad", bolunsoyadi.Trim());
                SqlDataReader oku = selectk.ExecuteReader();
                if(oku.Read())
                {
                    personid = oku.GetInt32(oku.GetOrdinal("id"));
                    label11.Text = personid.ToString();
                }
                mesaicheck();
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
            

        }

        public void mesaicheck()
        {
            SqlCommand mesaisorgu = new SqlCommand("SELECT * from Mesai where Personnelid=@personid", baglan);
            mesaisorgu.Parameters.AddWithValue("@personid", personid);
            SqlDataReader mesaisorguokuma = mesaisorgu.ExecuteReader();
            while (mesaisorguokuma.Read())
            {
                kayitaramadurumu = true;
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mesai where Personnelid=@id", baglan);
                cmd.Parameters.AddWithValue("@id", personid);
                SqlDataReader readercmd = cmd.ExecuteReader();

                // satırları oku ve değişkenlere ata
                while (readercmd.Read())
                {
                    BaslangicSaati = readercmd.IsDBNull(readercmd.GetOrdinal("BaslangicSaati")) ? null : (string)readercmd["BaslangicSaati"];
                    BitisSaati = readercmd.IsDBNull(readercmd.GetOrdinal("BitisSaati")) ? null : (string)readercmd["BitisSaati"];
                    isiyapankullanici = readercmd.IsDBNull(readercmd.GetOrdinal("KullaniciID")) ? 0 : int.Parse(readercmd["KullaniciID"].ToString());
                    MesaiSaatUcreti = readercmd.IsDBNull(readercmd.GetOrdinal("MesaiSaatUcreti")) ? 0 : (decimal)readercmd["MesaiSaatUcreti"];
                    Tutar = readercmd.IsDBNull(readercmd.GetOrdinal("Tutar")) ? 0 : (decimal)readercmd["Tutar"];
                    DonemAy = (int)readercmd["DonemAy"];
                    DonemYil = (int)readercmd["DonemYil"];
                    OdenmeDurumu = (string)readercmd["OdenmeDurumu"];
                    Aciklama = readercmd.IsDBNull(readercmd.GetOrdinal("Aciklama")) ? null : (string)readercmd["Aciklama"];
                    Tarih = readercmd.IsDBNull(readercmd.GetOrdinal("Tarih")) ? (DateTime?)null : (DateTime)readercmd["Tarih"];
                    MesaiTuru = readercmd.IsDBNull(readercmd.GetOrdinal("MesaiTuru")) ? null : (string)readercmd["MesaiTuru"];
                }
                txtSaatlik.Text = MesaiSaatUcreti.ToString();
                dropMesaiTuru.Text = MesaiTuru;
                txtTutar.Text = Tutar.ToString();
                dropDonemAy.Text = DonemAy.ToString();
                dropDonemYil.Text = DonemYil.ToString();
                txtAciklama.Text = Aciklama;
                say = BaslangicSaati.IndexOf(" ");
                DTBaslangicTarihi.Text = BaslangicSaati.Substring(0, 10);
                DTSaatBaslangic.Text = BaslangicSaati.Substring(say + 1);
                say1 = BaslangicSaati.IndexOf(" ");
                DTBitisTarihi.Text = BitisSaati.Substring(0, 10);
                DTSaatBitis.Text = BitisSaati.Substring(say1 + 1);
                this.Alert("Personelin Mesaisi Bulunuyor", Form_Alert.enmType.Success);
            }
            if (kayitaramadurumu == false)
            {
                this.Alert("Personelin Mesaisi Bulunmuyor", Form_Alert.enmType.Info);
                txtSaatlik.Text = " ";
                txtTutar.Text = " ";
                dropDonemAy.Text = " ";
                dropDonemYil.Text = " ";
                txtAciklama.Text = " ";
                DTBaslangicTarihi.Value = DateTime.Now;
                DTSaatBaslangic.Text = null;
                DTBitisTarihi.Value = DateTime.Now;
                DTSaatBitis.Text = null;
                dropMesaiTuru.Text = " ";
            }
            
        }
    
    }
}
