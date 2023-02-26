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

namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    public partial class KisiselBilgilercard : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public KisiselBilgilercard()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

         public void dropDepartmansDoldur()
        {
            DropKBDepDoldur.Items.Clear();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand doldur = new SqlCommand("SELECT DepAdi FROM Departmans", baglan);
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {
                DropKBDepDoldur.Items.Add(dr[0]);
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }
        private void KisiselBilgilercard_Load(object sender, EventArgs e)
        {
            //button.Click += new EventHandler();

            dropDepartmansDoldur();

            txtKimlikNoKB.MaxLength = 11;
            txtIBANKB.MaxLength = 26;
            txtCepTelKB.MaxLength = 12;
            txtIsTelKB.MaxLength = 12;
            txtWhatsAppTelKB.MaxLength = 12;
            txtYakin1KB.MaxLength = 12;
            txtYakin2KB.MaxLength = 12;

            DateTime dtdogumtarihi = DateTime.Now;
            int yil = int.Parse(dtdogumtarihi.ToString("yyyy"));
            int ay = int.Parse(dtdogumtarihi.ToString("MM"));
            int gun = int.Parse(dtdogumtarihi.ToString("dd"));

            DTDogumTarihi.MinDate = new DateTime(1960,1,1);
            DTDogumTarihi.MaxDate = new DateTime(yil - 18, ay, gun);
            DTDogumTarihi.Format = DateTimePickerFormat.Short;
            DTEhliyetA.MinDate = new DateTime(1960, 1, 1);
            DTEhliyetA.MaxDate = new DateTime(yil - 18, ay, gun);
            DTEhliyetA.Format = DateTimePickerFormat.Short;
            DTSertifikaT.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT.Format = DateTimePickerFormat.Short;
            DTSertifikaT1.MinDate = new DateTime(1960, 1, 1);
            DTSertifikaT1.MaxDate = new DateTime(yil - 18, ay, gun);
            DTSertifikaT1.Format = DateTimePickerFormat.Short;
        }

        private void txtKimlikNoKB_TextChanged(object sender, EventArgs e)
        {
            /*if(txtKimlikNoKB.Text.Length <11 )
            {
                this.Alert("Kimlik no 11 karakterli olmalı!", Form_Alert.enmType.Warning);
            }*/
        }

        private void txtKimlikNoKB_KeyPress(object sender, KeyPressEventArgs e)//sadece sayı girilmesi için
        {
            if(((int)e.KeyChar>=48 && (int)e.KeyChar<=57) || (int)e.KeyChar==8)
                e.Handled = false;
            else
                e.Handled=true;
        }

        private void txtSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCepTelKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtIsTelKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtWhatsAppTelKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
