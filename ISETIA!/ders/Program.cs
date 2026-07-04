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
            #region IF ELSE
            // Console.WriteLine("lutfen sifrenizi giriniz: ");
            // string password;
            // password = Console.ReadLine();

            //if( password == "abcd")
            // {
            //     Console.WriteLine("sifre dogru ");
            // }
            // else
            // {
            //     Console.WriteLine("hatali sifre");
            // }
            // Console.Read();


            //string baskent, ulke;

            //Console.WriteLine("ulkeyi giriniz: ");
            //ulke = Console.ReadLine();

            //Console.WriteLine("başkenti giriniz: ");
            //baskent = Console.ReadLine();


            //if (ulke == "turkiye" && baskent == "ankara")
            //{
            //    Console.WriteLine("veriler dogrulandi. ");

            //}
            //else
            //{
            //    Console.WriteLine("hatali veri girisi!");
            //}
            //double ortalama;
            //int vize, quiz, final;
            //Console.WriteLine("vize notunuzu giriniz: ");
            //vize = int.Parse(Console.ReadLine());
            //Console.WriteLine("quiz notunuzu giriniz: ");
            //quiz = int.Parse(Console.ReadLine());
            //Console.WriteLine("final notunuzu giriniz ");
            //final = int.Parse(Console.ReadLine());

            //ortalama = (vize + quiz + final) / 3;
            //Console.WriteLine("sınavlarin ortalamasi: " + ortalama);

            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("tebrikler gectiniz");
            //}
            //else
            //{
            //    Console.WriteLine("dersten kaldiniz");
            //}
            //string username;
            //Console.WriteLine("lütfen kullanıcı adını giriniz:");
            //username = Console.ReadLine();

            //if(username != "zehra")
            //{
            //    Console.WriteLine("hatali giris");
            //}
            //else
            //{
            //    Console.WriteLine("dogru kullanici adi");
            //}

            #endregion
            #region Mod İşlemleri

            //Console.WriteLine("Lutfen 1. sayiyi giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //Console.Write("lutfen 2. sayiyi giriniz: ");
            //int number2=int.Parse(Console.ReadLine());
            //int sonuc2 = number % number2;

            //Console.WriteLine(number+" sayisinin "+number2 +" sayisina bolumuhnden kalan=  "+ sonuc2);



            //int number;
            //Console.WriteLine("sayi: ");
            //number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayi cift");
            //}
            //else
            //{
            //    Console.WriteLine("sayi tek ");
            //}
            #endregion

            #region Ornek
            //char harf;
            //Console.WriteLine("lütfen f g b veya t harflerinden birini giriniz: ");
            //harf=char.Parse(Console.ReadLine());

            //if (harf == 'f')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}
            //else if (harf == 'g')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //else if (harf == 'b')
            //{
            //    Console.WriteLine("besiktas");

            //}
            //else if (harf == 't')
            //{
            //    Console.WriteLine("trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("gecersiz harf");
            //}

            //Console.WriteLine("------MENÜ-------");
            //Console.WriteLine();
            //Console.WriteLine("1_Çorba Menüsü");
            //Console.WriteLine("2-Hamburger Menüsü");
            //Console.WriteLine("3-Tatlı Menüsü");
            //Console.WriteLine("4-İçecek Menüsü");
            //Console.WriteLine();
            //int menuNumarasi;
            //Console.WriteLine("Açmak istediğiniz menü numarasını tuşlayınız.");
            //menuNumarasi=int.Parse(Console.ReadLine());

            //if (menuNumarasi == 1)
            //{
            //    Console.WriteLine("-----ÇORBA MENÜSÜ-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sebze Çorbası");
            //    Console.WriteLine("2-Mercimek Çorbası");
            //    Console.WriteLine("3-Tarhana Çorbası");
            //    Console.WriteLine("4-Domates Çorbası");
            //}
            //else if (menuNumarasi == 2)
            //{
            //    Console.WriteLine("----HAMBURGER MENÜSÜ-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-CheeseBurger");
            //    Console.WriteLine("2-Tavuk Burger");

            //}
            //else if (menuNumarasi == 3)
            //{
            //    Console.WriteLine("----TATLI MENÜSÜ----");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Sufle");
            //    Console.WriteLine("2-Künefe");
            //    Console.WriteLine("3-Waffle");
            //    Console.WriteLine("4-Sütlaç");
            //}
            //else if (menuNumarasi == 4)
            //{
            //    Console.WriteLine("-----İÇECEK MENÜSÜ-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Limonata");
            //    Console.WriteLine("3-Şalgam");
            //}
            //else
            //{
            //    Console.WriteLine("gecersiz numara");
            //}
            #endregion
            #region Switch-Case
            //Console.WriteLine("Lutfen ay girisi yapiniz:");
            //int monthNumber=int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:Console.WriteLine("ocak");
            //        break;
            //    case 2:Console.WriteLine("şubat");
            //        break;
            //    case 3:Console.WriteLine("mart");
            //        break;
            //    case 4:Console.WriteLine("nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("aralık");
            //        break;

            //}







            #endregion
            #region Switch Case Hesap Makinesi 
            //int number1, number2, sonuc;
            //char islem;
            //Console.WriteLine("1.SAYI: ");
            //number1=int.Parse(Console.ReadLine());
            //Console.WriteLine("2.SAYI: ");
            //number2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen yapmak istediginiz islemi giriniz: ");
            //islem=char.Parse(Console.ReadLine());

            //switch (islem)
            //{
            //    case '+':
            //        sonuc = number1 + number2;
            //        Console.WriteLine("Toplam = " + sonuc);
            //        break;
            //    case '-':
            //        sonuc = number1 - number2;
            //        Console.WriteLine("Fark = " + sonuc);
            //        break;
            //    case '*':
            //        sonuc = number1 * number2;
            //        Console.WriteLine("Çarpım= " + sonuc);
            //        break;
            //    case '/':
            //        sonuc = number1 / number2;
            //        Console.WriteLine("Bölüm= " + sonuc);
            //        break;

                    
            //}




            #endregion















            Console.Read();
        }  
    }
}
