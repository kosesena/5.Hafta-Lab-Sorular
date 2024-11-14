/* Bu örnekte,bir çalışan bir departmana ait olabilir,ancak departman doğrudan çalışana referans vermez. Çalışan sınıfı,
Departman sınıfını bir özellik olarak içerir. */

using System;

class Departman
{
    public string Ad { get; set; }
    public string Lokasyon { get; set; }

    public Departman(string ad, string lokasyon)
    {
        Ad = ad;
        Lokasyon = lokasyon;
    }
}

class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }
    public Departman Departman { get; set; }

    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }

    public void DepartmanAtama(Departman departman)
    {
        Departman = departman;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Çalışan ve Departman Testi
        Departman departman = new Departman("Yazılım Geliştirme", "İstanbul");
        Calisan calisan = new Calisan("Sena", "Yazılım Mühendisi");

        calisan.DepartmanAtama(departman);

        Console.WriteLine(calisan.Ad + " adlı çalışan " + calisan.Departman.Ad + " departmanında çalışmaktadır.");
    }
}
