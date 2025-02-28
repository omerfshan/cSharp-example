//Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.
using System;
using System.Collections.Generic;
using System.Linq;

class UpdateGrades
{
    static void Main()
    {
        List<int> notlar = new List<int> { 45, 78, 32, 90, 50, 49, 20, 85, 60, 48 };

        Console.WriteLine("Orijinal notlar: " + string.Join(", ", notlar));

        notlar = notlar.Select(n => n < 50 ? 50 : n).ToList();

        Console.WriteLine("Güncellenmiş notlar: " + string.Join(", ", notlar));
    }
}
