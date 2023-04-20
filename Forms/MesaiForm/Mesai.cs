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
using PerModule.Forms.DepartmanForm;
using Bunifu.UI.WinForms;

namespace PerModule.Forms.OzlukDosyasiRaporlariForm
{
    public partial class Mesai : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public DateTime?  Tarih;
        public int isiyapankullanici, DonemAy, DonemYil,mesaiidode;
        public decimal MesaiSaatUcreti, Tutar;
        public string OdenmeDurumu, Aciklama,  BaslangicSaati, BitisSaati, MesaiTuru;

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        DateTime ataturk = new DateTime(1938, 10, 10);
        private void btnMesaiekle_Click(object sender, EventArgs e)
        {
            if (dropPersonnel.Text == null)
            {
                this.Alert("Personel Seçiniz", Form_Alert.enmType.Warning);
            }
            else
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
                    mesaiekle.Parameters.AddWithValue("@OdenmeDurumu", "Ödenmedi");
                    mesaiekle.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    mesaiekle.Parameters.AddWithValue("@Tarih", ataturk);
                    mesaiekle.Parameters.AddWithValue("@MesaiTuru", dropMesaiTuru.Text);
                    mesaiekle.ExecuteNonQuery();
                    this.Alert("Mesai Ekleme Başarılı", Form_Alert.enmType.Success);
                    searchyenile();
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
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
            if (dropPersonnel.Text != null)
            {
                string bol = dropPersonnel.Text;
                int bolsayi = bol.IndexOf(" ");
                bolunenadi = bol.Substring(0, bolsayi);
                bolunsoyadi = bol.Substring(bolsayi + 1);

                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand selectk = new SqlCommand("SELECT id FROM Personnels WHERE PerAd=@PerAd AND PerSoyad=@PerSoyad", baglan);
                selectk.Parameters.AddWithValue("@PerAd", bolunenadi.Trim());
                selectk.Parameters.AddWithValue("@PerSoyad", bolunsoyadi.Trim());
                SqlDataReader oku = selectk.ExecuteReader();
                if (oku.Read())
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
            if (dropPersonnel.Text == null)
            {
                this.Alert("Personel Seçiniz", Form_Alert.enmType.Warning);
            }
            else
            {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    
                    SqlCommand deletemesai = new SqlCommand("DELETE FROM Mesai where Personnelid=@id and Mesaiid=@Mesaiid", baglan);
                    deletemesai.Parameters.AddWithValue("@id", personid);
                    deletemesai.Parameters.AddWithValue("@Mesaiid", mesaiidode);
                    deletemesai.ExecuteNonQuery();
                    this.Alert("Mesai Silme Başarılı", Form_Alert.enmType.Success);
                    searchyenile();
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                
            }
        }

        
        public Mesai()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable("MesaiGridList");
        int yil = DateTime.Now.Year;
        public int personid;
        public void Mesai_Load(object sender, EventArgs e)
        {
            searchyenile();
            // TODO: Bu kod satırı 'viewMesaiDS.ViewMesai' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.viewMesaiTableAdapter.Fill(this.viewMesaiDS.ViewMesai);
            
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

            label13.Text = MesaiGridList.Rows.Count + " kayıt listelendi.";

            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

            

        }

        public void searchyenile()
        {
            dt.Clear();
            txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from ViewMesai", baglan))
            {
                dasearch.Fill(dt);
                MesaiGridList.DataSource = dt;
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            txtSearchboxPerList.Clear();
        }

        int say;

        private void txtSearchboxPerList_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchboxPerList.Text))
            {
                searchyenile();
            }
            else
            {
                dt.Clear();
                txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand search = new SqlCommand("SELECT * FROM dbo.ViewMesai where PerAd like '%" + txtSearchboxPerList.Text + "%'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(search);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MesaiGridList.DataSource = ds.Tables[0];
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        
        public string tcno, adi, soyadi, baslangictarihsaati, bitistarihsaati, odenmedurumugrid, aciklamagrid, mesaiturugrid;

        private void btnYenile_Click(object sender, EventArgs e)
        {
            searchyenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
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
                    say = BaslangicSaati.IndexOf(" ");
                    DTBaslangicTarihi.Text = BaslangicSaati.Substring(0, 10);
                    DTSaatBaslangic.Text = BaslangicSaati.Substring(say + 1);
                    say1 = BitisSaati.IndexOf(" ");
                    DTBitisTarihi.Text = BitisSaati.Substring(0, 10);
                    DTSaatBitis.Text = BitisSaati.Substring(say1 + 1);
                    SqlCommand mesaiguncelle = new SqlCommand("UPDATE Mesai SET KullaniciID=@KullaniciID,BaslangicSaati=@BaslangicSaati,BitisSaati=@BitisSaati,MesaiSaatUcreti=@MesaiSaatUcreti,Tutar=@Tutar,DonemAy=@DonemAy,DonemYil=@DonemYil,OdenmeDurumu=@OdenmeDurumu,Aciklama=@Aciklama,Tarih=@Tarih,MesaiTuru=@MesaiTuru where Mesaiid=@Mesaiid", baglan);
                    mesaiguncelle.Parameters.AddWithValue("@KullaniciID", Login.kullanici);
                    mesaiguncelle.Parameters.AddWithValue("@Mesaiid", mesaiidode);
                    //mesaiid çekmeliyiz
                    mesaiguncelle.Parameters.AddWithValue("@BaslangicSaati", hbaslangic);
                    mesaiguncelle.Parameters.AddWithValue("@BitisSaati", hbitis);
                    mesaiguncelle.Parameters.AddWithValue("@MesaiSaatUcreti", MsaatUcreti);
                    mesaiguncelle.Parameters.AddWithValue("@Tutar", htutar);
                    mesaiguncelle.Parameters.AddWithValue("@DonemAy", Convert.ToInt32(dropDonemAy.Text));
                    mesaiguncelle.Parameters.AddWithValue("@DonemYil", Convert.ToInt32(dropDonemYil.Text));
                    mesaiguncelle.Parameters.AddWithValue("@OdenmeDurumu", "Ödenmedi");
                    mesaiguncelle.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    mesaiguncelle.Parameters.AddWithValue("@Tarih", ataturk);
                    mesaiguncelle.Parameters.AddWithValue("@MesaiTuru", dropMesaiTuru.Text);
                    mesaiguncelle.ExecuteNonQuery();
                    this.Alert("Mesai Güncelleme Başarılı", Form_Alert.enmType.Success);
                    searchyenile();
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void MesaiGridList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilendeger = MesaiGridList.SelectedCells[0].RowIndex;
            tcno = MesaiGridList.Rows[secilendeger].Cells[0].Value.ToString(); //tckn değişkeni alıyoruz gridden
            adi = MesaiGridList.Rows[secilendeger].Cells[1].Value.ToString();
            soyadi = MesaiGridList.Rows[secilendeger].Cells[2].Value.ToString();
            baslangictarihsaati = MesaiGridList.Rows[secilendeger].Cells[3].Value.ToString();
            bitistarihsaati = MesaiGridList.Rows[secilendeger].Cells[4].Value.ToString();
            mesaisaatucretigrid = Convert.ToDecimal(MesaiGridList.Rows[secilendeger].Cells[5].Value);
            tutargrid = Convert.ToDecimal(MesaiGridList.Rows[secilendeger].Cells[6].Value);

            donemaygrid = Convert.ToInt32(MesaiGridList.Rows[secilendeger].Cells[7].Value);
            donemyilgrid = Convert.ToInt32(MesaiGridList.Rows[secilendeger].Cells[8].Value);
            odenmedurumugrid = MesaiGridList.Rows[secilendeger].Cells[9].Value.ToString();
            aciklamagrid = MesaiGridList.Rows[secilendeger].Cells[10].Value.ToString();
            mesaiturugrid = MesaiGridList.Rows[secilendeger].Cells[11].Value.ToString();
            mesaiidode = Convert.ToInt32(MesaiGridList.Rows[secilendeger].Cells[12].Value);
            dropPersonnel.Text = adi + " " + soyadi;
            txtSaatlik.Text = mesaisaatucretigrid.ToString();
            dropMesaiTuru.Text = mesaiturugrid;
            txtTutar.Text = tutargrid.ToString();
            dropDonemAy.Text = donemaygrid.ToString();
            dropDonemYil.Text = donemyilgrid.ToString();
            txtAciklama.Text = aciklamagrid;
            say = baslangictarihsaati.IndexOf(" ");
            DTBaslangicTarihi.Text = baslangictarihsaati.Substring(0, 10);
            DTSaatBaslangic.Text = baslangictarihsaati.Substring(say + 1);
            say1 = bitistarihsaati.IndexOf(" ");
            DTBitisTarihi.Text = bitistarihsaati.Substring(0, 10);
            DTSaatBitis.Text = bitistarihsaati.Substring(say1 + 1);
            
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            //3d1315
            string ode = "Ödendi";
            SqlCommand mesaiodesql = new SqlCommand("update Mesai set OdenmeDurumu=@OdenmeDurumu,Tarih=@Tarih where OdenmeDurumu='Ödenmedi' and Mesaiid=@Mesaiid", baglan);
            mesaiodesql.Parameters.AddWithValue("@OdenmeDurumu", ode);
            mesaiodesql.Parameters.AddWithValue("@Mesaiid", mesaiidode);
            mesaiodesql.Parameters.AddWithValue("@Tarih", DateTime.Now);
            mesaiodesql.ExecuteNonQuery();
            this.Alert("Personelin Mesaisi Ödenmiştir", Form_Alert.enmType.Success);
            searchyenile();
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            //3d1315
            string ode = "Ödendi";
            SqlCommand mesaiodesql1 = new SqlCommand("update Mesai set OdenmeDurumu=@OdenmeDurumu where OdenmeDurumu='Ödenmedi'", baglan);
            mesaiodesql1.Parameters.AddWithValue("@OdenmeDurumu", ode);
            mesaiodesql1.Parameters.AddWithValue("@Tarih", DateTime.Now);
            mesaiodesql1.ExecuteNonQuery();
            this.Alert("Mesaisi Ödenmeyenlerin Mesaisi Ödenmiştir", Form_Alert.enmType.Success);
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dropPersonnel.Text = "";
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
        }

        public decimal mesaisaatucretigrid, tutargrid;
        public int donemaygrid, donemyilgrid;

        int secilendeger;
        

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
                dt.Clear();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand droppersonnel = new SqlCommand("SELECT * FROM dbo.ViewMesai where PerAd like '%" + bolunenadi + "%' AND PerSoyad like '%" + bolunsoyadi +"%'", baglan);
                SqlDataAdapter da1 = new SqlDataAdapter(droppersonnel);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                MesaiGridList.DataSource = ds1.Tables[0];
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }

                label13.Text = MesaiGridList.Rows.Count + " kayıt listelendi.";

                decimal ttutar = 0;
                for (int i = 0; i < MesaiGridList.Rows.Count; i++)
                {
                    if (MesaiGridList.Rows[i].Cells[6] != null
                        && MesaiGridList.Rows[i].Cells[6].Value != null)
                    {
                        ttutar += decimal.Parse(MesaiGridList.Rows[i].Cells[6].Value.ToString());
                    }
                }
                lblToplamTutar.Text = ttutar.ToString("0.00") + " TL";
            }
            

        }

        public void mesaicheck()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand mesaisorgu = new SqlCommand("SELECT * from Mesai where Personnelid=@personid", baglan);
            mesaisorgu.Parameters.AddWithValue("@personid", personid);
            SqlDataReader mesaisorguokuma = mesaisorgu.ExecuteReader();
            while (mesaisorguokuma.Read())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mesai where Personnelid=@id", baglan);
                cmd.Parameters.AddWithValue("@id", personid);
                SqlDataReader readercmd = cmd.ExecuteReader();

                // satırları oku ve değişkenlere ata
                while (readercmd.Read())
                {
                    mesaiidode = (int)readercmd["Mesaiid"];
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
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

        }
    
    }
}
