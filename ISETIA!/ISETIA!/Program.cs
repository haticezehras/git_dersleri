using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISETIA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Degiskenler
            //string name;
            //name = "zehra";
            //Console.WriteLine(name);


            //string customerName;
            //string customerSurname;
            //string customerEmail,city;
            //string customerPhone;

            //customerEmail = "haticezehrasen@hotmail.com";
            //customerPhone = "0505 539 29 56";
            //customerName = "hatice zehra";
            //customerSurname = "şen";
            //city = "istanbul";

            //Console.WriteLine("*********MÜŞTERİ BİLGİLERİ*********");

            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname+ " ");
            //Console.WriteLine("Kullanıcı maili : "+customerEmail+" ");
            //Console.WriteLine("Telefon numarası:"+ customerPhone + " ");
            //Console.WriteLine("Yer:" + city);

            //Console.WriteLine("-------------------------------------------------------");

            #endregion
            #region İnt Degiskenler
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 350;
            int colaPrice = 35;
            int waterPrice = 15;
            int pizzaPrice = 270;

            Console.WriteLine("-----------menü------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Pizza: "+ pizzaPrice + " TL ");
            Console.WriteLine("Kola: "+ colaPrice + " TL");
            Console.WriteLine("Su: "+ waterPrice + " TL");    


            #endregion
            Console.Read();
        }  
    }
}
