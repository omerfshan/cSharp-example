
using System;

class DeterminingtheDayName
{
    //2: Gün İsmi Belirleme (switch-case)
    static void Days()
    //main
    {
        Console.Write("sayi giriniz");

       
        if (int.TryParse(Console.ReadLine(), out int gun))
        {
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Sali");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz");
        }
    }
}
