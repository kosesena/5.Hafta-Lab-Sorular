using System;
using System.Collections.Generic;

class Kitap
{
    public string Baslik { get; set; }
    public DateTime YayınTarihi { get; set; }
    public Yazar Yazar { get; private set; }

    public Kitap(string baslik, DateTime yayinTarihi)
    {
        Baslik = baslik;
        YayınTarihi = yayinTarihi;
    }

    public void YazarAtama(Yazar yazar)
    {
        Yazar = yazar;
        yazar.KitapEkle(this);
    }

    public void KitapBilgisi()
    {
        Console.WriteLine("Kitap Başlığı: " + Baslik + ", Yayın Tarihi: " + YayınTarihi.ToShortDateString() + ", Yazar: " + Yazar.Ad);
    }
}

class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        if (!Kitaplar.Contains(kitap))
        {
            Kitaplar.Add(kitap);
        }
    }

    public void YazarBilgisi()
    {
        Console.WriteLine("Yazar Adı: " + Ad + ", Ülke: " + Ulke);
        Console.WriteLine("Yazdığı Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine("- " + kitap.Baslik);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Yazar oluşturma
        Yazar yazar = new Yazar("Orhan Pamuk", "Türkiye");

        // Kitaplar oluşturma
        Kitap kitap1 = new Kitap("Kar", new DateTime(2002, 1, 1));
        Kitap kitap2 = new Kitap("Masumiyet Müzesi", new DateTime(2008, 5, 1));

        // Kitaplara yazar atama
        kitap1.YazarAtama(yazar);
        kitap2.YazarAtama(yazar);

        // Yazar ve kitapların bilgilerini gösterme
        yazar.YazarBilgisi();
        Console.WriteLine();

        // Her kitap için detaylı bilgi
        kitap1.KitapBilgisi();
        kitap2.KitapBilgisi();
    }
}