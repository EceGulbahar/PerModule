
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    public partial class OnIzleme : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public OnIzleme()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnNotlarDuzenle_Click(object sender, EventArgs e)
        {
            if (txtNotlar.Enabled == false)
            {
                txtNotlar.Enabled = true;
                btnNotEkleLast.Visible = true;
                btnNotIptal.Visible = true;
            }
            else
            {
                txtNotlar.Enabled = false;
                btnNotEkleLast.Visible = false;
                btnNotIptal.Visible = false;
            }
        }

        private void btnNotIptal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNotEkleLast_Click(object sender, EventArgs e)
        {

        }

        private void OnIzleme_Load(object sender, EventArgs e)
        {

            gorselcek();
            grupAd.Text = PersonelList.adi + " " + PersonelList.soyadi;

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand tcnilekb = new SqlCommand("select * from Personnels where PerTckn=@tcno", baglan);
            tcnilekb.Parameters.AddWithValue("@tcno", PersonelList.tcno);
            SqlDataReader tcnokbokuma = tcnilekb.ExecuteReader();
            while (tcnokbokuma.Read())
            {
                lblKimlikNo.Text = tcnokbokuma.GetValue(1).ToString();
                grupAd.Text = tcnokbokuma.GetValue(2).ToString() + tcnokbokuma.GetValue(3).ToString();
                lblDogumT.Text = tcnokbokuma.GetValue(4).ToString().TrimEnd('0',':');
                lblEposta.Text = tcnokbokuma.GetValue(7).ToString();
                lblCepTel.Text = tcnokbokuma.GetValue(8).ToString();
                lblKanGrubu.Text = tcnokbokuma.GetValue(11).ToString();
                lblMedeniHal.Text = tcnokbokuma.GetValue(12).ToString();
                lblIsegirist.Text = tcnokbokuma.GetValue(14).ToString();
                lblYetki.Text = tcnokbokuma.GetValue(20).ToString();
                lblDogumYeri.Text = tcnokbokuma.GetValue(21).ToString();
                
                lblSurucuEh.Text = tcnokbokuma.GetValue(23).ToString();
                lblSicilNo.Text = tcnokbokuma.GetValue(24).ToString();
            }


            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        string tcno = PersonelList.tcno;
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\kullaniciresimler"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\kullaniciresimler");
            }

            // Resim dosyasını yükle
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog1.Title = "Resim Seç";
            //openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\resimyok.jpg");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyayı yükle
                string filePath = openFileDialog1.FileName;
                PerGorseli.ImageLocation = openFileDialog1.FileName;

                // Resim dosyasını kaydetmek için kaydetme yeri seçin
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
                saveFileDialog1.Title = "Kaydet";
                saveFileDialog1.FileName = tcno + ".jpg";
                saveFileDialog1.InitialDirectory = Application.StartupPath + "\\kullaniciresimler\\";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Resim dosyasının yeni adını ve kaydedileceği konumu seçin
                    string newFilePath = saveFileDialog1.FileName;

                    // Resmi yeni adı ve konumuyla kaydet
                    File.Copy(filePath, newFilePath, true);
                    PerGorseli.SizeMode = PictureBoxSizeMode.StretchImage;
                    gorselcek();
                    MessageBox.Show("Resim kaydedildi.");
                }
                else
                    gorselcek();
            }
            else
                gorselcek();

        }

        public void gorselcek()
        {
            try
            {
                PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\" + PersonelList.tcno + ".jpg");
                PerGorseli.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\resimyok.jpg");
                PerGorseli.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
