using Patikafy;


using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        List<AlbumList> sarkicilar = new List<AlbumList>()
        {
            new AlbumList {AdSoyad =  "Ajda Pekkan", MuzikTur = "Pop" , CikisYili = 1968 , satislar = 20},
            new AlbumList {AdSoyad =  "Sexen Aksu", MuzikTur = "Türk Halk Müziği / Pop" , CikisYili = 1971 , satislar = 10},
            new AlbumList {AdSoyad =  "Funda Arar", MuzikTur = "Pop" , CikisYili = 1999, satislar = 3},
            new AlbumList {AdSoyad =  "Sertap Erener", MuzikTur = "Pop" , CikisYili = 1994 , satislar = 5},
            new AlbumList {AdSoyad =  "Sıla", MuzikTur = "Pop" , CikisYili = 2009 , satislar = 3},
            new AlbumList {AdSoyad =  "Serdar Ortaç", MuzikTur = "Pop" , CikisYili = 1994 , satislar = 10},
            new AlbumList {AdSoyad =  "Tarkan", MuzikTur = "Pop" , CikisYili = 1992 , satislar = 40},
            new AlbumList {AdSoyad =  "Hande Yener", MuzikTur = "Pop" , CikisYili = 1999 , satislar = 7},
            new AlbumList {AdSoyad =  "Hadise", MuzikTur = "Pop" , CikisYili = 2005 , satislar = 5},
            new AlbumList {AdSoyad =  "Gülben Ergen", MuzikTur = "Pop / Halk Müziği" , CikisYili = 1997 , satislar = 10},
            new AlbumList {AdSoyad =  "Neşet Ertaş", MuzikTur = "Türk Halk Müziği / Türk Sanat Müziği" , CikisYili = 1960 , satislar = 2}
        };

        var svasharf = sarkicilar.Where(s => s.AdSoyad.StartsWith("S"));
        var onuzerisatis = sarkicilar.Where(satislar => satislar.satislar > 10);
        var filter3 = sarkicilar.Where(f3 => f3.CikisYili < 2000 && f3.MuzikTur == "Pop").OrderBy(f3 => f3.AdSoyad).GroupBy(f3 => f3.CikisYili);
        
        int maxsatis = sarkicilar.Max(f5 => f5.satislar);
        var maxsatisyapan = sarkicilar.FirstOrDefault(f5 => f5.satislar == maxsatis);

        int enyeni = sarkicilar.Max(f6 => f6.CikisYili);
        var enyenicikis = sarkicilar.FirstOrDefault(f5 => f5.satislar == enyeni);

        Console.WriteLine("Adı S ile Başlayan");
        foreach (var albumList in svasharf)
        {
            Console.WriteLine(albumList.AdSoyad);
        }
        Console.WriteLine("-*-*-*-*-*-*-*-");
        Console.WriteLine("10 Milyon Üzeri Satış Yapanlar");
        foreach (var albumList in onuzerisatis)
        {
            Console.WriteLine(albumList.AdSoyad);
        }
        Console.WriteLine("-*-*-*-*-*-*-*-");
        Console.WriteLine("2000 Yılı Öncesi Çıkış Yapan Pop Sanatçıları");
        foreach (var grup in filter3)
        {
            Console.WriteLine(grup.Key);
            foreach (var albumList in grup)
            {
                Console.WriteLine(albumList.AdSoyad);
            }

        }

        Console.WriteLine("-*-*-*-*-*-*-*-");
        Console.WriteLine($"En Çok Albüm Satan Sanatçı: {maxsatisyapan.AdSoyad} ");

        Console.WriteLine("-*-*-*-*-*-*-*-");
        Console.WriteLine($"En Yeni Çıkış Yapan Sanatçı: {enyenicikis} ");






    }
}