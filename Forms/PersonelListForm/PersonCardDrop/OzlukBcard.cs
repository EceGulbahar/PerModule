using PerModule.Forms.LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    public partial class OzlukBcard : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public OzlukBcard()
        {
            InitializeComponent();
        }

        private string selectedFilePath;
        private void btnOzlukPdfEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                if (!string.IsNullOrEmpty(selectedFilePath))
                {
                    SavePDFToDatabase();
                }
                else
                {
                    MessageBox.Show("Please select a PDF file first.");
                }
            }
        }

        private void SavePDFToDatabase()
        {
            byte[] fileBytes = File.ReadAllBytes(selectedFilePath);
            string fileName = Path.GetFileName(selectedFilePath);

            string connectionString = ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO OzlukBFiles (FileName, FileData, personnelid, kullaniciid) VALUES (@FileName, @FileData, @personnelid, @kullaniciid)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciid", Login.kullanici);
                    command.Parameters.AddWithValue("@personnelid", OnIzleme.personnelid);
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@FileData", fileBytes);
                    command.ExecuteNonQuery();
                    searchyenile();
                }
            }
        }

        public void DisplayPDFFromDatabase(string fileName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FileData FROM OzlukBFiles WHERE FileName = @FileName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FileName", fileName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] fileData = (byte[])reader["FileData"];

                            // Örneğin, PDF'i bir temp dosyasına kaydedip varsayılan PDF görüntüleyiciyle açabilirsiniz.
                            string tempFilePath = Path.GetTempFileName();
                            File.WriteAllBytes(tempFilePath, fileData);
                            Process.Start(tempFilePath);
                        }
                        else
                        {
                            MessageBox.Show("The specified PDF file was not found in the database.");
                        }
                    }
                }
            }
        }

        private void OzlukBcard_Load(object sender, EventArgs e)
        {
            searchyenile();
            // TODO: Bu kod satırı 'viewOzlukB._ViewOzlukB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.viewOzlukBTableAdapter.Fill(this.viewOzlukB._ViewOzlukB);

        }

        int secilendeger;
        string fileName;
        private void OzlukBGridList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilendeger = OzlukBGridList.SelectedCells[0].RowIndex;
            fileName = OzlukBGridList.Rows[secilendeger].Cells[5].Value.ToString();
            DisplayPDFFromDatabase(fileName);
        }

        DataTable dt = new DataTable("ViewOzlukB");
        public void searchyenile()
        {
            dt.Clear();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from ViewOzlukB where personnelid=@personid", baglan))
            {
                dasearch.SelectCommand.Parameters.AddWithValue("@personid", OnIzleme.personnelid);
                dasearch.Fill(dt);
                OzlukBGridList.DataSource = dt;
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            searchyenile();
        }
    }
}
