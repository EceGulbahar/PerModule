using PerModule.Classes;
using PerModule.Forms.AnasayfaForm;
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
    public partial class Izinlercard : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Izinlercard()
        {
            InitializeComponent();
        }

        private void Izinlercard_Load(object sender, EventArgs e)
        {
            try
            {
                UCIzinGoster();
            }
            catch
            {
               
            }
        }

        public void UCIzinGoster()
        {
            foreach (var izingoster in dc.Izin)
            {
                SqlCommand yaklasanekomut = new SqlCommand("select * from Izin where Personnelid=@Personnelid", baglan);
                yaklasanekomut.Parameters.AddWithValue("@Personnelid", OnIzleme.personnelid);
                baglan.Open();
                SqlDataReader oku = yaklasanekomut.ExecuteReader();
                if (!oku.HasRows)
                {
                    Izincards UCizincarda = new Izincards();
                    UCizincarda.pnlNotFound.Visible = true;
                    UCizincarda.Dock = DockStyle.Top;
                    pnlUCIzin.Controls.Add(UCizincarda);
                }
                else
                {
                    while (oku.Read())
                    {
                        Izincards UCizincard = new Izincards();
                        UCizincard.lblIzintipialt.Text = oku.GetString(3);
                        UCizincard.lblIzinBaslangicalt.Text = oku.GetDateTime(4).ToShortDateString();
                        UCizincard.lblIzinBitisalt.Text = oku.GetDateTime(5).ToShortDateString();
                        UCizincard.lblIzinAciklamaalt.Text = oku.GetString(7);
                        UCizincard.lblDonemAyalt.Text = oku.GetInt32(10).ToString();
                        UCizincard.lblDonemYilalt.Text = oku.GetInt32(11).ToString();
                        UCizincard.Dock = DockStyle.Top;
                        pnlUCIzin.Controls.Add(UCizincard);
                    }
                }
                
                oku.Close();
                baglan.Close();
            }
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
    }
}
