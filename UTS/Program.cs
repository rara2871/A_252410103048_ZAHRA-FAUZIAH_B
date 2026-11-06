internal class Program
{
    private static void Main(string[] args)
    {
        Agen Agen1 = new Agen { idAgen = "agn1", namaAgen = "jaya", stokAgen = 40 };
        Agen Agen2 = new Agen { idAgen = "agn2", namaAgen = "joyo", stokAgen = 30 };

        Agen1.Tampilinfo(Agen1.idAgen, Agen1.namaAgen, Agen1.stokAgen);
        Agen1.Tampilinfo(Agen2.idAgen, Agen2.namaAgen, Agen2.stokAgen);

        GalonAkua GalonAkua1 = new GalonAkua();
        GalonBerkeran GalonBerkeran1 = new GalonBerkeran ();

        GalonBerkeran1.HitungBiaya(30);
        GalonAkua1.HitungBiaya(30);

        GalonAkua1.KurangiStok(GalonAkua.stokGudang, 40);

        DisribusikanGalon disribusikanGalon1 = new DisribusikanGalon ();

        disribusikanGalon1.TampilkanAgen();
    }
}

public class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public void Tampilinfo(string idAgen, string namaAgen, int stokAgen)
    {
        Console.WriteLine($" Agen {namaAgen} memiliki informasi, id : {idAgen}, Nama : {namaAgen}, stok : {stokAgen}");
    }
}

public class ProdukGalon
{
    private string idProduk;
    private string namaProduk;
    private int stokGudang;

    public void KurangiStok(int stokGudang, int jumlah)
    {
        Console.WriteLine($"{stokGudang - jumlah}");
    }

    public abstract void HitungBiaya(int jumlah) { }
}

public class GalonAkua : ProdukGalon
{
    public override void HitungBiaya(int jumlah)
    {
        Console.WriteLine($"GalonAkua : {jumlah * 20.000}");
    }

}

public class GalonBerkeran : ProdukGalon
{
    public override void HitungBiaya(int jumlah)
    {
        Console.WriteLine($"GalonBerkeran : {jumlah * 12.000}");
    }
}

public class DisribusikanGalon
{
    public List<Agen> agens;
    public void TampilkanAgen(string namaAgen, string namaProduk, int jumlah, int stokGudang)
    {
        foreach (Agen agen in agens)
        {
            Console.WriteLine($"nama agen : {namaAgen}");
            Console.WriteLine($"prodyk yang dikirim : {namaProduk}");
            Console.WriteLine($"jumlah yang dikirim : {jumlah > 0}");
        }
    }
}

public class SindikatGalon
{
    public List<Agen> agens;
    public void TambahAgen(Agen agen)
    {

    }
}