using System;
//For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.
class Sum
{
    static void Summs()
    {
        int sum = 0;

        for (int i = 0; i < 10; i++)
        { int number = int.Parse(Console.ReadLine());
        

            sum += number; 
        }

        Console.WriteLine($"Rakamların toplamı: {sum}");
    }
}
