using PerModule.Forms.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule
{
    public partial class WelcomeScreenForm : Form
    {
        public WelcomeScreenForm()
        {
            InitializeComponent();
        }

        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(islem==false)
            {
                this.Opacity += 0.004;
            }
            if(this.Opacity == 1.0)
            {
                islem = true;
                Login login = new Login();
                login.Show();
                timer1.Enabled = false;
            }
        }
    }
}
