using PerModule.Forms.AnasayfaForm;
using PerModule.Forms.IzinRaporlariForm;
using PerModule.Forms.OzlukDosyasiRaporlariForm;
using PerModule.Forms.PersonelListForm;
using PerModule.Forms.PersonelRaporlariForm;
using PerModule.Forms.ZimmetRaporlariForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Drawing2D;
using System.Configuration;
using PerModule.Forms.BordrosForm;

namespace PerModule
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // Down Taskbarın üstünde maximize etmek için
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true; //Bu kod içinde form açılabileceği anlamına geliyor.
            
        }

        /*public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);*/

        public void FormGetir(Form form)
        {
            PFormGetir.Controls.Clear();
            form.MdiParent = this;//bu formu parent olarak veriyoruz.
            form.FormBorderStyle = FormBorderStyle.None;
            PFormGetir.Controls.Add(form);
            form.Show(); //formHome açılıyor.
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnQMark_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            FormGetir(anasayfa);
        }

        private void btnPerRaport_Click_1(object sender, EventArgs e)
        {
            PersonelRaporlari Rapors = new PersonelRaporlari();
            FormGetir(Rapors);
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelList PerList = new PersonelList();
            FormGetir(PerList);
        }

        private void BtnIzin_Click_1(object sender, EventArgs e)
        {
            IzinRaporlari Izins = new IzinRaporlari();
            FormGetir(Izins);
        }

        private void btnZimmet_Click_1(object sender, EventArgs e)
        {
            ZimmetRaporlari Zimmets = new ZimmetRaporlari();
            FormGetir(Zimmets);
        }

        private void btnOzlukB_Click_1(object sender, EventArgs e)
        {
            OzlukDosyasiRaporlari OzlukD = new OzlukDosyasiRaporlari();
            FormGetir(OzlukD);
        }

        private void btnBordro_Click_1(object sender, EventArgs e)
        {
            Bordros bordros = new Bordros();
            FormGetir(bordros);
        }
    }
}
