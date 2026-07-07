using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISETIA_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Temel Dizi Örnekleri

            // DegiskenTürü [] DiziAdi = new DegiskenTürü [ElemanSayisi]
            //string[] colors = new string[4];
            //colors[0]= "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "yeşil";
            //colors[3] = "beyaz";

            //Console.WriteLine(colors[3]);



            //string[] sehir = new string[4];
            //sehir[0] = "istanbul";
            //sehir[1] = "ankara";
            //sehir[2] = "sinop";
            //sehir[3] = "yalova";
            //
            //Console.WriteLine(sehir[1]);





            //string[] ciftsayilar = new string[8];
            //ciftsayilar[0] = "12";
            //ciftsayilar[1] = "8";
            //ciftsayilar[6] = "34";

            //Console.WriteLine(ciftsayilar[5]);

            //string[] sehir = { "ankara", "istanbul", "sinop", "yalova", "gumushane" };
            //Console.WriteLine(sehir[2]);






            #endregion

            #region Dizideki Elemanları Listeleme

            //string[] colors = { "sari", "kirmizi", "beyaz", "mavi", "bordo", "siyah", "lacivert" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}




            //int [] numbers = { 124, 3974, 78473, 98, 5, 340, 908, 1479, 876,307};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}






            //int[] sayilar = { 1, 2, 3, 4, 6, 4, 3, 6, 86, 34, 678, 987, 3, 34, 21, 567, 8764, 45567 };
            //int maxnumber = sayilar[0];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > maxnumber)
            //    {
            //        maxnumber= sayilar[i];

            //    }        

            //}
            //Console.WriteLine("en buyuk sayi: " + maxnumber);







            //string[] persons = { "ali", "ayse", "mehmet", "fatma", "ahmet" };
            //Console.WriteLine(persons.Length);







            //int[] numbers = { 1, 2, 3, 4, 57, 5, 3, 546, 8, 76, 435, 78, 98, 43 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}







            //int[] numbers = { 1, 2, 3, 4, 57, 5, 3, 546, 8, 76, 435, 78, 98, 43 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}





            #endregion

            #region Dizi Metotları

            //string[] customers = { "aki", "ayse", "zehra", "öykü", "haktan" };
            //int index = Array.IndexOf(customers, "ayse");
            //Console.WriteLine(index);


            ////int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            ////Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max() + " dizinin en küçük elemanı: " + numbers.Min()); 
            ///













            #endregion

            #region Kullanıcıdan Değer Alma

            //int i;
            //string [] cities = new string[5];
            //for (i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //for (i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}





            //int toplam = 0;
            //int [] toplama = { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < toplama.Length; i++)
            //{
            //    toplam += toplama[i];

            //}
            //Console.WriteLine(toplam);




            
            //int[] sayilar = {1,2,3,4,54,345,7877,63,4678,9,5432,2455,6,43,243,45,987,90,87,63,12,3,46 };
            //Console.WriteLine("---ÇİFT SAYILAR---");
            //for (int i = 0; i < sayilar.Length; i++)
            //{              
            //    if (sayilar[i] % 2 == 0)
            //    {                  
            //        Console.WriteLine(sayilar[i] );
            //    }                
            //}
            //Console.WriteLine("---TEK SAYILAR---");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 1)
            //    {                
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
















            #endregion








            Console.Read();

        }  
    }
}
