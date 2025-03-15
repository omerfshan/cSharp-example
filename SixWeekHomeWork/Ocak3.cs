using System;

class Ocak3
{
    static void Ocak3main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi > 0)
        {
            Console.WriteLine($"{sayi} pozitif bir sayıdır.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine($"{sayi} negatif bir sayıdır.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }
    
        string sifre = "1234";
        Console.Write("Şifrenizi girin: ");
        string girilenSifre = Console.ReadLine();

        if (girilenSifre == sifre)
        {
            Console.WriteLine("Giriş başarılı!");
        }
        else
        {
            Console.WriteLine("Şifre hatalı!");
        }

    
    
    
    }
}
