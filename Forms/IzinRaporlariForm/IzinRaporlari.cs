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
            searchyenile();
            // TODO: Bu kod satırı 'viewIzinDS.ViewIzin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.viewIzinTableAdapter.Fill(this.viewIzinDS.ViewIzin);
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


        public int isiyapankullanici, izinid;
        public string Aciklama, IzinBaslangic, IzinBitis, IzinTuru, Islem, MesaiTuru;
        int say1;
        
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

        DataTable dt = new DataTable("IzinGridList");

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dropIzinTuru.Text = " ";
            dropIzinTuru.Text = " ";
            txtAciklama.Text = " ";
            DTBaslangicTarihiIzin.Value = DateTime.Now;
            DTBitisTarihiIzin.Value = DateTime.Now;
            txtAciklama.Text = null;
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
            dt.Clear();
            txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from ViewIzin", baglan))
            {
                dasearch.Fill(dt);
                IzinGridList.DataSource = dt;
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
                dt.Clear();
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

        public void mesaicheck()
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
                    IzinBaslangic = readercmd.IsDBNull(readercmd.GetOrdinal("IzinBaslangic")) ? null : (string)readercmd["IzinBaslangic"];
                    IzinBitis = readercmd.IsDBNull(readercmd.GetOrdinal("IzinBitis")) ? null : (string)readercmd["IzinBitis"];
                    isiyapankullanici = readercmd.IsDBNull(readercmd.GetOrdinal("KullaniciID")) ? 0 : int.Parse(readercmd["KullaniciID"].ToString());
                    Islem = (string)readercmd["Islem"];
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
