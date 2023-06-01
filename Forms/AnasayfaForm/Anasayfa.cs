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
        
        int bday;
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
            //her günü event var mı diye kontrol etmek için
            UCYaklasanEtkinlik();
            UCBugunEvents();
            while (pnlMevcutEtkinlik.Controls.OfType<UC_BugunEvents>().Count() > rowCount)
            {
                pnlMevcutEtkinlik.Controls.RemoveAt(pnlMevcutEtkinlik.Controls.Count - 1);
            }
            while (pnlYaklasanEtkinlikler.Controls.OfType<UC_YaklasanEvents>().Count() > rowCount1)
            {
                pnlYaklasanEtkinlikler.Controls.RemoveAt(pnlYaklasanEtkinlikler.Controls.Count - 1);
            }
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand departmangrafik = new SqlCommand("select Departmanlar, Count(*) from DepartmanDrop group by Departmanlar", baglan);
            SqlDataReader reader3 = departmangrafik.ExecuteReader();
            while (reader3.Read())
            {
                chartDepartmans.Series["DepartmanDagilimi"].Points.AddXY(reader3[0].ToString(), reader3[1]);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        int month, year;
        public static int static_month,static_year;
        
        public void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbldate.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
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
        int rowCount1 = 0;
        DateTime datenow = DateTime.Now;
        public void UCYaklasanEtkinlik()
        {
            foreach (var deg1 in dc.Calendar)
            {
                SqlCommand yaklasanekomut = new SqlCommand("select * from Calendar where date>= @datenow order by date desc", baglan);
                yaklasanekomut.Parameters.AddWithValue("@datenow", datenow);
                baglan.Open();
                SqlDataReader yeoku = yaklasanekomut.ExecuteReader();
                while (yeoku.Read())
                {
                    UC_YaklasanEvents ucye = new UC_YaklasanEvents();
                    ucye.lbleventsy.Text = yeoku.GetDateTime(0).ToShortDateString() + " tarihinde " + yeoku.GetString(1);
                    ucye.Dock = DockStyle.Top;
                    pnlYaklasanEtkinlikler.Controls.Add(ucye);
                }
                yeoku.Close();
                baglan.Close();

                baglan.Open();
                string queryString = "SELECT COUNT(*) FROM Calendar where date>= @datenow";
                SqlCommand command = new SqlCommand(queryString, baglan);
                command.Parameters.AddWithValue("@datenow", datenow);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rowCount1 = reader.GetInt32(0);
                }
                baglan.Close();
            }
        }
        int rowCount = 0;
        DateTime dateOnly = DateTime.Now.Date;

        public void UCBugunEvents()//çalışmıyor
        {
            foreach (var deg2 in dc.Calendar)
            {
                SqlCommand bmevcutkomut = new SqlCommand("select * from Calendar where date =@dtn order by date desc", baglan);
                bmevcutkomut.Parameters.AddWithValue("@dtn", dateOnly);
                baglan.Open();
                SqlDataReader bmoku = bmevcutkomut.ExecuteReader();
                while (bmoku.Read())
                {
                    UC_BugunEvents ucbmev = new UC_BugunEvents();
                    ucbmev.lbleventsb.Text = bmoku.GetDateTime(0).ToShortDateString() + " tarihinde " + bmoku.GetString(1);
                    ucbmev.Dock = DockStyle.Top;
                    pnlMevcutEtkinlik.Controls.Add(ucbmev);
                }
                bmoku.Close();
                baglan.Close();

                baglan.Open();
                string queryString = "SELECT COUNT(*) FROM Calendar where date =@dtn";
                    SqlCommand command = new SqlCommand(queryString, baglan);
                    command.Parameters.AddWithValue("@dtn", dateOnly);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rowCount = reader.GetInt32(0);
                    }
                baglan.Close();
            }
        }

        UC_Days ucdays = new UC_Days();
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
            static_month = month;
            static_year = year;
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
                //ucdays.lbldays.Text = i.ToString();
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
            static_month = month;
            static_year = year;
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
