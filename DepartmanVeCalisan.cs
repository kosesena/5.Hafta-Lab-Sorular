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
    public Departman Departman { get; set; } // Çalışanın bağlı olduğu Departman nesnesi için Departman türünde bir özellik vardır.

    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }

    public void DepartmanAtama(Departman departman) // Çalışanın bağlı olduğu departmanı atamak için kullanılır.
    {
        Departman = departman;
    }
}

class Program
{
    static void Main(string[] args) // Bu metod, C# programının çalışmaya başladığı yerdir.
    {
        // Çalışan ve Departman ilişkilerini test etmek için kod örnekleri ekledik.
        Departman departman = new Departman("Yazılım Geliştirme", "İstanbul");
        Calisan calisan = new Calisan("Sena", "Yazılım Mühendisi");

        calisan.DepartmanAtama(departman);

        Console.WriteLine(calisan.Ad + " adlı çalışan " + calisan.Departman.Ad + " departmanında çalışmaktadır.");
    }
}
