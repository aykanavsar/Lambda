public class Program
{
    public static void Main(string[] args)
    {
        List<int> sayilar = new List<int>() { 152, 154, 54, 55, 63, 59, 4521, 3, 5, 71,-5,-9,-989,-233,-366,-1 };

        var ciftsayi = sayilar.Where(sayi => sayi % 2 == 0);
        Console.WriteLine("Çift Sayılar Aşağıda ki Gibidir. ");
        var teksayi = sayilar.Where(sayi => sayi % 2  == 1);
        var negatifler = sayilar.Where(sayi => sayi < 0);
        var pozitifler = sayilar.Where(sayi => sayi > 0);   
        var aradakiler = sayilar.Where(sayi => sayi > 15 && sayi < 22);

        var kareleri = sayilar.Select(sayi => sayi * sayi ).ToList();
        
        foreach (int i in ciftsayi)
        {
            
            Console.WriteLine(i);

        }
        Console.WriteLine("----------");
        Console.WriteLine("Tek Sayılar Aşağıda ki gibidir.");

        foreach (int i in teksayi)
        {

            Console.WriteLine(i);

        }

        Console.WriteLine("----------");
        Console.WriteLine("Negatif Sayılar Aşağıda ki gibidir.");
        
        foreach (int i in negatifler)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------");
        Console.WriteLine("Pozitif Sayılar Aşağıda ki gibidir.");

        foreach (int i in pozitifler)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------");
        Console.WriteLine("15 ile 22 Arasında ki  Sayılar Aşağıda ki gibidir.");

        foreach (int i in aradakiler)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------");
        Console.WriteLine("Kareler Sayılar Aşağıda ki gibidir.");

        foreach (int kare in kareleri)
        {
            Console.WriteLine(kare);
        }





    }

}