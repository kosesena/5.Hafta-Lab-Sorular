/* Bu örnekte, bir doktorun birden fazla hastası olabilirken,her hastanın yalnızca bir doktora bağlı olduğu bir ilişki modellemesi
yapılmıştır.Bu ilişkiyi kodlamak için Doktor ve Hasta sınıflarını tanımlayacağız.Doktor sınıfı,birden fazla Hasta nesnesine sahip olacak 
şekilde bir liste içerir.Hasta sınıfı ise bir Doktor nesnesine referans içerir. */

using System;
using System.Collections.Generic;

class Hasta
{
    public string Ad { get; set; }
    public string TCNo { get; set; }
    public Doktor Doktor { get; set; } // Hastanın bağlı olduğu doktoru referans olarak saklar.

    public Hasta(string ad, string tcNo)
    {
        Ad = ad;
        TCNo = tcNo;
    }

    public void DoktorAtama(Doktor doktor) // Hastaya doktor atar ve aynı zamanda doktorun hasta listesine de hastayı ekler.
    {
        Doktor = doktor;
        doktor.HastaEkle(this);
    }

    public void HastaBilgisi() // Hastanın adını,kimlik numarasını ve bağlı olduğu doktorun adını ekrana yazdırır.
    {
        Console.WriteLine("Hasta Adı: " + Ad + ", TC No: " + TCNo + ", Doktor: " + Doktor.Ad);
    }
}

class Doktor
{
    public string Ad { get; set; } // Doktorun adını saklar.
    public string Brans { get; set; } // Doktorun branşını saklar.
    public List<Hasta> Hastalar { get; set; } // Doktorun hastalarını saklayan bir List<Hasta>

    public Doktor(string ad, string brans)
    {
        Ad = ad;
        Brans = brans;
        Hastalar = new List<Hasta>();
    }

    public void HastaEkle(Hasta hasta) // Doktorun hasta listesine yeni bir hasta ekler.
    {
        if (!Hastalar.Contains(hasta))
        {
            Hastalar.Add(hasta);
        }
    }

    public void DoktorBilgisi() // Doktorun adını,branşını ve hastaların listesini ekrana yazdırır.
    {
        Console.WriteLine("Doktor Adı: " + Ad + ", Branş: " + Brans);
        Console.WriteLine("Hastalar:");
        foreach (var hasta in Hastalar)
        {
            Console.WriteLine("- " + hasta.Ad);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Doktor oluşturma
        Doktor doktor = new Doktor("Dr. Ali", "Kardiyoloji");

        // Hastalar oluşturma
        Hasta hasta1 = new Hasta("Ayşe Yılmaz", "12345678901");
        Hasta hasta2 = new Hasta("Mehmet Kaya", "98765432109");

        // Hastalara doktor atama
        hasta1.DoktorAtama(doktor);
        hasta2.DoktorAtama(doktor);

        // Doktor ve hastaların bilgilerini gösterme
        doktor.DoktorBilgisi();
        Console.WriteLine();

        // Her hasta için detaylı bilgi
        hasta1.HastaBilgisi();
        hasta2.HastaBilgisi();
    }
}
