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
            
            Araba araba1=new Araba();

            araba1.arabaRengi = "kırmızı";
            araba1.arabaModeli = "Reanult";
            araba1.kapiSayisi = 4;

            araba1.kapilariKilitle();
            araba1.motorCalistir();

            Console.WriteLine("Arabanın kapı sayısı: "+araba1.kapiSayisi);
            Console.WriteLine("Arabanın rengi: " + araba1.arabaRengi);
            Console.WriteLine("Arabanın modeli: "+araba1.arabaModeli);



            Console.Read();
        }
    }
}
