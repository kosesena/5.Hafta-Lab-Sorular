using System;
using System.Collections.Generic;

class Urun
{
    public string Ad { get; set; }
    public int Fiyat { get; set; }

    public Urun(string ad, int fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public void UrunBilgisi()
    {
        Console.WriteLine("Ürün Adı: " + Ad + ", Fiyat: " + Fiyat);
    }
}

class Siparis
{
    public DateTime Tarih { get; set; }
    public decimal Toplam { get; private set; }
    public List<Urun> Urunler { get; set; }

    public Siparis(DateTime tarih)
    {
        Tarih = tarih;
        Urunler = new List<Urun>();
        Toplam = 0;
    }

    public void UrunEkle(Urun urun)
    {
        Urunler.Add(urun);
        Toplam += urun.Fiyat;
    }

    public void SiparisBilgisi()
    {
        Console.WriteLine("Sipariş Tarihi: " + Tarih);
        Console.WriteLine("Sipariş Toplamı: " + Toplam);
        Console.WriteLine("Siparişteki Ürünler:");
        foreach (var urun in Urunler)
        {
            urun.UrunBilgisi();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Ürün oluşturma
        Urun urun1 = new Urun("Laptop", 5000);
        Urun urun2 = new Urun("Mouse", 150);
        Urun urun3 = new Urun("Klavye", 250);

        // Sipariş oluşturma ve ürünleri ekleme
        Siparis siparis = new Siparis(DateTime.Now);
        siparis.UrunEkle(urun1);
        siparis.UrunEkle(urun2);
        siparis.UrunEkle(urun3);

        // Sipariş bilgilerini gösterme
        siparis.SiparisBilgisi();
    }
}