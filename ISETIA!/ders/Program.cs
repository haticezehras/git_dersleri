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
            #region  Foreach Dongusu
            //Foreach(1;2;3;4;

            //1-değişken türü
            //2-değişken adı
            //3-In
            //4-Liste,Koleksiyon,Dizi 


            //string[] cities = { "istanbul", "Ankara", "Bolu", "Yalova", "Bursa", "Samsun" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}



            //int[] numbers = { 1, 2, 3, 4, 4, 43, 23, 67, 887, 43, 23, 656, 7, 89 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}




            //int[] numbers = { 1, 2, 3, 4, 4, 43, 23, 67, 887, 43, 23, 656, 7, 89 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number + " sayisi cift");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number + " sayisi tek");
            //    }

            //}



            //int toplam = 0;
            //int[] numbers = { 1, 2, 3, 4, 4 };
            //foreach (int number in numbers)
            //{
            //    toplam+=number;

            //}
            //Console.WriteLine(toplam);



            //List <int> numbers= new List<int>()
            //{
            //    12,34,5,6,43,76
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}






            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Sınıfınızda kaç tane öğrenci var? ");
            //int ogrenci_sayisi = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();

            //string [] ogrenciler = new string [ogrenci_sayisi];
            //double [] ogrenci_notlari = new double[ogrenci_sayisi];

            //for (int i = 0; i < ogrenci_sayisi; i++)
            //{
            //    Console.WriteLine($"{i + 1}. ogrencinin ismi: ");
            //    ogrenciler[i]= Console.ReadLine();

            //    double toplam = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"{ogrenciler[i]}  öğrencisinin {j+1}. sınav notunu giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        toplam += value;
            //    }
            //    Console.WriteLine();
            //    ogrenci_notlari[i] = toplam / 3;

            //}
            //for (int i = 0; i < ogrenci_sayisi; i++)
            //{
            //    Console.WriteLine("----------------------");
            //    Console.WriteLine($"{ogrenciler[i]} öğrencisinin ortalaması:" + ogrenci_notlari[i]);
            //    if (ogrenci_notlari[i] < 50)
            //    {
            //        Console.WriteLine($"{ogrenciler[i]} dersten kaldi.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{ogrenciler[i]} dersten gecti.");
            //    }
            //    Console.WriteLine("----------------------");

            //}
          

            #endregion







            Console.Read();

        }  
    }
}
