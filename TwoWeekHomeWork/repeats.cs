using System;

class Repeats
{
    static void repatss()
    {
        int[] dizi = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 1, 9, 10, 6, 3 };
        int uzunluk = dizi.Length;

      
       
        for (int i = 0; i < uzunluk; i++)
        {
            for (int j = i + 1; j < uzunluk; j++)
            {
                if (dizi[i] == dizi[j]) 
                {
                  
                    bool dahaOnceYazildi = false;
                    for (int k = 0; k < i; k++)
                    {
                        if (dizi[k] == dizi[i])
                        {
                            dahaOnceYazildi = true;
                            break;
                        }
                    }

                    if (!dahaOnceYazildi) 
                    {
                        Console.WriteLine(dizi[i]);
                    }
                    break; 
                }
            }
        }
    }
}
