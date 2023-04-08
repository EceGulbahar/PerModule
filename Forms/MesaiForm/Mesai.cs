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

namespace PerModule.Forms.OzlukDosyasiRaporlariForm
{
    public partial class Mesai : Form
    {
        public DateTime? BaslangicSaati, BitisSaati, BaslangicTarihi, BitisTarihi;
        public int isiyapankullanici;
        public decimal MesaiSaatUcreti, Tutar;
        public string DonemAy, OdenmeDurumu, Aciklama, DonemYil;

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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

        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public Mesai()
        {
            InitializeComponent();
        }

        public int personid;
        private void Mesai_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= yil - 5; i--)
            {
                dropDonemYil.Items.Add(i);
            }

            //personeldrop
            dropPersonnel.Items.Clear();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand doldur = new SqlCommand("SELECT PerAd,PerSoyad,id FROM Personnels", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                dropPersonnel.Items.Add(dr[0] + " " + dr[1]);
                personid = dr.GetInt32(2);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }
        bool kayitaramadurumu = false;
        private void dropPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            if(dropPersonnel.Text!=null)
            {
                SqlCommand mesaisorgu = new SqlCommand("select Personnelid from Mesai where Personnelid=@personid", baglan);
                mesaisorgu.Parameters.AddWithValue("@personid", personid);
                SqlDataReader tcnosorguokuma = mesaisorgu.ExecuteReader();
                while (tcnosorguokuma.Read())
                {
                    kayitaramadurumu = true;
                    // tüm satırları seç
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Mesai where Personnelid=@id", baglan);
                    cmd.Parameters.AddWithValue("@id", personid);
                    SqlDataReader readercmd = cmd.ExecuteReader();

                    // satırları oku ve değişkenlere ata
                    while (readercmd.Read())
                    {
                        BaslangicSaati = readercmd.IsDBNull(readercmd.GetOrdinal("BaslangicSaati")) ? (DateTime?)null : (DateTime)readercmd["BaslangicSaati"];
                        BitisSaati = readercmd.IsDBNull(readercmd.GetOrdinal("BitisSaati")) ? (DateTime?)null : (DateTime)readercmd["BitisSaati"];
                        isiyapankullanici = readercmd.IsDBNull(readercmd.GetOrdinal("KullaniciID")) ? 0 : int.Parse(readercmd["KullaniciID"].ToString());
                        MesaiSaatUcreti = readercmd.IsDBNull(readercmd.GetOrdinal("MesaiSaatUcreti")) ? 0 : (decimal)readercmd["MesaiSaatUcreti"];
                        Tutar = readercmd.IsDBNull(readercmd.GetOrdinal("Tutar")) ? 0 : (decimal)readercmd["Tutar"];
                        DonemAy = readercmd.IsDBNull(readercmd.GetOrdinal("DonemAy")) ? null : (string)readercmd["DonemAy"];
                        DonemYil = readercmd.IsDBNull(readercmd.GetOrdinal("DonemYil")) ? null : (string)readercmd["DonemYil"];
                        OdenmeDurumu = (string)readercmd["OdenmeDurumu"];
                        Aciklama = readercmd.IsDBNull(readercmd.GetOrdinal("Aciklama")) ? null : (string)readercmd["Aciklama"];
                        BaslangicTarihi = readercmd.IsDBNull(readercmd.GetOrdinal("BaslangicTarihi")) ? (DateTime?)null : (DateTime)readercmd["BaslangicTarihi"];
                        BitisTarihi = readercmd.IsDBNull(readercmd.GetOrdinal("BitisTarihi")) ? (DateTime?)null : (DateTime)readercmd["BitisTarihi"];
                    }
                    DTBaslangicTarihi.Text = BaslangicTarihi.ToString();
                    DTBitisTarihi.Text = BitisTarihi.ToString();
                    DTSaatBaslangic.Text = BaslangicSaati.ToString();
                    DTSaatBitis.Text = BitisSaati.ToString();
                    txtSaatlik.Text = MesaiSaatUcreti.ToString();
                    txtTutar.Text = Tutar.ToString();
                    dropDonemAy.Text = DonemAy;
                    dropDonemYil.Text = DonemYil;
                    txtAciklama.Text = Aciklama;
                }
            }
                if (kayitaramadurumu == false)
                {
                    this.Alert("Personelin Mesaisi Bulunmuyor", Form_Alert.enmType.Info);
                }
            }
            
    }
}
