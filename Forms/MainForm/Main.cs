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
using PerModule.Forms.DepartmanForm;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

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

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            FormGetir(anasayfa);
            //btnAnasayfa.BackColor = System.Drawing.ColorTranslator.FromHtml("#212529");
            pnlHLight.Height = btnAnasayfa.Height;
            pnlHLight.Top = btnAnasayfa.Top;
            pnlHLight1.Height = btnAnasayfa.Height;
            pnlHLight1.Top = btnAnasayfa.Top;

        }

        private void btnPerRaport_Click_1(object sender, EventArgs e)
        {
            PersonelRaporlari Rapors = new PersonelRaporlari();
            FormGetir(Rapors);
            pnlHLight.Height = btnPerRaport.Height;
            pnlHLight.Top = btnPerRaport.Top;
            pnlHLight1.Height = btnPerRaport.Height;
            pnlHLight1.Top = btnPerRaport.Top;

        }

        public void perlistcagir()
        {
            PersonelList PerList = new PersonelList();
            FormGetir(PerList);
        }
        private void btnPersonel_Click(object sender, EventArgs e)
        {
            perlistcagir();
            pnlHLight.Height = btnPersonel.Height;
            pnlHLight.Top = btnPersonel.Top;
            pnlHLight1.Height = btnPersonel.Height;
            pnlHLight1.Top = btnPersonel.Top;

        }

        private void BtnIzin_Click_1(object sender, EventArgs e)
        {
            IzinRaporlari Izins = new IzinRaporlari();
            FormGetir(Izins);
            pnlHLight.Height = BtnIzin.Height;
            pnlHLight.Top = BtnIzin.Top;
            pnlHLight1.Height = BtnIzin.Height;
            pnlHLight1.Top = BtnIzin.Top;

        }

        private void btnZimmet_Click_1(object sender, EventArgs e)
        {
            ZimmetRaporlari Zimmets = new ZimmetRaporlari();
            FormGetir(Zimmets);
            pnlHLight.Height = btnZimmet.Height;
            pnlHLight.Top = btnZimmet.Top;
            pnlHLight1.Height = btnZimmet.Height;
            pnlHLight1.Top = btnZimmet.Top;

        }

        private void btnOzlukB_Click_1(object sender, EventArgs e)
        {
            OzlukDosyasiRaporlari OzlukD = new OzlukDosyasiRaporlari();
            FormGetir(OzlukD);
            pnlHLight.Height = btnOzlukB.Height;
            pnlHLight.Top = btnOzlukB.Top;
            pnlHLight1.Height = btnOzlukB.Height;
            pnlHLight1.Top = btnOzlukB.Top;

        }

        private void btnBordro_Click_1(object sender, EventArgs e)
        {
            Bordros bordros = new Bordros();
            FormGetir(bordros);
            pnlHLight.Height = btnBordro.Height;
            pnlHLight.Top = btnBordro.Top;
            pnlHLight1.Height = btnBordro.Height;
            pnlHLight1.Top = btnBordro.Top;

        }

        private void btnAnasayfa_MouseEnter(object sender, EventArgs e)
        {
            
           btnAnasayfa.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
           btnAnasayfa.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void btnPersonel_MouseEnter(object sender, EventArgs e)
        {
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void btnPersonel_MouseLeave(object sender, EventArgs e)
        {
            btnPersonel.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void btnPerRaport_MouseEnter(object sender, EventArgs e)
        {
            btnPerRaport.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void btnPerRaport_MouseLeave(object sender, EventArgs e)
        {
            btnPerRaport.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void BtnIzin_MouseEnter(object sender, EventArgs e)
        {
            BtnIzin.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void BtnIzin_MouseLeave(object sender, EventArgs e)
        {
            BtnIzin.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void btnZimmet_MouseEnter(object sender, EventArgs e)
        {
            btnZimmet.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void btnZimmet_MouseLeave(object sender, EventArgs e)
        {
            btnZimmet.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void btnOzlukB_MouseEnter(object sender, EventArgs e)
        {
            btnOzlukB.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void btnOzlukB_MouseLeave(object sender, EventArgs e)
        {
            btnOzlukB.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void btnBordro_MouseEnter(object sender, EventArgs e)
        {
            btnBordro.BackColor = System.Drawing.ColorTranslator.FromHtml("#343A40");
        }

        private void btnBordro_MouseLeave(object sender, EventArgs e)
        {
            btnBordro.BackColor = System.Drawing.ColorTranslator.FromHtml("#6C757D");
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
