﻿using PerModule.Forms.DepartmanForm;
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

namespace PerModule.Forms.PersonelListForm
{
    public partial class PerCikarma : Form
    {
        
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public PerCikarma()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        DataTable dt = new DataTable("CikarList");
        private void txtSearchboxPerList_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchboxPerList.Text))
            {
                searchyenile();
            }
            else
            {
                dt.Clear();
                txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand search = new SqlCommand("SELECT * FROM Personnels where PerAd like '%" + txtSearchboxPerList.Text + "%'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(search);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridCikar.DataSource = ds.Tables[0];
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void PerCikarma_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pERSONNELMODULEDataSet.PersonelListGridView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelListGridViewTableAdapter.Fill(this.pERSONNELMODULEDataSet.PersonelListGridView);
            
        }

        public void searchyenile()
        {
            dt.Clear();
            txtSearchboxPerList.Text = txtSearchboxPerList.Text.Trim();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            using (SqlDataAdapter dasearch = new SqlDataAdapter("select * from personelListGridView", baglan))
            {
                dasearch.Fill(dt);
                GridCikar.DataSource = dt;
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            txtSearchboxPerList.Clear();
        }

        int secilendeger;
        string tcno, adi, soyadi, yetki, dogumtarihi, departmanı, rol, isegirist, bulke, bsehir;
        int egitimdid;
        int adresbid;
        int departmanibid;
        int mesaibid;
        private void btnPersonnelCikar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAyrilisNedeni.Text))
            {
                this.Alert("Ayrılış Nedenini Boş Bırakılamaz.", Form_Alert.enmType.Warning);
            }
            else
            {
                try
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    //personelden silme
                    SqlCommand persil = new SqlCommand("DELETE FROM Personnels where PerTckn=@tckn", baglan);
                    persil.Parameters.AddWithValue("@tckn", tcno);
                    persil.ExecuteNonQuery();
                    //personelin adresini,mesaisini,egitimini,departmansını çekme
                    SqlCommand persilcek = new SqlCommand("SELECT PerEgitimBilgileri,Adresid,Departmanid,Mesaiid FROM Personnels where PerTckn=@tckn", baglan);
                    persilcek.Parameters.AddWithValue("@tckn", tcno);
                    SqlDataReader readercmda = persilcek.ExecuteReader();
                    // satırları oku ve değişkenlere ata
                    while (readercmda.Read())
                    {
                        egitimdid = (int)readercmda["PerEgitimBilgileri"];
                        adresbid = (int)readercmda["Adresid"];
                        departmanibid = (int)readercmda["Departmanid"];
                        mesaibid = (int)readercmda["Mesaiid"];

                    }
                    SqlCommand persilegitim = new SqlCommand("DELETE FROM Egitims where id=@eid", baglan);
                    persilegitim.Parameters.AddWithValue("@eid", egitimdid);
                    persilegitim.ExecuteNonQuery();

                    SqlCommand persiladres = new SqlCommand("DELETE FROM Adreses where id=@aid", baglan);
                    persiladres.Parameters.AddWithValue("@aid", adresbid);
                    persiladres.ExecuteNonQuery();

                    SqlCommand persildepartmans = new SqlCommand("DELETE FROM Departmans where id=@did", baglan);
                    persildepartmans.Parameters.AddWithValue("@did", departmanibid);
                    persildepartmans.ExecuteNonQuery();

                    SqlCommand persilmesaisi = new SqlCommand("DELETE FROM MesaiTakvimi where id=@mid", baglan);
                    persilmesaisi.Parameters.AddWithValue("@mid", mesaibid);
                    persilmesaisi.ExecuteNonQuery();

                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }

                    PerCikarma percikar = new PerCikarma();
                    percikar.Close();
                    PersonelList perlist = new PersonelList();
                    perlist.searchyenile();
                    this.Alert("Personel çıkarma başarılı!", Form_Alert.enmType.Success);

                }
                catch
                {
                    this.Alert("Bir şeyler ters gitti!", Form_Alert.enmType.Error);
                }
            }   
        }

        private void GridCikar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilendeger = GridCikar.SelectedCells[0].RowIndex;
            tcno = GridCikar.Rows[secilendeger].Cells[0].Value.ToString(); //tckn değişkeni alıyoruz gridden
            adi = GridCikar.Rows[secilendeger].Cells[1].Value.ToString();
            soyadi = GridCikar.Rows[secilendeger].Cells[2].Value.ToString();
            dogumtarihi = GridCikar.Rows[secilendeger].Cells[3].Value.ToString();
            departmanı = GridCikar.Rows[secilendeger].Cells[4].Value.ToString();
            rol = GridCikar.Rows[secilendeger].Cells[5].Value.ToString();
            isegirist = GridCikar.Rows[secilendeger].Cells[6].Value.ToString();
            bulke = GridCikar.Rows[secilendeger].Cells[7].Value.ToString();
            bsehir = GridCikar.Rows[secilendeger].Cells[8].Value.ToString();
        }
    }
}
