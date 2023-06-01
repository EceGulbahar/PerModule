using PerModule.Classes;
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
    public partial class Bordrocard : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public Bordrocard()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        int yil = DateTime.Now.Year;
        private void Bordrocard_Load(object sender, EventArgs e)
        {
            for (int i = yil; i <= yil + 5; i++)
            {
                dropDonemYil.Items.Add(i);
            }
            searchyenile();
        }

        DataTable dt = new DataTable("ViewBordrocard");
        public void searchyenile()
        {
            dt.Clear();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from ViewBordro where personnelid = @pid", baglan))
            {
                dasearch.SelectCommand.Parameters.AddWithValue("@pid", OnIzleme.personnelid);
                dasearch.Fill(dt);
                BordroCardList.DataSource = dt;
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        private void btnBordroGoster_Click(object sender, EventArgs e)
        {
            if(dropDonemAy.Text !=null && dropDonemYil.Text != null)
            {
                dt.Clear();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from ViewBordro where personnelid = @pid and DonemAy=@DonemAy and DonemYil=@DonemYil", baglan))
                {
                    dasearch.SelectCommand.Parameters.AddWithValue("@pid", OnIzleme.personnelid);
                    dasearch.SelectCommand.Parameters.AddWithValue("@DonemAy", dropDonemAy.Text);
                    dasearch.SelectCommand.Parameters.AddWithValue("@DonemYil", dropDonemYil.Text);
                    dasearch.Fill(dt);
                    BordroCardList.DataSource = dt;
                }
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
            else
            {
                this.Alert("Ay Ve Yıl Boş Geçilemez!", Form_Alert.enmType.Warning);
            }
        }

        private void btnPdfCikar_Click(object sender, EventArgs e)
        {
            PDFcikar.pdfcikra(BordroCardList);
            this.Alert("PDF aktarma başarılı", Form_Alert.enmType.Success);
        }

        private void btnExceleAl_Click(object sender, EventArgs e)
        {
            ExceleAl.Excel_Disa_Aktar(BordroCardList);
            this.Alert("Excele aktarma başarılı", Form_Alert.enmType.Success);
        }
    }
}
