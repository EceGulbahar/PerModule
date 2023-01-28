using PerModule.Forms.AnasayfaForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace PerModule.Forms.PersonelListForm
{
    public partial class PersonelList : Form
    {

         SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\90501\Desktop\PerModule\Kaynak Kodlar\PerModule\Data\PERSONNELMODULE.mdf"";Integrated Security=True");
        public PersonelList()
        {
            InitializeComponent();
            
        }

        private void btnExceleAl_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["PersonnelSheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < GridHugeList.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = GridHugeList.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < GridHugeList.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < GridHugeList.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = GridHugeList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
                MessageBox.Show("Excele aktarma başarılı.");
            }
        }

        private void DropDepartmans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDepEklePnlAc_Click(object sender, EventArgs e)
        {
            if(pnlDepEkle.Visible == false)
            {
                pnlDepEkle.Visible = true;
            }
            else
            {
                pnlDepEkle.Visible=false;
            }
        }

        private void PersonelList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
            

        }
        string tckn = "";
        int secilendeger;
        public void GridHugeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridHugeList.Columns[e.ColumnIndex].Name == "Kartlar")
            {
                
                secilendeger = GridHugeList.SelectedCells[0].RowIndex;
                tckn = GridHugeList.Rows[secilendeger].Cells[0].Value.ToString(); //tckn değişkeni alıyoruz gridden
                PersonCard personCard = new PersonCard();
                personCard.Show();
            }
        }

        private void pnlDepEkle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
