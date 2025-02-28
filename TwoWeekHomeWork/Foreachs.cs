//foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.
// ( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)
using System;
using System.Collections.Generic;

class Foreachs
{
    static void foreachss()
    {
       
        List<int> yaslar = new List<int> { 5, 17, 25, 40, 70, 12, 19, 64, 80, 13 };
        
        foreach (int yas in yaslar)
        {
            string kategori;

            if (yas >= 0 && yas <= 12)
                kategori = "Çocuk";
            else if (yas >= 13 && yas <= 19)
                kategori = "Genç";
            else if (yas >= 20 && yas <= 64)
                kategori = "Yetişkin";
            else
                kategori = "Yaşlı";

            Console.WriteLine($"Yaş: {yas} → Kategori: {kategori}");
        }
    }
}
