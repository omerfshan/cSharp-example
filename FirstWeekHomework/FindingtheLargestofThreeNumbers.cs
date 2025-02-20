using System;

class FindingtheLargestofThreeNumbers
{
    static void Largest()
    //main
    {
        
    double enBuyuk;
       
        Console.Write("Birinci sayiyi girin: ");
        if (!double.TryParse(Console.ReadLine(), out double sayi1))
        {
            Console.WriteLine("Geçersiz");
            return;
        }

        Console.Write("İkinci sayiyi girin ");
        if (!double.TryParse(Console.ReadLine(), out double sayi2))
        {
            Console.WriteLine("Geçersiz");
            return;
        }

        Console.Write("Üçüncü sayiyi girin: ");
        if (!double.TryParse(Console.ReadLine(), out double sayi3))
        {
            Console.WriteLine("Geçersiz");
            return;
        }

        
        

        if (sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            enBuyuk = sayi1;
        }
        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
        {
            enBuyuk = sayi2;
        }
        else
        {
            enBuyuk = sayi3;
        }

        Console.WriteLine($"En büyük sayi: {enBuyuk}");
    }
}
