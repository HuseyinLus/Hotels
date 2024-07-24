namespace EntityLayer
{
    public class EntityStudent
    {
        private string ad;
        private string soyad;
        private string numara;
        private string sifre;
        private int id;
        private double bakiye;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public int Id { get => id; set => id = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
    }
}
