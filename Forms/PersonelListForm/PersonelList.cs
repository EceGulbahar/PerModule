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
using PerModule.Forms.DepartmanForm;


namespace PerModule.Forms.PersonelListForm
{
    public partial class PersonelList : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public PersonelList()
        {
            InitializeComponent();
            
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnExceleAl_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < GridHugeList.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = GridHugeList.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < GridHugeList.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridHugeList.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = GridHugeList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
                MessageBox.Show("Excele aktarma başarılı.");
            }
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

        void dropDepartmansDoldur()//TEMİZLEYİP YAPMALIYIZ
        {
            
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand doldur = new SqlCommand("SELECT DepAdi FROM Departmans", baglan);
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
            
            // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.Departmans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmansTableAdapter.Fill(this.pERSONNELMODULEDataSet.Departmans);
            // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
            dropDepartmansDoldur();

        }
        string tckn = "";
        int secilendeger;
        public void GridHugeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridHugeList.Columns[e.ColumnIndex].Name == "Kartlar")
            {
                
                secilendeger = GridHugeList.SelectedCells[0].RowIndex;
                tckn = GridHugeList.Rows[secilendeger].Cells[0].Value.ToString(); //tckn değişkeni alıyoruz gridden
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

        private void txtSearchboxPerList_TextChanged(object sender, EventArgs e)//Sadece isim arıyor, buraya sonra bakarım
        {
            if (String.IsNullOrEmpty(txtSearchboxPerList.Text))
            {
                this.departmansTableAdapter.Fill(this.pERSONNELMODULEDataSet.Departmans);
                // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
            }
            else
            {
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
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun!");
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand depguncelle = new SqlCommand("update Departmans set DepAdi=@YDepAdi where DepAdi=@DepAdi", baglan);
                depguncelle.Parameters.AddWithValue("@DepAdi", txtDepGuncelleDepAd.Text);
                depguncelle.Parameters.AddWithValue("@YDepAdi", txtDepGunYeniAd.Text);

                depguncelle.ExecuteNonQuery();
                if (depguncelle.ExecuteNonQuery() > 0)
                //MessageBox.Show("Güncelleme işlemi başarılı.");
                this.Alert("Güncelleme işlemi başarılı", Form_Alert.enmType.Success);
                this.departmansTableAdapter.Fill(this.pERSONNELMODULEDataSet.Departmans);
                // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
                dropDepartmansDoldur();
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
                    SqlCommand depdelete = new SqlCommand("DELETE  FROM Departmans where DepAdi=@DepAdi", baglan);
                    depdelete.Parameters.AddWithValue("@DepAdi", txtDepGuncelleDepAd.Text);
                    depdelete.ExecuteNonQuery();
                    if (depdelete.ExecuteNonQuery() > 0)
                        this.Alert("Departman silme işlemi başarılı", Form_Alert.enmType.Success);
                    this.departmansTableAdapter.Fill(this.pERSONNELMODULEDataSet.Departmans);
                    // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                    this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
                    dropDepartmansDoldur();
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }

        int a = 1;
        string personel = "PERSONEL";
        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDepSec.Text))
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun!");
            }
            else
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand depekle = new SqlCommand("insert into Departmans(DepAdi,DepRolu,Status) values(@DepAdii, @DepRolu, @Status)", baglan);
                depekle.Parameters.AddWithValue("@DepAdii", txtDepSec.Text);
                depekle.Parameters.AddWithValue("@DepRolu", personel);
                depekle.Parameters.AddWithValue("@Status", a);
                depekle.ExecuteNonQuery();
                if (depekle.ExecuteNonQuery() > 0)
                    this.Alert("Departman ekleme işlemi başarılı", Form_Alert.enmType.Success);
                this.departmansTableAdapter.Fill(this.pERSONNELMODULEDataSet.Departmans);
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }
    }
}
