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
            Musteri musteri1=new Musteri();

            musteri1.musteriAdi = "Zehra";
            musteri1.musteriSoyadi = "şen";
            musteri1.musteriMaas = 50000;
            musteri1.musteriYas = 28;
            musteri1.musteriCinsiyeti = "kız";
            musteri1.musteriBilgileriGoster();
        }
    }
}
