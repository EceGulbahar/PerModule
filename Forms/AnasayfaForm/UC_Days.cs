using PerModule.Forms.PersonelListForm;
using PerModule.Forms.PersonelListForm.PersonCardDrop;
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

namespace PerModule.Forms.AnasayfaForm
{
    public partial class UC_Days : UserControl
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public static string static_day;
        public UC_Days()
        {
            InitializeComponent();
        }

        private void UC_Days_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        public void days(int numday)
        {
            lbldays.Text = numday+" ";
        }

        private void UC_Days_Click(object sender, EventArgs e)
        {
            static_day = lbldays.Text;
            EventForm eventform = new EventForm();
            BackModel backmodel = new BackModel();
            backmodel.FormBorderStyle = FormBorderStyle.None;
            backmodel.Opacity = .50d;
            backmodel.BackColor = Color.Black;
            backmodel.Size = new Size(1920, 1059);
            //backmodel.Location = new Point(114, 21);
            backmodel.ShowInTaskbar = false;
            backmodel.Show();
            eventform.Owner = backmodel;
            eventform.ShowDialog();
            backmodel.Dispose();
            timer1.Start();

        }

        bool kayitkontrol = false;
        private void displayEvent()
        {
            kayitkontrol = false;
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand sqlkayitk = new SqlCommand("select * from Calendar where date=@date", baglan);
            sqlkayitk.Parameters.AddWithValue("@date", Anasayfa.static_year + "-" + Anasayfa.static_month + "-" + lbldays.Text);
            SqlDataReader kayitokuma = sqlkayitk.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                //lbl yazdırma
                break;
            }
            if (kayitkontrol == false)
            {
                BackColor = Color.FromArgb(149, 156, 163);
            }
            else if (kayitkontrol == true)
            {
                BackColor = Color.FromArgb(255, 128, 128);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }

       
    }
}
