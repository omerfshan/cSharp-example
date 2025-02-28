using System;
//while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız
// (Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)

class Whileess
{
    static void whiles()
    {
        int number;
       

        while (!int.TryParse(Console.ReadLine(), out number) || number < 10 || number > 100)
        {
            Console.WriteLine("Hatalı giriş! Lütfen 10 ile 100 arasında bir sayı girin.");
            Console.Write("Tekrar deneyin: ");
        }

        Console.WriteLine($"Teşekkürler! Girilen sayı: {number}");
    }
}
