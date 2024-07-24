using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLogrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Sifre != null)
            {
                return DALogrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}
