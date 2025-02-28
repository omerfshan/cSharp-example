using System;
using System.Collections.Generic;
using System.Linq;
//Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve 
// bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

class NumProces
{
    static void Numberpr()
    {
        List<int> sayilar = new List<int>();
        string giris;
        
        Console.WriteLine("Sayıları girin (Çıkış için 'exit' yazın):");

        
        giris = Console.ReadLine();
        while (giris.ToLower() != "exit")
        {
            if (int.TryParse(giris, out int sayi))
            {
                sayilar.Add(sayi);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }

            giris = Console.ReadLine(); 
        }

        if (sayilar.Count == 0)
        {
            Console.WriteLine("Hiçbir sayı girilmedi.");
            return;
        }

        
        double ortalama = sayilar.Average();

       
        sayilar.Sort();

        Console.WriteLine($"\nGirilen sayıların ortalaması: {ortalama:F2}");
        Console.WriteLine("Küçükten büyüğe sıralanmış sayılar: " + string.Join(", ", sayilar));
    }
}
