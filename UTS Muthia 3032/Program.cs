using MBG;

internal class Program
{
    private static void Main(string[] args)
    {
        Sekolah pertama = new Sekolah("01", "Petra", 40);
        pertama.TampilInfo();
        Sekolah kedua = new Sekolah("02", "Nusa", 40);
        kedua.TampilInfo();
        PaketReguler ayam = new PaketReguler(20, "nasi, ayam, sayur, dan buah", 15000);
        ayam.tampilharga();
        PaketKhusus steak = new PaketKhusus(20, 20000, "nasi, ayam, sayur, dan buah", "Rendah Gula, Vegetarian atau Bebas Gluten");
        steak.tampilhargaa(); 
    }
}

namespace MBG
{
    public class Sekolah
    {
        public string idSekolah { get; set; }
        public string namaSekolah { get; set; }
        public int jumlahPaketDiterima { get; set; }

        public Sekolah(string idsekolah, string namasekolah, int jumlahpaketditerima)
        {
            idSekolah = idsekolah;
            namaSekolah = namasekolah;
            jumlahPaketDiterima = jumlahpaketditerima;
        }
        public void TampilInfo()
        {
            Console.WriteLine($"Sekolah dengan id {idSekolah} bernama sekolah {namaSekolah} dan jumlah paket makanan yang diterima adalah {jumlahPaketDiterima}");
        }
    }
    public class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;
        // get id_paket;
        //    set;
        //{
        //    if()
        //} jujur ini lupa mas :(
        private PaketMBG (string idpaket, string namapaket, int stokdapur)
        {
            idPaket = idpaket; 
            namaPaket = namapaket;
            stokDapur = stokdapur;
        }
        public virtual void Paket()
        {
            Console.WriteLine($"stok dapur adalah {stokDapur}");
        }
    }
    //ekapsulasinya blm
    public class PaketReguler : PaketMBG
    {
        public int Jumlah { get; set; }
        public int Harga{ get; set; }
        public string isiPaket { get; set; }
        public PaketReguler(int harga, string isipaket, int jumlah) : base() //mas ini eror, lupa base ini harusnya disambungin kemana...
        {
            Harga = harga;
            isiPaket = isipaket;
            Jumlah = jumlah;
        }
        public override void Paket()
        {
            Console.WriteLine($"Paket makanan bergizi dengan harga {Harga} per paket. Paket ini berisi {isiPaket}");
        }
        public void tampilharga()
        {
            Console.WriteLine($"PaketReguler: {Jumlah * Harga}");
        }
    }

    public class PaketKhusus : PaketMBG
    {
        public int Jumlahh { get; set; }
        public int Hargaa { get; set; }
        public string isiPakett { get; set; }
        public string jenisDiet{  get; set; }
        public PaketKhusus(int jumlahh, int hargaa, string isipakett, string jenisdiet) : base() //mas ini eror, lupa base ini harusnya disambungin kemana...
        {
            Jumlahh = jumlahh;
            Hargaa = hargaa;
            isiPakett = isipakett;
            jenisDiet = jenisdiet;
        }
        public override void Paket()
        {
            Console.WriteLine($"Paket makanan dengan harga {Hargaa} per paket. Paket ini disediakan bagi siswa yang memiliki jenis diet, misalnya {jenisDiet}. {isiPakett}");
        }
        public void tampilhargaa()
        {
            Console.WriteLine($"PaketKhusus: {Jumlahh * Hargaa}");
        }
    }
}
