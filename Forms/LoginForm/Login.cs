using PerModule.Forms.PasswordForgotForm;
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


namespace PerModule.Forms.LoginForm
{
    public partial class Login : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public static int kullanici;
        public string kullaniciadi;
        public void btnGiris_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            string sql = "SELECT * FROM Personnels where PerNickName=@PerNickName AND PerPassword=@PerPassword";
            SqlParameter prmAd = new SqlParameter("@PerNickName", txtKAdi.Text.Trim());
            SqlParameter prmSifre = new SqlParameter("@PerPassword", txtKSifre.Text.Trim());
            SqlCommand giris = new SqlCommand(sql, baglan);
            giris.Parameters.Add(prmAd);
            giris.Parameters.Add(prmSifre);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(giris);
            da.Fill(dt);
            if (dt.Rows.Count > 0) //ilgili alanlar birbirini tutuyor mu?
            {
                kullaniciadi=txtKAdi.Text;
                SqlCommand logincmbdd = new SqlCommand("SELECT id FROM Personnels where PerNickName=@PerNickName", baglan);
                logincmbdd.Parameters.AddWithValue("@PerNickName",txtKAdi.Text);
                logincmbdd.ExecuteScalar();
                SqlDataReader reader1 = logincmbdd.ExecuteReader();
                // Verileri işle
                while (reader1.Read())
                {
                    kullanici = reader1.GetInt32(0);
                    // Verileri konsola yazdırabilirsiniz
                }
                // Okuyucuyu kapat
                reader1.Close();
                Main form = new Main();
                form.Show();
                this.Hide();
            }
            else
            {
                this.Alert("Giriş başarısız. Tekrar deneyiniz.", Form_Alert.enmType.Warning);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtKSifre.PasswordChar == '*')
            {
                btnSifreGizle.BringToFront();
                _ = txtKSifre.PasswordChar = '\0';
            }
        }

        private void btnSifreGizle_Click(object sender, EventArgs e)
        {
            if (txtKSifre.PasswordChar == '\0')
            {
                btnSifreGoster.BringToFront();
                txtKSifre.PasswordChar = '*';
            }
        }

        private void linklblSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordUpdate form = new PasswordUpdate();
            form.Show();
        }

       
    }
}
