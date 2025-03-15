using System;

class Program
{
   public static void Main(string[] args)
   
    {
        /*
         * 1️⃣ Dizi (Array) Nedir? Ne İşe Yarar? Gerçek Hayattan Örnek
         *
         * Dizi (Array), aynı türde birden fazla veriyi tek bir değişken altında saklayan bir veri yapısıdır. 
         * Dizi kullanarak birden fazla veriyi yönetmek, sıralamak ve üzerinde işlemler yapmak mümkündür.
         *
         * Gerçek Hayattan Örnek:
         * Bir okulda sınıftaki öğrencilerin notlarını saklamak için ayrı ayrı değişkenler yerine bir dizi kullanılabilir.
         * 
         * Örnek:
         * int[] notlar = { 85, 90, 78, 92, 88 };
         * Bu dizide 5 öğrencinin notu saklanmaktadır.
         */

      
        int[] sayilar = new int[5];

     
        Console.WriteLine("Lütfen 5 tane sayı giriniz:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Dizinin {i + 1}. elemanını giriniz: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.WriteLine("\nGirilen Sayılar:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Eleman {i + 1}: {sayilar[i]}");
        }

        
        int enBuyuk = sayilar[0];

       
        for (int i = 1; i < sayilar.Length; i++)
        {
            if (sayilar[i] > enBuyuk)
            {
                enBuyuk = sayilar[i];
            }
        }

       
        Console.WriteLine($"\nDizideki en büyük sayı: {enBuyuk}");
    }
}
