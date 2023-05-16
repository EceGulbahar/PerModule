using PerModule.Forms.LoginForm;
using PerModule.Forms.PersonelListForm;
using System;
using System.Collections;
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

namespace PerModule.Forms.BordrosForm
{
    public partial class Bordros : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Bordros()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        int yil = DateTime.Now.Year;
        private void Bordros_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'viewBordroDS.ViewBordro' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.viewBordroTableAdapter.Fill(this.viewBordroDS.ViewBordro);
            for (int i = yil; i <= yil + 5; i++)
            {
                dropDonemYil.Items.Add(i);
            }
            //bordrohesapla();
        }

        public static decimal netMaas;
        public int personnelid;
        List<decimal> bordrolar = new List<decimal>();
        public static int bordroperid;
        public void bordrohesapla()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            foreach (var bordro in dc.Personnels)
            {
                personnelid = bordro.id;
                string query = "SELECT SUM(Tutar) FROM Mesai where Personnelid=@Personnelid and DonemAy=@da and DonemYil=@dy and OdenmeDurumu=@od";
                using (SqlCommand bordrohesapla = new SqlCommand(query, baglan))
                {
                    // Sorgu parametrelerini ekle
                    bordrohesapla.Parameters.AddWithValue("@Personnelid", personnelid);
                    bordrohesapla.Parameters.AddWithValue("@da", Convert.ToInt16(dropDonemAy.Text));
                    bordrohesapla.Parameters.AddWithValue("@dy", Convert.ToInt16(dropDonemYil.Text));
                    bordrohesapla.Parameters.AddWithValue("@od", "Ödendi");
                    // Sorgu sonuçlarını oku
                    using (SqlDataReader bordrooku = bordrohesapla.ExecuteReader())
                    {
                        if (bordrooku.Read())
                        {
                            if (!bordrooku.IsDBNull(0))
                            {
                                decimal sum = bordrooku.GetDecimal(0);
                                bordrolar.Add(sum);
                            }
                            else
                            {
                                bordrolar.Add(0);
                            }
                        }
                    }
                }
            }
            
            // Bütün bordroları ekranda göster veya başka bir amaçla kullan
            foreach (var bordro in bordrolar)
            {
                BordroHesaplama hesaplayici = new BordroHesaplama();
                netMaas = hesaplayici.netucrethesapla(bordro);
                //Console.WriteLine("Bordro: " + bordro.ToString());
                /*if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand bordroayekle = new SqlCommand("insert into Bordros(personnelid,ToplamGun,IzinliGun,BrutMaas,NetMaas,DonemAy,DonemYil,kullaniciid) values(@personnelid,@ToplamGun,@IzinliGun,@BrutMaas,@NetMaas,@DonemAy,@DonemYil,@kullaniciid)", baglan);
                bordroayekle.Parameters.AddWithValue("@personnelid", personnelid);
                bordroayekle.Parameters.AddWithValue("@ToplamGun", );
                bordroayekle.Parameters.AddWithValue("@IzinliGun", );
                bordroayekle.Parameters.AddWithValue("@BrutMaas", bordro);
                bordroayekle.Parameters.AddWithValue("@NetMaas", netMaas);
                bordroayekle.Parameters.AddWithValue("@kullaniciid", Login.kullanici);
                bordroayekle.Parameters.AddWithValue("@DonemAy", Convert.ToInt32(dropDonemAy.Text));
                bordroayekle.Parameters.AddWithValue("@DonemYil", Convert.ToInt32(dropDonemYil.Text));
                bordroayekle.ExecuteNonQuery();
                this.Alert("Mesai Ekleme Başarılı", Form_Alert.enmType.Success);
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }*/
            }
        }

        /*public double gelirvegisihesapla(double a)
        {
            a = BordroHesaplama.gelirvergisimatrahı;
            a = (a*15 / 100)-1276.02;
            return a;
        }*/

        private void btnDonemlikBordroHesapla_Click(object sender, EventArgs e)
        {
            if (dropDonemAy.Text != null && dropDonemYil.Text != null)
            {
                bordrohesapla();

            }
            else
            {
                this.Alert("Dönem ve Yıl Seçiniz.", Form_Alert.enmType.Warning);
            }
        }
    }
}
