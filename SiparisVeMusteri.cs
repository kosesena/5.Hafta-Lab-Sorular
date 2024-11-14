using System;
using System.Collections.Generic;

class Siparis
{
    public DateTime Tarih { get; set; }
    public string Durum { get; set; }

    public Siparis(DateTime tarih, string durum)
    {
        Tarih = tarih;
        Durum = durum;
    }

    public void SiparisBilgisi()
    {
        Console.WriteLine("Sipariş Tarihi: " + Tarih + ", Durum: " + Durum);
    }
}

class Musteri
{
    public string Ad { get; set; }
    public string Telefon { get; set; }
    public List<Siparis> Siparisler { get; set; }

    public Musteri(string ad, string telefon)
    {
        Ad = ad;
        Telefon = telefon;
        Siparisler = new List<Siparis>();
    }

    public void SiparisVer(Siparis siparis)
    {
        Siparisler.Add(siparis);
    }

    public void MusteriBilgisi()
    {
        Console.WriteLine("Müşteri Adı: " + Ad + ", Telefon: " + Telefon);
        Console.WriteLine("Siparişler:");
        foreach (var siparis in Siparisler)
        {
            siparis.SiparisBilgisi();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Müşteri oluşturma
        Musteri musteri = new Musteri("Sena Köse", "123-456-7890");

        // Siparişler oluşturma
        Siparis siparis1 = new Siparis(DateTime.Now, "Hazırlanıyor");
        Siparis siparis2 = new Siparis(DateTime.Now.AddDays(-2), "Tamamlandı");

        // Müşteriye siparişleri ekleme
        musteri.SiparisVer(siparis1);
        musteri.SiparisVer(siparis2);

        // Müşteri bilgilerini ve siparişleri gösterme
        musteri.MusteriBilgisi();
    }
}
