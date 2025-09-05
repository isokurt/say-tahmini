using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayı_tahmini
{
    enum ZorlukDerecesi
    {
        Kolay, Normal, Zor, Uzman
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int rastgelesayi = RastgeleSayiUreticisi(100);
            ZorlukDerecesi zorlukSeviyesi = ZorlukDerecesiSecimi();
            int totaltahminhakki = TahminSayisiSiniri(zorlukSeviyesi);


        }

        static int RastgeleSayiUreticisi (int maksimumSayi)
        {
        Random random = new Random();
        return random.Next (1, maksimumSayi + 1);
        }

        static ZorlukDerecesi ZorlukDerecesiSecimi ()
        {
        Console.WriteLine ("Lutfen istediginiz zorluk derecesinin sayisal degerinin giriniz(Ornek: Kolay icin 1):");
        Console.WriteLine ("1- Kolay (1 ile 50 arasindaki secilmis sayiyi 10 denemede dogru tahmin edin)");
        Console.WriteLine ("2- Normal (1 ile 100 arasindaki secilmis sayiyi 7 denemede dogru tahmin edin)");
        Console.WriteLine ("3 Zor (1 ile 500 arasindaki secilmis sayiyi 8 denemede dogru tahmin edin)");
        Console.WriteLine ("4- Uzman (1 ile 1000 arasindaki secilmis sayiyi 10 denemede dogru tahmin edin)");

        int secilenZorlukSeviyesi = int.Parse (Console.ReadLine ());
        return (ZorlukDerecesi) (secilenZorlukSeviyesi - 1);
        }

        static int PuanZorlukDerecesi (ZorlukDerecesi zorlukseviyesi)
        {
        if(zorlukseviyesi == ZorlukDerecesi.Kolay)
        {
        return 10;
        }
        if(zorlukseviyesi == ZorlukDerecesi.Normal)
        {
        return 20;
        }
        if(zorlukseviyesi == ZorlukDerecesi.Zor)
        {
        return 30;

        }
        return 50;
        }

        static int TahminSayisiSiniri(ZorlukDerecesi zorlukseviyesi)
        {
            if (zorlukseviyesi == ZorlukDerecesi.Kolay)
            {
                return 10;
            }
            if (zorlukseviyesi == ZorlukDerecesi.Normal)
            {
                return 7;
            }
            if (zorlukseviyesi == ZorlukDerecesi.Zor)
            {
                return 8;

            }
            return 10;
        }

    }
}
