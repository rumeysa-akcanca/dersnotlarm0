using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            // örnek
            //int deger = 8;//sayı =8
            //Console.WriteLine($"sayı:{sayı}\n");
            //int sayı = deger++;// önce atama sonra yükseltme
            ////Console.WriteLine($"sayı:{sayı}\n");
            //deger += 10;//19
            //Console.WriteLine($"sayı:{sayı}\n");
            //sayı = ++deger;// sayı20,deger 20
            //Console.WriteLine($"sayı:{sayı}\n");

            // Console.WriteLine($"sonuc = (sonuc)");
            //int s1 = 10;
            //int s2 = 15;
            //int toplam = s1 + s2;
            //SORU


            //Console.Write("1. sayı giriniz: ");
            //string s1 = Console.ReadLine();
            //int sayi1 =Convert.ToInt32(s1);

            //Console.Write("2.sayıyı giriniz:  ");
            //string s2 = Console.ReadLine();
            //int sayi2 = Convert.ToInt32(s2);
            //int toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);
            // soru 2 fahrenayt-santigrat

            Console.Write("fahrenayt : ");
            string s = Console.ReadLine();
            double sayi = Convert.ToDouble(s);
            double toplam = (sayi-32) /( 1.8);
            double toplam1 = Math.Round(toplam, 3); // virgülden sonra 3 basamak
            Console.WriteLine(toplam1);
            Console.WriteLine($"{sayi} fahrenayt => {toplam1} santigrat derecedir.");

        }
    }
}
