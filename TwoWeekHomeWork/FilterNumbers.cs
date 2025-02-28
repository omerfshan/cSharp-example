//Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.
using System;
using System.Collections.Generic;

class FilterNumbers
{
    static void filters()
    {
        List<int> sayilar = new List<int> { 5, 12, 8, 20, 3, 15, 9, 25, 7, 30 };

        Console.WriteLine("Orijinal liste: " + string.Join(", ", sayilar));

        // 10’dan küçük olanları kaldırma
        sayilar.RemoveAll(sayi => sayi < 10);

        Console.WriteLine("Filtrelenmiş liste (10 ve üzeri sayılar): " + string.Join(", ", sayilar));
    }
}

