using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerModule.Classes
{
    public class ToplamIzin
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public int ToplamIzinSayisi;

        public int ToplamIzinhesapla(int personelinidsi, int donemi, int yili)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            string query = "SELECT COUNT(*) FROM Izin where Personnelid=@Personnelid and DonemAy=@da and DonemYil=@dy";
            using (SqlCommand tizinhesapla = new SqlCommand(query, baglan))
            {
                // Sorgu parametrelerini ekle
                tizinhesapla.Parameters.AddWithValue("@Personnelid", personelinidsi);
                tizinhesapla.Parameters.AddWithValue("@da", donemi);
                tizinhesapla.Parameters.AddWithValue("@dy", yili);
                // Sorgu sonuçlarını oku
                using (SqlDataReader tgunoku = tizinhesapla.ExecuteReader())
                {
                    if (tgunoku.Read())
                    {
                        ToplamIzinSayisi = tgunoku.GetInt32(0);
                    }
                }
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            return ToplamIzinSayisi;
        }
    }
}
