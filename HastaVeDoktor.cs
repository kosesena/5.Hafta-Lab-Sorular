using System;
using System.Collections.Generic;

class Hasta
{
    public string Ad { get; set; }
    public string TCNo { get; set; }
    public Doktor Doktor { get; set; }

    public Hasta(string ad, string tcNo)
    {
        Ad = ad;
        TCNo = tcNo;
    }

    public void DoktorAtama(Doktor doktor)
    {
        Doktor = doktor;
        doktor.HastaEkle(this);
    }

    public void HastaBilgisi()
    {
        Console.WriteLine("Hasta Adı: " + Ad + ", TC No: " + TCNo + ", Doktor: " + Doktor.Ad);
    }
}

class Doktor
{
    public string Ad { get; set; }
    public string Brans { get; set; }
    public List<Hasta> Hastalar { get; set; }

    public Doktor(string ad, string brans)
    {
        Ad = ad;
        Brans = brans;
        Hastalar = new List<Hasta>();
    }

    public void HastaEkle(Hasta hasta)
    {
        if (!Hastalar.Contains(hasta))
        {
            Hastalar.Add(hasta);
        }
    }

    public void DoktorBilgisi()
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