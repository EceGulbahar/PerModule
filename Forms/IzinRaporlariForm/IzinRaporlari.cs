using PerModule.Forms.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.IzinRaporlariForm
{
    public partial class IzinRaporlari : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public DateTime? Tarih;
        public IzinRaporlari()
        {
            InitializeComponent();
        }

        private void IzinRaporlari_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'viewIzinDS.ViewIzin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.viewIzinTableAdapter.Fill(this.viewIzinDS.ViewIzin);
            searchyenile();
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

            label13.Text =IzinGridList.Rows.Count + " kayıt listelendi.";

            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        public DateTime? IzinBaslangic, IzinBitis;
        public int isiyapankullanici, izinid;
        public string Aciklama, IzinTuru, Islem;
        int say1,say;
        
        string bolunenadi;
        string bolunsoyadi;
        private void dropPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropIzinTuru.Text = " ";
            dropIzinTuru.Text = " ";
            txtAciklama.Text = " ";
            DTBaslangicTarihiIzin.Value = DateTime.Now;
            DTBitisTarihiIzin.Value = DateTime.Now;
            txtAciklama.Text = null;
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
                izincheck();


                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
                dt1.Clear();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand droppersonnel = new SqlCommand("SELECT * FROM dbo.ViewIzin where PerAd like '%" + bolunenadi + "%' AND PerSoyad like '%" + bolunsoyadi + "%'", baglan);
                SqlDataAdapter da1 = new SqlDataAdapter(droppersonnel);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                IzinGridList.DataSource = ds1.Tables[0];
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }

                label13.Text = IzinGridList.Rows.Count + " kayıt listelendi.";

            }
        }

        DataTable dt1 = new DataTable("IzinGridList");

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizleizin();
        }

        public void temizleizin()
        {
            dropPersonnel.Text = " ";
            dropIzinTuru.Text = " ";
            dropIzinTuru.Text = " ";
            txtAciklama.Text = " ";
            DTBaslangicTarihiIzin.Value = DateTime.Now;
            DTBitisTarihiIzin.Value = DateTime.Now;
            txtAciklama.Text = null;
        }

        string izinbasbos, izinbitbos;
        int izinbas, izinbit;

        private void btnIzinsil_Click(object sender, EventArgs e)
        {
            //izni bulunmayabilir.
            if (dropPersonnel.Text != null )
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
                izincheck();
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
            if (dropPersonnel.Text == null || dropIzinTuru.Text == null || txtAciklama.Text == null)
            {
                this.Alert("Gerekli bilgileri doldurunuz.", Form_Alert.enmType.Warning);
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                if(izinid ==0)
                {
                    this.Alert("Personele kayıtlı izin bulunmuyor", Form_Alert.enmType.Warning);
                }
                else
                {
                    SqlCommand deleteizin = new SqlCommand("DELETE FROM Izin where izinid=@izinid", baglan);
                    deleteizin.Parameters.AddWithValue("@izinid", izinid);
                    deleteizin.ExecuteNonQuery();
                    this.Alert("İzin Silme Başarılı", Form_Alert.enmType.Success);
                    searchyenile();
                    temizleizin();
                }
                
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }

            }
        }
        bool kayitaramadurumu = false;
        int secilendeger, izinidgrid;
        public string tcno, adi, soyadi, izinbitgrid, izinturugrid, aciklamagrid, izinbasgrid;


        public void tarihara()
        {
            dt1.Clear();
            DateTime startDate = bunifuDatePicker1.Value;
            DateTime endDate = bunifuDatePicker2.Value;

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }

            string query = "SELECT * FROM ViewIzin WHERE IzinBaslangic BETWEEN @startDate AND @endDate";
            SqlCommand command = new SqlCommand(query, baglan);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            IzinGridList.DataSource = dataTable;

            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            tarihara();
        }

        private void DTBaslangicTarihiIzin_ValueChanged(object sender, EventArgs e)
        {
            DateTime donemaysecim = DTBaslangicTarihiIzin.Value;
            int selectedMonth = donemaysecim.Month; // Seçilen tarihin ayını al
            switch (selectedMonth)
            {
                case 1:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 2:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 3:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 4:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 5:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 6:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 7:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 8:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 9:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 10:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 11:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                case 12:
                    donemaysecilen = 1;
                    // yapılacak işlemler
                    break;
                default:
                    // Hata işlemleri
                    break;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            searchyenile();
        }

        private void btnIzinGuncelle_Click(object sender, EventArgs e)
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
                    SqlCommand izinguncelle = new SqlCommand("UPDATE Izin SET KullaniciID=@KullaniciID,IzinBaslangic=@IzinBaslangic,IzinBitis=@IzinBitis,IzinTuru=@IzinTuru,Aciklama=@Aciklama,Islem=@Islem,Tarih=@Tarih,Saat=@Saat, DonemAy=DonemAy, DonemYil=@DonemYil where izinid=@izinid", baglan);
                    izinguncelle.Parameters.AddWithValue("@KullaniciID", Login.kullanici);
                    izinguncelle.Parameters.AddWithValue("@izinid", izinidgrid);
                    //izinidaldık
                    izinguncelle.Parameters.AddWithValue("@IzinBaslangic", DTBaslangicTarihiIzin.Value);
                    izinguncelle.Parameters.AddWithValue("@IzinBitis", DTBitisTarihiIzin.Value);
                    izinguncelle.Parameters.AddWithValue("@IzinTuru", dropIzinTuru.Text);
                    izinguncelle.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    izinguncelle.Parameters.AddWithValue("@Islem", dropPersonnel.Text + " için " + dropIzinTuru.Text + " oluşturuldu.");
                    izinguncelle.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    izinguncelle.Parameters.AddWithValue("@Saat", DateTime.Now);
                    izinguncelle.Parameters.AddWithValue("@DonemAy", donemaysecilen);
                    izinguncelle.Parameters.AddWithValue("@DonemYil", year);
                    this.Alert("İzin Güncelleme Başarılı", Form_Alert.enmType.Success);
                    searchyenile();
                    temizleizin();
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void IzinGridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilendeger = IzinGridList.SelectedCells[0].RowIndex;
            tcno = IzinGridList.Rows[secilendeger].Cells[0].Value.ToString(); //tckn değişkeni alıyoruz gridden
            adi = IzinGridList.Rows[secilendeger].Cells[1].Value.ToString();
            soyadi = IzinGridList.Rows[secilendeger].Cells[2].Value.ToString();
            izinturugrid = IzinGridList.Rows[secilendeger].Cells[3].Value.ToString();
            izinbasgrid = IzinGridList.Rows[secilendeger].Cells[4].Value.ToString();
            izinbitgrid = IzinGridList.Rows[secilendeger].Cells[5].Value.ToString();
            izinidgrid = Convert.ToInt16(IzinGridList.Rows[secilendeger].Cells[6].Value);
            aciklamagrid = IzinGridList.Rows[secilendeger].Cells[7].Value.ToString();
            
            
            dropPersonnel.Text = adi + " " + soyadi;
            dropIzinTuru.Text = izinturugrid;
            txtAciklama.Text = aciklamagrid;
            DTBaslangicTarihiIzin.Text = izinbasgrid;
            DTBitisTarihiIzin.Text = izinbitgrid;
            txtAciklama.Text = aciklamagrid;
        }

        DateTime donemaysecim, donemyilsecim;
        int donemaysecilen, donemyilsecilen;
        int year;
        private void btnIzinekle_Click(object sender, EventArgs e)
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
                

                DateTime selectedDate = DTBaslangicTarihiIzin.Value;
                year = selectedDate.Year;

                SqlCommand izinekle = new SqlCommand("insert into Izin(KullaniciID,Personnelid,IzinTuru,IzinBaslangic,IzinBitis,Islem,Aciklama,Tarih,Saat,DonemAy,DonemYil) values(@KullaniciID,@Personnelid,@IzinTuru,@IzinBaslangic,@IzinBitis,@Islem,@Aciklama,@Tarih,@Saat,@DonemAy,@DonemYil)", baglan);
                izinekle.Parameters.AddWithValue("@KullaniciID", Login.kullanici);
                izinekle.Parameters.AddWithValue("@Personnelid", personid);
                izinekle.Parameters.AddWithValue("@IzinBaslangic", DTBaslangicTarihiIzin.Value);
                izinekle.Parameters.AddWithValue("@IzinBitis", DTBitisTarihiIzin.Value);
                izinekle.Parameters.AddWithValue("@IzinTuru", dropIzinTuru.Text);
                izinekle.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                izinekle.Parameters.AddWithValue("@Islem", dropPersonnel.Text + " için " + dropIzinTuru.Text + " oluşturuldu.");
                izinekle.Parameters.AddWithValue("@Tarih", DateTime.Now);
                izinekle.Parameters.AddWithValue("@Saat", DateTime.Now);
                izinekle.Parameters.AddWithValue("@DonemAy", donemaysecilen);
                izinekle.Parameters.AddWithValue("@DonemYil", year);
                izinekle.ExecuteNonQuery();
                this.Alert("Izin Ekleme Başarılı", Form_Alert.enmType.Success);
                searchyenile();
                temizleizin();
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }


        //int yil = DateTime.Now.Year;
        public int personid;
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        DateTime ataturk = new DateTime(1938, 10, 10);

        public void searchyenile()
        {
            dt1.Clear();
            txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from ViewIzin", baglan))
            {
                dasearch.Fill(dt1);
                IzinGridList.DataSource = dt1;
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            txtSearchboxPerList.Clear();
        }

        private void txtSearchboxPerList_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchboxPerList.Text))
            {
                searchyenile();
            }
            else
            {
                dt1.Clear();
                txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand search = new SqlCommand("SELECT * FROM dbo.ViewIzin where PerAd like '%" + txtSearchboxPerList.Text + "%'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(search);
                DataSet ds = new DataSet();
                da.Fill(ds);
                IzinGridList.DataSource = ds.Tables[0];
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        public void izincheck()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand mesaisorgu = new SqlCommand("SELECT * from Izin where Personnelid=@personid", baglan);
            mesaisorgu.Parameters.AddWithValue("@personid", personid);
            SqlDataReader mesaisorguokuma = mesaisorgu.ExecuteReader();
            while (mesaisorguokuma.Read())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Izin where Personnelid=@id", baglan);
                cmd.Parameters.AddWithValue("@id", personid);
                SqlDataReader readercmd = cmd.ExecuteReader();

                // satırları oku ve değişkenlere ata
                while (readercmd.Read())
                {
                    izinid = (int)readercmd["izinid"];
                    IzinBaslangic = readercmd.IsDBNull(readercmd.GetOrdinal("IzinBaslangic")) ? (DateTime?)null : (DateTime)readercmd["IzinBaslangic"];
                    IzinBitis = readercmd.IsDBNull(readercmd.GetOrdinal("IzinBitis")) ? (DateTime?)null : (DateTime)readercmd["IzinBitis"];
                    isiyapankullanici = readercmd.IsDBNull(readercmd.GetOrdinal("KullaniciID")) ? 0 : int.Parse(readercmd["KullaniciID"].ToString());
                    Islem = (string)readercmd["Islem"];
                    Aciklama = readercmd.IsDBNull(readercmd.GetOrdinal("Aciklama")) ? null : (string)readercmd["Aciklama"];
                    Tarih = readercmd.IsDBNull(readercmd.GetOrdinal("Tarih")) ? (DateTime?)null : (DateTime)readercmd["Tarih"];
                    IzinTuru = readercmd.IsDBNull(readercmd.GetOrdinal("IzinTuru")) ? null : (string)readercmd["IzinTuru"];
                }
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }

        }
    }
}
