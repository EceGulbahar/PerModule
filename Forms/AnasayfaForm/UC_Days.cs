using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.AnasayfaForm
{
    public partial class UC_Days : UserControl
    {
        public UC_Days()
        {
            InitializeComponent();
        }

        private void UC_Days_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbldays.Text = numday+" ";
        }
    }
}
