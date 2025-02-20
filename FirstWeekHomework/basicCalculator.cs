using System;

class basicCalculator
{//3-Basit Hesap Makinesi (switch-case)

    static void calculator()
    //main
    {
       
        Console.Write("Birinci sayiyi girin: ");
        
        if (!double.TryParse(Console.ReadLine(), out double sayi1))
        {
            Console.WriteLine("Geçersiz");
            return;
        }

        Console.Write("İkinci sayiyi girin: ");
        if (!double.TryParse(Console.ReadLine(), out double sayi2))
        {
            Console.WriteLine("Geçersiz");
            return;
        }

        Console.WriteLine("İşlem seçin: +, -, *, /");
        char islem = Console.ReadKey().KeyChar;
        Console.WriteLine(); 
        double sonuc;
        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
                break;
            case '/':
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hata! sayi sifira  bölünemez.");
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
                }
                break;
            default:
                Console.WriteLine("Geçersiz");
                break;
        }
    }
}
