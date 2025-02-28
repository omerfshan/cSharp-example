using System;
//Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.
class Size
{
    static void Resize()
    {
        string[] kelimeler = new string[3]; 
        int elemanSayisi = 0;

        while (true)
        {
            string giris = Console.ReadLine();

            if (giris.ToLower() == "exit")
                break;

       
            if (elemanSayisi >= kelimeler.Length)
            {
                Array.Resize(ref kelimeler, kelimeler.Length + 3); 
            }

            kelimeler[elemanSayisi] = giris;
            elemanSayisi++;
        }

        Console.WriteLine("\nGirilen kelimeler:");
        for (int i = 0; i < elemanSayisi; i++)
        {
            Console.WriteLine(kelimeler[i]);
        }
    }
}
