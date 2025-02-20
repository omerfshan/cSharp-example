using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {//5-Şifre Güçlülüğünü Kontrol Etme (if-else) 
        Console.Write("Lütfen bir şifre girin: ");
        string sifre = Console.ReadLine();

        if (sifre.Length < 8)
        {
            Console.WriteLine("Şifreniz zayif En az 8 karakter uzunluğunda olmalidir.");
            return;
        }

       
        if (!Regex.IsMatch(sifre, "[A-Z]"))
        {
            Console.WriteLine("Şifreniz zayif En az bir büyük harf içermelidir.");
            return;
        }

       
        if (!Regex.IsMatch(sifre, "[@#$%]"))
        {
            Console.WriteLine("Şifreniz zayif En az bir özel karakter içermelidir");
            return;
        }

        
        Console.WriteLine("Güçlü bir şifre girdin.");
    }
}
