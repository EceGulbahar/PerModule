using PerModule.Forms.AnasayfaForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
//güvenli şifre oluşturmak için
using System.IO;
//klasör denetmelek input output için
using PerModule.Forms.PersonelListForm;
using PerModule.Forms.PersonelListForm.PersonCardDrop;
using Point = System.Drawing.Point;
using System.IO.Ports;
using System.Reflection;
using DataTable = System.Data.DataTable;
using PerModule.Classes;

namespace PerModule.Forms.PersonelListForm
{
    public partial class PersonelList : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        bool kayitaramadurumu = false;

        public PersonelList()
        {
            InitializeComponent();
            
        }

        //Formlar arası veri aktarımında kullanılacak değişkenler
        public static string tcno, adi, soyadi, yetki, dogumtarihi, departmanı, rol, isegirist, bulke, bsehir;


        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnExceleAl_Click(object sender, EventArgs e)
        {
            ExceleAl.Excel_Disa_Aktar(GridHugeList);
            this.Alert("Excele aktarma başarılı", Form_Alert.enmType.Success);
        }
        
        private void DropDepartmans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDepartmans.Text == null)
            {
                txtDepGuncelleDepAd.Text = null;
            }
            else
                txtDepGuncelleDepAd.Text = DropDepartmans.Text;
        }

        private void btnDepEklePnlAc_Click(object sender, EventArgs e)
        {
            if(pnlDepEkle.Visible == false)
            {
                pnlDepEkle.Visible = true;
                txtDepSec.PlaceholderText = "Eklenecek departman adını giriniz.";
            }
            else
            {
                pnlDepEkle.Visible=false;
            }
        }

        void dropDepartmansDoldur()
        {
            DropDepartmans.Items.Clear();
            
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand doldur = new SqlCommand("SELECT Departmanlar FROM DepartmanDrop", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                DropDepartmans.Items.Add(dr[0]);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }
        private void PersonelList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
            dropDepartmansDoldur();
            txtTcnoAra.MaxLength = 11;
        }
        
        int secilendeger;
        public void GridHugeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridHugeList.Columns[e.ColumnIndex].Name == "Kartlar")
            {
                
                secilendeger = GridHugeList.SelectedCells[0].RowIndex;
                tcno = GridHugeList.Rows[secilendeger].Cells[0].Value.ToString(); //tckn değişkeni alıyoruz gridden
                adi = GridHugeList.Rows[secilendeger].Cells[1].Value.ToString();
                soyadi = GridHugeList.Rows[secilendeger].Cells[2].Value.ToString();
                dogumtarihi = GridHugeList.Rows[secilendeger].Cells[3].Value.ToString();
                departmanı = GridHugeList.Rows[secilendeger].Cells[4].Value.ToString();
                rol = GridHugeList.Rows[secilendeger].Cells[5].Value.ToString();
                isegirist = GridHugeList.Rows[secilendeger].Cells[6].Value.ToString();
                bulke = GridHugeList.Rows[secilendeger].Cells[7].Value.ToString();
                bsehir = GridHugeList.Rows[secilendeger].Cells[8].Value.ToString();
                PersonCard personCard = new PersonCard();
                personCard.Show();
            }
        }

        private void pnlDepEkle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KontrolPanelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Anasayfa anasayfa = new Anasayfa();
            FormGetir(anasayfa);
            //bu kısımda kaldık, tıklanmış gibi yapmayı deneyelim*/
        }

        
        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            BackModel backmodel = new BackModel();
            KisiselBilgilercard kisiselBilgilercard = new KisiselBilgilercard();
            kisiselBilgilercard.CikarGizle();
            kisiselBilgilercard.btnguncellegizle();
            kisiselBilgilercard.Size = new Size(1396, 900);
            kisiselBilgilercard.StartPosition = FormStartPosition.Manual;
            backmodel.FormBorderStyle = FormBorderStyle.None;
            kisiselBilgilercard.Location = new Point(400, 120);
            backmodel.Opacity = .50d;
            backmodel.BackColor = Color.Black;
            backmodel.Size =  new Size(1920, 1059);
            //backmodel.Location = new Point(114, 21);
            backmodel.ShowInTaskbar = false;
            backmodel.Show();
            kisiselBilgilercard.Owner = backmodel;
            kisiselBilgilercard.ShowDialog();
            backmodel.Dispose();

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            searchyenile();
        }

        private void btnTcnoAra_Click(object sender, EventArgs e)//tcno arama
        {
            
            if(txtTcnoAra.Text.Length==11)
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand tcnosorgu = new SqlCommand("select PerTckn from Personnels where PerTckn=@tcno", baglan);
                tcnosorgu.Parameters.AddWithValue("@tcno", txtTcnoAra.Text);
                SqlDataReader tcnosorguokuma = tcnosorgu.ExecuteReader();
                while(tcnosorguokuma.Read())
                {
                    kayitaramadurumu=true;
                    tcnosorgulama();
                }
                if(kayitaramadurumu==false)
                {
                    this.Alert("Kimlik Numarası Kayıtlı Değil!", Form_Alert.enmType.Info);
                }
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
            else
            {
                this.Alert("Kimlik Numarası 11 Haneli Olmalı!", Form_Alert.enmType.Warning);
                searchyenile();
            }
            
        }

        public void tcnosorgulama()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            dt.Clear();
            SqlCommand tcnogrid = new SqlCommand("SELECT * FROM dbo.PersonelListGridView where PerTckn like '%" + txtTcnoAra.Text + "%'", baglan);
            SqlDataAdapter datno = new SqlDataAdapter(tcnogrid);
            DataSet dstno = new DataSet();
            datno.Fill(dstno);
            GridHugeList.DataSource = dstno.Tables[0];
        }

        private void txtTcnoAra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnPerCikar_Click(object sender, EventArgs e)
        {
            BackModel backmodel = new BackModel();
            PerCikarma percikarcard = new PerCikarma();
            percikarcard.StartPosition = FormStartPosition.Manual;
            backmodel.FormBorderStyle = FormBorderStyle.None;
            percikarcard.Location = new Point(400, 120);
            backmodel.Opacity = .50d;
            backmodel.BackColor = Color.Black;
            backmodel.Size = new Size(1920, 1059);
            //backmodel.Location = new Point(114, 21);
            backmodel.ShowInTaskbar = false;
            backmodel.Show();
            percikarcard.Owner = backmodel;
            percikarcard.ShowDialog();
            backmodel.Dispose();
        }

        private void txtTcnoAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPdfCikar_Click(object sender, EventArgs e)
        {
            PDFcikar.pdfcikra(GridHugeList);
            this.Alert("PDF aktarma başarılı", Form_Alert.enmType.Success);
        }

        private void btnDepGuncelle_Click(object sender, EventArgs e)
        {
            if (pnlDepGuncelle.Visible == false)
            {
                pnlDepGuncelle.Visible = true;
                
                
            }
            else
            {
                pnlDepGuncelle.Visible = false;
            }
        }

        DataTable dt = new DataTable("GridHugeList");
        public void searchyenile()
        {
            dt.Clear();
            txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from personelListGridView", baglan))
            {
                dasearch.Fill(dt);
                GridHugeList.DataSource = dt;
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            txtSearchboxPerList.Clear();
        }
        private void txtSearchboxPerList_TextChanged(object sender, EventArgs e)//Sadece isim arıyor, buraya sonra bakarım
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
                SqlCommand search = new SqlCommand("SELECT * FROM dbo.PersonelListGridView where PerAd like '%" + txtSearchboxPerList.Text + "%'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(search);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridHugeList.DataSource = ds.Tables[0];
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void btnDepGuncelleLast_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDepGunYeniAd.Text) || String.IsNullOrEmpty(txtDepGuncelleDepAd.Text))
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand depguncelle = new SqlCommand("update DepartmanDrop set Departmanlar=@YDepAdi where Departmanlar=@Departmanlar", baglan);
                depguncelle.Parameters.AddWithValue("@Departmanlar", txtDepGuncelleDepAd.Text);
                depguncelle.Parameters.AddWithValue("@YDepAdi", txtDepGunYeniAd.Text);
                depguncelle.ExecuteNonQuery();
                SqlCommand depguncelledata = new SqlCommand("update Departmans set DepAdi=@YDepAdi1 where DepAdi=@DepAdi", baglan);
                depguncelledata.Parameters.AddWithValue("@DepAdi", txtDepGuncelleDepAd.Text);
                depguncelledata.Parameters.AddWithValue("@YDepAdi1", txtDepGunYeniAd.Text);
                depguncelledata.ExecuteNonQuery();
                this.Alert("Güncelleme işlemi başarılı", Form_Alert.enmType.Success);
                dropDepartmansDoldur();
                txtDepGunYeniAd.Clear();
                searchyenile();
                pnlDepGuncelle.Visible = false;
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
                
            }
        }

        private void btnDepGuncelIptal_Click(object sender, EventArgs e)
        {
            txtDepGuncelleDepAd.Text = null;
            txtDepGunYeniAd.Text = null;
            pnlDepGuncelle.Visible = false;
        }

        private void btnDepGuncelleDelete_Click(object sender, EventArgs e)
        {
            if(txtDepGuncelleDepAd != null)
            {
                DialogResult cevap = MessageBox.Show("Seçilen departmanı silmek istediğinizden emin misiniz?", "Departman Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    SqlCommand depdelete = new SqlCommand("DELETE  FROM DepartmanDrop where Departmanlar=@DepAdi", baglan);
                    depdelete.Parameters.AddWithValue("@DepAdi", txtDepGuncelleDepAd.Text);
                    
                    if (depdelete.ExecuteNonQuery() > 0)
                        this.Alert("Departman silme işlemi başarılı", Form_Alert.enmType.Success);
                    // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                    this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
                    dropDepartmansDoldur();
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
            else
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
        }

        public void btnDepEkle_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDepSec.Text))
            {
                this.Alert("Tüm alanları doldurduğunuzdan emin olun!", Form_Alert.enmType.Warning);
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand depekle = new SqlCommand("INSERT INTO DepartmanDrop(Departmanlar) VALUES(@Departmanlar)", baglan);
                depekle.Parameters.AddWithValue("@Departmanlar", txtDepSec.Text);
                
                if (depekle.ExecuteNonQuery() > 0)
                {
                    this.Alert("Departman ekleme işlemi başarılı", Form_Alert.enmType.Success);
                }
                dropDepartmansDoldur();
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Alert("Departman ekleme işlemi başarılı", Form_Alert.enmType.Success);
            searchyenile();
        }
    }
}
