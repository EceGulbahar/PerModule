using PerModule.Forms.AnasayfaForm;
using PerModule.Forms.PersonelListForm.PersonCardDrop;
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
using PerModule.Forms.PersonelListForm;

namespace PerModule.Forms.PersonelListForm
{
    public partial class PersonCard : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public PersonCard()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //Bu kod içinde form açılabileceği anlamına geliyor.
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = System.Drawing.ColorTranslator.FromHtml("#495057");
            pnlbuttons.BackColor = System.Drawing.ColorTranslator.FromHtml("#495057");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void PersonCard_Load(object sender, EventArgs e)
        {

        }
        public void FormGetir(Form form)
        {
            PFormGetir.Controls.Clear();
            form.MdiParent = this;//bu formu parent olarak veriyoruz.
            PFormGetir.Controls.Add(form);
            form.Show(); //formHome açılıyor.
        }

        private void btnOnIzleme_Click(object sender, EventArgs e)
        {
            OnIzleme onizleme = new OnIzleme();
            FormGetir(onizleme);
        }

        private void btnKisiselB_Click(object sender, EventArgs e)
        {
            KisiselBilgilercard kgcard = new KisiselBilgilercard();
            FormGetir(kgcard);
        }

        private void btnBasvuru_Click(object sender, EventArgs e)
        {
            Basvurucard basvurucard = new Basvurucard();
            FormGetir(basvurucard);
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {
            Zimmetcard zimmetcard = new Zimmetcard();
            FormGetir(zimmetcard);
        }

        private void btnOzlukB_Click(object sender, EventArgs e)
        {
            OzlukBcard ozlukBcard = new OzlukBcard();
            FormGetir(ozlukBcard);
        }

        private void btnUcretP_Click(object sender, EventArgs e)
        {
            UcretBcard ucretBcard = new UcretBcard();
            FormGetir(ucretBcard);
        }

        private void btnBordro_Click(object sender, EventArgs e)
        {
            Bordrocard bordrocard = new Bordrocard();
            FormGetir(bordrocard);
        }

        private void btnIzinler_Click(object sender, EventArgs e)
        {
            Izinlercard izinlercard = new Izinlercard();
            FormGetir(izinlercard);
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlarcard raporlarcard = new Raporlarcard();
            FormGetir(raporlarcard);
        }

        private void btnHaciz_Click(object sender, EventArgs e)
        {
            Hacizcard hacizcard = new Hacizcard();
            FormGetir(hacizcard);
        }

        private void btnKVGM_Click(object sender, EventArgs e)
        {
            Kvgmcard kvgm = new Kvgmcard();
            FormGetir(kvgm);
        }
    }
}
