using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLogrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null)
            {
                return DALogrenci.OgrenciEkle(p);
            }
            return -1;
        }

        
    }
}
