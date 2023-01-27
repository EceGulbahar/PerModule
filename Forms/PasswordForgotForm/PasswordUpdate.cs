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

namespace PerModule.Forms.PasswordForgotForm
{
    public partial class PasswordUpdate : Form
    {
        public PasswordUpdate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int PerID = 0;
        private void btnPassUpGonder_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.Open();

            SqlCommand passupoku = new SqlCommand("SELECT Tbl_Personels.PerMail, Tbl_Passwords.Sifre, Tbl_Personels.ID FROM Tbl_Personels CROSS JOIN Tbl_Passwords where PerMail=@PerMail", baglan);
            passupoku.Parameters.AddWithValue("@PerMail", txtSendMail.Text);
            passupoku.Parameters.AddWithValue("@ID", PerID);
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
                string yaz = ("Merhaba," + "\n" + "Wyrd Personel Modülü'nden " + tarih + "tarihinde şifre hatırlatma talebinde " +
                    "bulundunuz." + "\n" + "Parolanız: " + oku["Sifre"].ToString() + "\nWyrd Yazılım İyi Günler Diler.");
                smtpserver.Credentials = new NetworkCredential(mailadress, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smptsrvr;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadress);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;
                smtpserver.Send(mail);
                MessageBox.Show("Bilgileriniz uyuşuyor. Şifreniz mail adresinize gönderilmiştir.");
                Login form = new Login();
                form.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("Bir şeyler yanlış! Lütfen tekrar deneyin.");
            }
            baglan.Close();
        }
    }
}
