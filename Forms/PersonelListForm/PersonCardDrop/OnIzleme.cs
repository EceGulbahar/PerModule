using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    public partial class OnIzleme : Form
    {
        public OnIzleme()
        {
            InitializeComponent();
        }


        private void btnNotlarDuzenle_Click(object sender, EventArgs e)
        {
            if (txtNotlar.Enabled == false)
            {
                txtNotlar.Enabled = true;
                btnNotEkleLast.Visible = true;
                btnNotIptal.Visible = true;
            }
            else
            {
                txtNotlar.Enabled = false;
                btnNotEkleLast.Visible = false;
                btnNotIptal.Visible = false;
            }
        }

        private void btnNotIptal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNotEkleLast_Click(object sender, EventArgs e)
        {

        }

        private void OnIzleme_Load(object sender, EventArgs e)
        {
            try
            {
                PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\"+PersonelList.tcno+".jpg");
            }
            catch 
            {
                PerGorseli.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\resimyok.jpg");

            }
            grupAd.Text = PersonelList.adi + " " + PersonelList.soyadi;
        }
    }
}
