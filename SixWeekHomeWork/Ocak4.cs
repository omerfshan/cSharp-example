/*Döngüler, belirli bir koşul sağlandığı sürece kodun tekrar çalıştırılmasını sağlar. Programlamada en yaygın kullanılan döngü türleri for ve while döngüleridir.

For Döngüsü: Belirli bir başlangıç, bitiş ve artış miktarı olduğu durumlarda kullanılır. Genellikle belirli bir sayıda tekrarlanması gereken işlemler için tercih edilir.
While Döngüsü: Koşul sağlandığı sürece çalışmaya devam eder. Genellikle tekrar sayısının baştan bilinmediği veya belirli bir koşul sağlanana kadar devam etmesi gereken işlemler için kullanılır.*/
class Ocak4{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.Write("Bir sayı giriniz: ");
        int n = int.Parse(Console.ReadLine());
        int toplam = 0;

        for (int i = 1; i <= n; i++)
        {
            toplam += i;
        }

        Console.WriteLine($" birden {n}'e kadar olan sayıların toplamı: {toplam}");
    }
}