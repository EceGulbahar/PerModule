using PerModule.Forms.PersonelListForm.PersonCardDrop;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PerModule.Classes
{
    public class ToplamGun
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public int ToplamGunSayisi;

        public int Toplamgunhesapla(int personelinidsi, int donemi, int yili)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            string query = "SELECT COUNT(*) FROM Mesai where Personnelid=@Personnelid and DonemAy=@da and DonemYil=@dy and OdenmeDurumu=@od";
            using (SqlCommand tgunhesapla = new SqlCommand(query, baglan))
            {
                // Sorgu parametrelerini ekle
                tgunhesapla.Parameters.AddWithValue("@Personnelid", personelinidsi);
                tgunhesapla.Parameters.AddWithValue("@da", donemi);
                tgunhesapla.Parameters.AddWithValue("@dy", yili);
                tgunhesapla.Parameters.AddWithValue("@od", "Ödendi");
                // Sorgu sonuçlarını oku
                using (SqlDataReader tgunoku = tgunhesapla.ExecuteReader())
                {
                    if (tgunoku.Read())
                    {
                        ToplamGunSayisi = tgunoku.GetInt32(0);
                    }
                }
            }
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
            return ToplamGunSayisi;
        }
    }
}
