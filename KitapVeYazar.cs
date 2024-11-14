/* Bu örnekte,bir yazar birden fazla kitaba sahip olabilir,ancak bir kitap doğrudan yazara referans vermez.Bu yüzden Yazar sınıfı,
Kitap sınıfını bir liste olarak içerir. */

using System;
using System.Collections.Generic;

class Kitap
{
    public string Baslik { get; set; }
    public string ISBN { get; set; }

    public Kitap(string baslik, string isbn)
    {
        Baslik = baslik;
        ISBN = isbn;
    }
}

class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; } //Bu özellik,yazarın yazdığı kitapları bir liste olarak saklar.

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Yazar ve Kitap Testi
        Yazar yazar = new Yazar("Orhan Pamuk", "Türkiye");
        Kitap kitap1 = new Kitap("Kar", "9789750507106");
        Kitap kitap2 = new Kitap("Masumiyet Müzesi", "9789750507144");

        yazar.KitapEkle(kitap1);
        yazar.KitapEkle(kitap2);

        Console.WriteLine(yazar.Ad + " adlı yazarın kitapları:");
        foreach (var kitap in yazar.Kitaplar)
        {
            Console.WriteLine("- " + kitap.Baslik);
        }
    }
}
