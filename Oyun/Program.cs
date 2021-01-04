using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {  Random rastgele = new Random();
            Console.WriteLine("Zorluk Seviyesini Yazınız. (Seçenekler:Kolay, Orta, Zor)");
            string seviye = Console.ReadLine();
            int durum = 1;
            int hak = 0;
            int Dogru = 0;
            seviye = seviye.ToLower();
            switch (seviye)
            {
                case "kolay":
                    hak = 6;
                    break;
                case "orta":
                    hak = 4;
                    break;
                case "zor":
                    hak = 2;
                    break;
                default:
                    hak = 0;
                    Console.WriteLine("Seçenekler:Kolay, Orta, Zor olabilir");
                    break;
            }
            if (hak!=0)
            {
           
                for (int i = 0; i < durum; i++)
                {
 
                Console.WriteLine(seviye + " ile oyun başlıyor Yanlış Yapma Hakkınız:" + hak.ToString());
                
               Console.WriteLine("1-10 arasında bir sayı yazın");
               string tahmin = Console.ReadLine();
                int sayi = rastgele.Next(1, 10);
                if (tahmin == sayi.ToString())
                {
                        Dogru++;
                    Console.WriteLine("Doğru Bildiniz Doğru Sayınız:"+Dogru.ToString());
                }
                else if(tahmin != sayi.ToString())
                {
                    hak--;

                        Console.WriteLine("Yanlış  Bildiniz kalan hakkınız:" + hak.ToString() + " Doğru Sayınız:" + Dogru.ToString()); ;
                }
                    else
                    {
                        Console.WriteLine("1-10 arasında bir sayı yazın");
                    }
                    if (hak!=0)
                    {
                        durum++;
                    }
                }
            }
            
           
        }
        
    }
}
