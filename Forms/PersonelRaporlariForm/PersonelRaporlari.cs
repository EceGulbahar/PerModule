using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PerModule.Forms.PersonelRaporlariForm
{
    public partial class PersonelRaporlari : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public PersonelRaporlari()
        {
            InitializeComponent();
        }

        private void PersonelRaporlari_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personnelRapor._PersonnelRapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personnelRaporTableAdapter.Fill(this.personnelRapor._PersonnelRapor);
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            Yas();
            //Toplam Personel Sayısı
            SqlCommand mevcudkisi = new SqlCommand("select count(*) from Personnels", baglan);
            SqlDataReader reader = mevcudkisi.ExecuteReader();
            while (reader.Read())
            {
                lblPerSayisi.Text = reader[0].ToString();
            }

            SqlCommand departmansayisi = new SqlCommand("select count(*) from DepartmanDrop", baglan);
            SqlDataReader reader1 = departmansayisi.ExecuteReader();
            while (reader1.Read())
            {
                lblDepartmanSayisi.Text = reader1[0].ToString();
            }

            SqlCommand yetkiliper = new SqlCommand("select count(*) from Personnels where Durum=@Durum and PerYetki=@PerYetki or PerYetki=@PerYetki2", baglan);
            yetkiliper.Parameters.AddWithValue("@Durum", 1);
            yetkiliper.Parameters.AddWithValue("@PerYetki", "Yetkili");
            yetkiliper.Parameters.AddWithValue("@PerYetki2", "Kurucu");
            SqlDataReader reader2 = yetkiliper.ExecuteReader();
            while (reader2.Read())
            {
                lblYetkiliPer.Text = reader2[0].ToString();
            }

            SqlCommand departmangrafik = new SqlCommand("select Departmanlar, Count(*) from DepartmanDrop group by Departmanlar", baglan);
            SqlDataReader reader3 = departmangrafik.ExecuteReader();
            while (reader3.Read())
            {
                chartDepartmans.Series["DepartmanDagilimi"].Points.AddXY(reader3[0].ToString(), reader3[1]);
            }

            SqlCommand egitimgrafik = new SqlCommand("select EgitimDurumu, Count(*) from Egitims group by EgitimDurumu", baglan);
            SqlDataReader reader4 = egitimgrafik.ExecuteReader();
            while (reader4.Read())
            {
                chartEgitims.Series["EgitimDurumlari"].Points.AddXY(reader4[0].ToString(), reader4[1]);
            }

            SqlCommand departmangrafikcinsiyet = new SqlCommand("select PerCinsiyet, Count(*) from Personnels group by PerCinsiyet ", baglan);
            SqlDataReader reader5 = departmangrafikcinsiyet.ExecuteReader();
            while (reader5.Read())
            {
                chartCinsiyet.Series["Cinsiyet"].Points.AddXY(reader5[0].ToString(), reader5[1]);
            }

            string countQuery = "SELECT COUNT(*) FROM Personnels WHERE PerBaslamaT >= DATEADD(month, -1, GETDATE())";
            SqlCommand countCommand = new SqlCommand(countQuery, baglan);
            int count = (int)countCommand.ExecuteScalar();
            lblAylikAlinan.Text = count.ToString();

            string countQuery1 = "SELECT COUNT(*) FROM Personnels WHERE PerAyrilisT >= DATEADD(month, -1, GETDATE())";
            SqlCommand countCommand1 = new SqlCommand(countQuery1, baglan);
            int count1 = (int)countCommand1.ExecuteScalar();
            lblAylikCikarilan.Text = count1.ToString();
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        public void Yas()
        {
            // Create series
            Series series = new Series();
            series.Name = "Kişi Sayısı";
            series.ChartType = SeriesChartType.Column;
            Legend legend = new Legend();
            legend.Name = "Kişi Sayısı";
            chartYas.Legends.Add(legend);
            chartYas.Legends["Kişi Sayısı"].Docking = Docking.Top;
            chartYas.Legends["Kişi Sayısı"].ForeColor = Color.Gainsboro;
            
            legend.BackColor = Color.FromArgb(52, 58, 64);


            SqlCommand command = new SqlCommand("SELECT PerDogumTarihi FROM Personnels", baglan);
            SqlDataReader reader = command.ExecuteReader();

            int count18_24 = 0;
            int count25_40 = 0;
            int count41_60 = 0;
            int count61 = 0;


            while (reader.Read())
            {
                DateTime birthDate = (DateTime)reader["PerDogumTarihi"];
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                    age--;

                if (age >= 18 && age <= 24)
                    count18_24++;
                else if (age >= 25 && age <= 40)
                    count25_40++;
                else if (age >= 41 && age <= 60)
                    count41_60++;
                else if (age >= 61)
                    count61++;
            }

            // Add data points to series
            series.Points.AddXY("18-24", count18_24);
            series.Points.AddXY("25-40", count25_40);
            series.Points.AddXY("41-60", count41_60);
            series.Points.AddXY("61+", count61);

            // Add series to chart control
            chartYas.Series.Add(series);

            // Set chart type to column for the series in the chart control
            series.ChartType = SeriesChartType.Column;

            // Close SQL Server connection
            reader.Close();
        }
    }
}
