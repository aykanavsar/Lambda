using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Patikaflix
    {
        public class Film
        {
            public string DiziAdi { get; set; }
            public int YapimYili { get; set; }
            public string Tur { get; set; }
            public int YayinYili { get; set; }
            public string Yonetmen { get; set; }
            public string Kanal { get; set; }

        }

        

        static void Main()
        {
            List<Film> filmlist = new List<Film>();

            while (true)
            {
                Console.WriteLine("Listenize Bir Dizi Eklemek İster misiniz ?/n Evet/Hayır");
                string cevap = Console.ReadLine().ToLower();
                if (cevap == "hayır") break;

                Film YeniDizi = new Film();
                
                Console.WriteLine("Dizi Adı: ");
                YeniDizi.DiziAdi = Console.ReadLine();

                Console.WriteLine("Yapim Yılı: ");
                YeniDizi.YapimYili = int.Parse(Console.ReadLine());

                Console.WriteLine("Türü: ");
                YeniDizi.Tur = Console.ReadLine();

                Console.WriteLine("Yayın Yılı: ");
                YeniDizi.YayinYili = int.Parse(Console.ReadLine());

                Console.WriteLine("Yönetmen: ");
                YeniDizi.Yonetmen = Console.ReadLine();

                Console.WriteLine("Kanal: ");
                YeniDizi.Kanal = Console.ReadLine();

                filmlist.Add(YeniDizi);




            }

            Console.WriteLine("Ekeldiğiniz Dizilerin Listesini Görmek İster misiniz ?\n Evet/Hayır");
            string lcevap = Console.ReadLine().ToLower();

            if (lcevap == "evet")
            {
                Console.WriteLine("Tüm Bilgileri Görmek için 1' basın");
                Console.WriteLine("Türe Göre Görmek İsterseniz 2' ye basın");
                int secim = int.Parse(Console.ReadLine());  

                if (secim == 1)
                {

                    var siralilist = filmlist.OrderBy(d=> d.DiziAdi).ThenBy(d=> d.Yonetmen).ToList();
                    
                    Console.WriteLine("Tüm Liste Aşağıda ki gibidir");
                    foreach (Film dizi in siralilist)
                    {
                        Console.WriteLine($"Dizi Adı: {dizi.DiziAdi} , Yapım Yılı : {dizi.YapimYili} , Türü : {dizi.Tur} , Yayın Tarihi : {dizi.YayinYili} , Yönetmen : {dizi.Yonetmen} , Yayınlandığı Platform : {dizi.Kanal}");

                    }
                      


                }

                else if (secim == 2)
                {
                    Console.WriteLine("Hangi Tür Dizileri Görmek İstiyorsunuz");
                    string tur = Console.ReadLine();

                    var filtelidiziler = filmlist.Where(d => d.Tur.Equals(tur, StringComparison.OrdinalIgnoreCase)).OrderBy(d => d.DiziAdi).ThenBy(d => d.Yonetmen);

                    Console.WriteLine($"{tur} Türündeki Diziler");
                    foreach (Film dizi in filtelidiziler)
                    {
                        Console.WriteLine($"Dizinin Adı: {dizi.DiziAdi}, Türü : {dizi.Tur}, Yönetimeni : {dizi.Yonetmen}");
                    }



                }

                else
                {
                    Console.WriteLine("Geçersiz Seçim Yaptınız");
                }

            }

            else
            {
                Console.WriteLine("Geçersiz Seçim Yaptınız");
            }

        }
    }
}