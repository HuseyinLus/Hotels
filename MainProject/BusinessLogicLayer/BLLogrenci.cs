using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLogrenci
    {
        public static int OgrenciEkleBLL(EntityStudent p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null)
            {
                return DALstudents.OgrenciEkle(p);
            }
            return 0;
        }
    }
}
