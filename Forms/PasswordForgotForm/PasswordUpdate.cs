using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerModule.Forms.LoginForm;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Data.Sql;



namespace PerModule.Forms.PasswordForgotForm
{
    public partial class PasswordUpdate : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public PasswordUpdate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        int Perid = 0;
        private void btnPassUpGonder_Click(object sender, EventArgs e)
        {

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand passupoku = new SqlCommand("SELECT PerMail,PerPassword,id FROM Personnels where PerMail=@PerMail", baglan);
            passupoku.Parameters.AddWithValue("@PerMail", txtSendMail.Text);
            passupoku.Parameters.AddWithValue("@id", Perid);
            SqlDataReader oku = passupoku.ExecuteReader();
            if (oku.Read())
            {

                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                string tarih = DateTime.Now.ToString();
                string mailadress = ("wyrdsoft2022@outlook.com");
                string sifre = ("23Huzur08.");
                string smptsrvr = "smtp.office365.com";
                string kime = (oku["PerMail"].ToString());
                string konu = ("Şifre Hatırlatma");
                string yaz = ("Merhaba," + "\n" + "Wyrd Personel Modülü'nden " + tarih + " tarihinde şifre hatırlatma talebinde " +
                    "bulundunuz." + "\n" + "Parolanız: " + oku["PerPassword"].ToString() + "\nWyrd Yazılım iyi günler diler.");
                smtpserver.Credentials = new NetworkCredential(mailadress, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smptsrvr;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadress);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;
                smtpserver.Send(mail);
                this.Alert("Bilgileriniz uyuşuyor. Şifreniz mail adresinize gönderilmiştir.", Form_Alert.enmType.Success);
                Login form = new Login();
                form.Show();
                this.Hide();
            }
            else
            {
                this.Alert("Mail uyuşmadı! Tekrar deneyin.", Form_Alert.enmType.Warning);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }
    }
}
