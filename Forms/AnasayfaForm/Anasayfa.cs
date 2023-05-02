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
using System.Globalization;
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
            displayDays();
        }
        static DateTime currentDT = DateTime.Now;
static int currentYear = currentDT.Year;
static int currentMonth = currentDT.Month;
        int month, year;
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) +1;
            for(int i=1; i<dayoftheweek; i++)
            {
                UC_Calendar uccalendar = new UC_Calendar();
                daycontainer.Controls.Add(uccalendar);
            }
            for(int i=1; i <= days;i++)
            {
                UC_Days ucdays = new UC_Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        int depcek;
        string depadi, deprolu;
        public void Bitis()
        {
            foreach( var deg in dc.Personnels)
            {
                SqlCommand command = new SqlCommand("SELECT PerAd, PerSoyad, PerBaslamaT, Departmanid,PerTckn FROM Personnels", baglan);
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
                    try
                    {
                        uc.pictureFoto.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\" + reader.GetString(4) + ".jpg");
                        uc.pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        uc.pictureFoto.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\resimyok.jpg");
                        uc.pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    uc.Dock = DockStyle.Top;
                    panel3.Controls.Add(uc);
                }
                reader.Close();
                baglan.Close();
            }
        }

        private void CalenderSag_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UC_Calendar uccalendar = new UC_Calendar();
                daycontainer.Controls.Add(uccalendar);
            }
            for (int i = 1; i <= days; i++)
            {
                UC_Days ucdays = new UC_Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
            
        }

        private void CalenderSol_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UC_Calendar uccalendar = new UC_Calendar();
                daycontainer.Controls.Add(uccalendar);
            }
            for (int i = 1; i <= days; i++)
            {
                UC_Days ucdays = new UC_Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
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
