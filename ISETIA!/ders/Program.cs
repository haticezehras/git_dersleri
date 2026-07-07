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
            #region Void Metotlar
            //void customerlist()
            //{
            //    Console.WriteLine("hatice zehra şen");
            //    Console.WriteLine("hilal köse");
            //    Console.WriteLine("elif aksakal");
            //    Console.WriteLine("öykü çaakmak");
            //}
            //customerlist();
            //customerlist();








            //void toplam()
            //{
            //    int a = 5;
            //    int b = 4;
            //    int c = a + b;
            //    Console.WriteLine(c);
            //}
            //toplam();


















            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void writemethod(string customername)
            //{
            //    Console.WriteLine(customername);
            //}
            //Console.WriteLine("zehra şşen");




            //void customercard(string customerName,string customerSurname)
            //{
            //    Console.WriteLine("müşteri: "+customerName+" "+customerSurname);

            //}
            //customercard("ahmet", "yılmaz");
            //customercard("zehra ", "şen");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar


            //void toplama(int n1,int n2, int n3)
            //{
            //   int toplam = n1 + n2 + n3;
            //    Console.WriteLine(n1+" "+n2+" "+n3+" sayilarinin toplami: "+toplam);
            //}
            //toplama(2, 4, 6);



            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string studentCard()
            //{
            //    string name = "zehra";
            //    string surname = "şen";
            //    return "isim: " + name + " " + surname;
            //}
            //Console.WriteLine(studentCard());




            #endregion

            #region Geriye Değer Döndğren Parametreli Metotlar
            //string ulkeler(string ulke,string baskent)
            //{
            //    string cardInfo = "Ülke: " + ulke + " baskenti: " + baskent;
            //    return cardInfo;

            //}
            //string x, y;
            //Console.WriteLine("ülke adını giriiniz: ");
            //x=Console.ReadLine();

            //Console.WriteLine("Baskent adını giriiniz: ");
            //y = Console.ReadLine();



            //Console.WriteLine(ulkeler(x,y));

            #endregion

            #region Geriye Değer Döndren İnt Parametreli Metotlar
            //int sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(45, 67));

            //Console.WriteLine(sum(65, 80));

            //Console.WriteLine(sum(23, 9));



            #endregion

            #region ÖrnekUygulama
            //string sınavSistemi(string ogrenci,int vize,int quiz,int final)
            //{
            //    int ortalama = (vize + quiz + final) / 3;
            //    if (ortalama < 50)
            //    {
            //        return ogrenci+"  isimli ogrenci sinavdan kaldi ortalamasi : " + ortalama;
            //    }
            //    else
            //    {
            //        return ogrenci + " isimli ogrenci sinavdan gecti ortalalması: " + ortalama;
            //    }
            //}
            //Console.WriteLine(sınavSistemi("zehra",25, 60, 78));
            //Console.WriteLine(sınavSistemi("batu", 15, 60, 48));
            //Console.WriteLine(sınavSistemi("irem", 55, 60, 12));





            #endregion

            Console.Read();
        }
    }
}
