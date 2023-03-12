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
    public partial class OnIzleme : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public OnIzleme()
        {
            InitializeComponent();
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
            
            try
            {
                PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\"+PersonelList.tcno+".jpg");
            }
            catch 
            {
                PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\resimyok.jpg");

            }
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
    }
}
