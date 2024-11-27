
using LinqJoinPratik1;

public class Program
{

    public static void Main(string[] args)
    {
        List<Yazarlar> yazarlars = new List<Yazarlar>();

        yazarlars.Add(new Yazarlar { AuthorID = 1 , Name = "Orhan Pamuk"});
        yazarlars.Add(new Yazarlar { AuthorID = 2, Name = "Elif Şafak" });
        yazarlars.Add(new Yazarlar { AuthorID = 3, Name = "Ahmet Ümit" });

        List<Kitaplar> kitaplars = new List<Kitaplar>();

        kitaplars.Add(new Kitaplar { BookID = 1, Title = "Kar", BAuthorID = 1 });
        kitaplars.Add(new Kitaplar { BookID = 2, Title = "İstanbul", BAuthorID = 1 });
        kitaplars.Add(new Kitaplar { BookID = 3, Title = "10 Minutes 38 Seconds This Strange World", BAuthorID = 2 });
        kitaplars.Add(new Kitaplar { BookID = 4, Title = "Beyoğlu Rapsodisi", BAuthorID = 3 });

        var KitaplarveYazarlar = kitaplars.Join(yazarlars,
                                                   kitap => kitap.BAuthorID,
                                                   yazar => yazar.AuthorID,
                                                   (kitap, yazar) => new
                                                   {
                                                       kitapname = kitap.Title,
                                                       yazarname = yazar.Name
                                                   });

        foreach (var kitap in  KitaplarveYazarlar)
        {
            Console.WriteLine($"Kitabın Adı {kitap.kitapname} - - -Yazarın Adı {kitap.yazarname}");
        }


    }


    


}