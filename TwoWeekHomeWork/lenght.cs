//Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.
using System;

class Lenght
{
    static void lenghts()
    {
        string[] kelimeler = { "elma", "armut", "kiraz", "karpuz", "muz", "çilek", "ananas" };

        
        string enKisa = kelimeler[0];
        string enUzun = kelimeler[0];

        foreach (string kelime in kelimeler)
        {
            if (kelime.Length < enKisa.Length) 
                enKisa = kelime;

            if (kelime.Length > enUzun.Length) 
                enUzun = kelime;
        }

        Console.WriteLine($"En kısa kelime: {enKisa}");
        Console.WriteLine($"En uzun kelime: {enUzun}");
    }
}
