using System;
//1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else)
class numbering
{
    static void Number()
    //main
    {
        Console.Write("sayi giriniz: ");
        int sayi;

        
        bool basarili = int.TryParse(Console.ReadLine(), out sayi);

        if (!basarili)
        {
            Console.WriteLine("Geçersiz");
        }
        else if (sayi > 0)
        {
            Console.WriteLine("pozitiftir.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("negatiftir.");
        }
        else
        {
            Console.WriteLine("sifirdir.");
        }
    }
}
