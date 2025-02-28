using System;
//Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.
class Split
{
    static void splitss()
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

       
        string[] kelimeler = cumle.Split(' ');

       
        Array.Sort(kelimeler);

        Console.WriteLine("\nAlfabetik sıralama:");
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
    }
}
