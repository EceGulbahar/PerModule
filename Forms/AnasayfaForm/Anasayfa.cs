using PerModule.Forms.PersonelListForm;
using PerModule.PERSONNELMODULEDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.AnasayfaForm
{
    public partial class Anasayfa : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        DataClasses1DataContext dc = new DataClasses1DataContext();
        
        public Anasayfa()
        {
            InitializeComponent();
            
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Bitis();
            int personelSayisi = dc.Personnels.Count();
            // Mevcut personel sayısını alın


            // Panele eklenen nesne sayısını alın
            int nesneSayisi = panel3.Controls.OfType<UC_NewPersonnels>().Count();
            while (panel3.Controls.OfType<UC_NewPersonnels>().Count() > personelSayisi)
            {
                panel3.Controls.RemoveAt(panel3.Controls.Count - 1);
            }
        }
        
        int depcek;
        string depadi, deprolu;
        public void Bitis()
        {
            foreach( var deg in dc.Personnels)
            {
                SqlCommand command = new SqlCommand("SELECT PerAd, PerSoyad, PerBaslamaT, Departmanid FROM Personnels", baglan);
                baglan.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UC_NewPersonnels uc = new UC_NewPersonnels();
                    uc.lbltarih.Text = reader.GetDateTime(2).ToShortDateString();
                    uc.lbladisoyadi.Text = reader.GetString(0) + " " + reader.GetString(1);
                    //uc.bunifuButton1.Tag = reader.GetInt32(3);
                    depcek = reader.GetInt32(3);
                    Baslangic();
                    uc.lblaciklama.Text = deprolu + " / " + depadi + " departmanında\n " + uc.lbltarih.Text + " tarihinde işe başladı.";
                    uc.Dock = DockStyle.Top;
                    panel3.Controls.Add(uc);
                }
                reader.Close();

                baglan.Close();
            }
        }
        public void Baslangic()
        {
            SqlCommand command1 = new SqlCommand("SELECT DepAdi,DepRolu FROM Departmans where id=@depcek", baglan);
            command1.Parameters.AddWithValue("depcek", depcek);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                depadi = reader1.GetString(0);
                deprolu = reader1.GetString(1);

            }
            reader1.Close();
        }
    }
}
