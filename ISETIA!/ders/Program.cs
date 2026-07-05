using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ISETIA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu
            //int i;
            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("zehra");
            //}

            //Console.Read();


            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("kaç adet yazilsin: ");
            //int sayi=int.Parse(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine("hello");
            //}



            #endregion
            #region For Dongusu İle Karar Yapilari

            //Console.WriteLine("5 e tam bolunen sayilar: ");
            //for (int i = 5; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}




            //int toplam = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    toplam += i;

            //}
            // Console.WriteLine(toplam); 




            //Console.WriteLine("1-20 arasindaki cift sayilarin toplami: ");
            //int toplam = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine(toplam);



            //Console.WriteLine("1-50 arasinda 7 ye bolunen kac sayi var?");

            //int toplamSayi=0;
            //for (int i = 1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        toplamSayi++;

            //    }

            //}
            //Console.WriteLine("toplam = " + toplamSayi + " sayi vardir");



            //int bakteri = 1;
            //Console.WriteLine("her saatin sonunda bakteriler 2 ye bölünüyorsa 24 saatin sonunda kaç bakteri olur? ");
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i+". saatin sonunda: "+bakteri);
            //}


            #endregion
            #region While Dongusu
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 1;
            //int toplam = 0;
            //while (i <= 10)
            //{
            //    toplam += i;
            //    i++;

            //}
            //Console.WriteLine(toplam);













            #endregion
            #region ORNEK SORU
            ////KLAVYEDEN GİRİLEN ÜÇ BASAMAKLI BİR SAYININ BASAMAKLARININ TOPLAMINI BULUNUZ.

            //int sayi;
            //int toplam = 0;
            //int birlerb, onlarb, yüzlerb;
            //Console.WriteLine("3 Basamakli Bir Sayi Giriniz: ");
            //sayi=int.Parse(Console.ReadLine());

            //birlerb = sayi % 10;
            //Console.WriteLine("Sayinin birler basamagi: " + birlerb);

            //onlarb = (sayi/10) % 10;
            //Console.WriteLine("Sayinin onlar basamagi: " + onlarb);

            //yüzlerb = (sayi / 100) % 10;
            //Console.WriteLine("Sayinin yüzler basamagi: " + yüzlerb);

            //toplam = onlarb + yüzlerb + birlerb;
            //Console.WriteLine(sayi + " sayisinin basamaklarinin toplami: " + toplam);









            #endregion
            #region YILDIZ ORNEGİ

            //// DİK ÜÇGEN 
            //for (int i=1; i <= 5; i++)
            //{
            //    for (int j=1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// TERS DİK ÜÇGEN
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}





            #endregion
            #region PİRAMİT

            //int n = 5;
            //for (int i = 1; i <=n ; i++)
            //{
            //    for (int j= n-i ; j>0;j--)
            //    {
            //        Console.WriteLine(" ");
            //    }
            //    for(int k=1; k<= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}






            #endregion





        }
    }
}
