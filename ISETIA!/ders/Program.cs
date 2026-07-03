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

            //int hamburgerPrice = 350;
            //int colaPrice = 35;
            //int waterPrice = 15;
            //int pizzaPrice = 270;

            //Console.WriteLine("-----------menü------------");
            //Console.WriteLine();
            //Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("Pizza: "+ pizzaPrice + " TL ");
            //Console.WriteLine("Kola: "+ colaPrice + " TL");
            //Console.WriteLine("Su: "+ waterPrice + " TL");    


            #endregion

            #region double degiskenler
            //double number;
            //number = 4.45;
            //Console.WriteLine(number);
            //Console.Read();

            //Console.WriteLine("************ FİYAT LİSTESİ ************");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 15.50;
            //orangePrice = 12.45;
            //strawberryPrice = 20.90;
            //potato = 11.99;
            //tomato = 5.75;

            //Console.WriteLine("--Domates Birim Fiyatı: " + tomato + " TL");
            //Console.WriteLine("--Patates Birim Fİyatı: " + potato + " TL ");
            //Console.WriteLine("--Çilek Birim Fiyatı: " + strawberryPrice + " TL ");
            //Console.WriteLine("--Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("--Elma Birim Fiyatı :" + applePrice + " TL ");

            //double applegram, orangegram, tomatogram, strawberrygram, potatogram;
            //applegram = 1.234;
            //orangegram = 3.844;
            //strawberrygram =0.750; ;
            //potatogram = 5.500;
            //tomatogram = 3.450;

            //Console.WriteLine("---------------------------------------------");

            //double appleTotalPrice = applegram * applePrice;
            //double orangeTotalPrice= orangegram * orangePrice;
            //double potatoTotalPrice= potato * potatogram;

            //Console.WriteLine("Alınan ürün : ELMA "+ " --Birim Fiyatı : " + applePrice + " --Gramajı : "+ applegram +" --Toplam Fiyat: "+appleTotalPrice);      
            //Console.WriteLine("Portakalın Toplam Fiyatı : "+ orangeTotalPrice); 
            //Console.WriteLine("Patatesin Toplam Fiyatı : "+ potatoTotalPrice);

            //double TOTALPRICE = appleTotalPrice + orangeTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Toplam Tutar: " + TOTALPRICE);
            #endregion

            #region Char Degiskeni
            //char karakter;
            //karakter='a';
            //Console.WriteLine(karakter);

            #endregion

            #region Klavyeden Veri Girişleri String
            //string pessangerName, pessangerSurname, pessangerAge, pessangerIdentityNumber;
            //Console.Write(" Yolcu Adı : ");
            //pessangerName= Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //pessangerSurname= Console.ReadLine();
            //Console.Write("Yolcunun Yaşı : ");
            //pessangerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No : ");
            //pessangerIdentityNumber= Console.ReadLine();

            //Console.WriteLine("-------------------");

            //Console.WriteLine("Yolcu AD-SOYAD:" + pessangerName +" "+ pessangerSurname+" "+ "--Yolcu Yaşı: "+pessangerAge+ " "+"--Yolcu TC Kimlik No:"+ pessangerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 2000;
            //computerPrice = 30000;
            //chairPrice = 1500;
            //tvPrice = 80000;
            //int shoesCaunt, computerCaunt, chairCaunt, tvCaunt;
            //Console.WriteLine("Kaç adet ayakkabı aldığınızı giriniz : ");
            //shoesCaunt = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kaç adet bilgisayar aldığınızı giriniz : ");
            //computerCaunt = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kaç adet tv aldığınızı giriniz : ");
            //tvCaunt = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kaç adet sandalye aldığınızı giriniz : ");
            //chairCaunt = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCaunt * shoesPrice + computerCaunt * computerPrice + chairCaunt * chairPrice + tvCaunt * tvPrice;

            //Console.WriteLine("toplam ödemeniz: " + totalPrice);

            #endregion

            #region Klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
           

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine( );
            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion
            Console.Read();
        }  
    }
}
