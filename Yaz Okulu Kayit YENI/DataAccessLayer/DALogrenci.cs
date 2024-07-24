using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALogrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            using (SqlCommand komut1 = new SqlCommand("INSERT INTO tbl_ogrenciler (OGRAD, OGRSOYAD, OGRNUMARA, OGRSIFRE) VALUES (@p1, @p2, @p3, @p4)", Baglanti.bgl))
            {
                if (komut1.Connection.State != ConnectionState.Open)
                {
                    komut1.Connection.Open();
                }

                komut1.Parameters.AddWithValue("@p1", parametre.Ad);
                komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
                komut1.Parameters.AddWithValue("@p3", parametre.Numara);
                komut1.Parameters.AddWithValue("@p4", parametre.Sifre);


                return komut1.ExecuteNonQuery();
            }
        }
    }
}
