namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private int id;
        private string soyad;
        private string numara;
        private string sifre;
        private double bakiye;
        public string Ad { get => ad; set => ad = value; }
        public int Id { get => id; set => id = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
    }
}
