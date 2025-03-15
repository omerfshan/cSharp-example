using System;  

class Ocak2
{
    static void Ocak2Main()
    {
        /*
         * C#’ta Kullanılan Temel Veri Tipleri:
         * 
         * int      - Tam sayıları saklar (32 bit)    -> int x = 10;
         * double   - Ondalıklı sayıları saklar (64 bit)  -> double y = 5.5;
         * float    - Ondalıklı sayıları saklar (32 bit)  -> float z = 3.14f;
         * decimal  - Yüksek hassasiyetli ondalık sayı (128 bit)  -> decimal d = 10.25m;
         * char     - Tek bir karakter saklar  -> char c = 'A';
         * string   - Metin (kelime ve cümle) saklar  -> string name = "Mehmet";
         * bool     - true veya false değeri saklar  -> bool isActive = true;
         */

        /*
         * Değişkenlerin Bellek Kullanımı Karşılaştırması:
         * 
         * C#’ta değişkenlerin bellekte kapladıkları alan sabittir ve aşağıdaki gibidir:
         * 
         * int x = 5;         // 4 byte (32 bit)
         * double y = 5.2;    // 8 byte (64 bit)
         * string name = "Mehmet"; // Değişkendir, karakter sayısına bağlıdır
         * 
         * Bellek Kullanımı Tablosu:
         * --------------------------------------
         * Değişken | Veri Tipi | Bellek Kullanımı
         * --------------------------------------
         * x        | int       | 4 byte
         * y        | double    | 8 byte
         * name     | string    | Karakter sayısına göre değişir, en az 20+ byte
         * --------------------------------------
         */

       
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

   
        double toplam = sayi1 + sayi2;

      
        Console.WriteLine("Girilen sayıların toplamı: " + toplam);
    }
}
