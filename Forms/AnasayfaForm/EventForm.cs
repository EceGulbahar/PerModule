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
    public partial class EventForm : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = Anasayfa.static_month + "/" + UC_Days.static_day + "/" + Anasayfa.static_year;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            string sqlmesaiekle = "insert into Calendar(date,event) values(@date,@event)";
            SqlCommand mesaiekle = new SqlCommand(sqlmesaiekle, baglan);
            mesaiekle.Parameters.AddWithValue("@date", txtdate.Text);
            mesaiekle.Parameters.AddWithValue("@event", txtEvents.Text);
            mesaiekle.ExecuteNonQuery();
            this.Alert("Etkinlik eklendi", Form_Alert.enmType.Success);
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.UCYaklasanEtkinlik();
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
