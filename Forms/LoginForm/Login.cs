using PerModule.Forms.PasswordForgotForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

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
