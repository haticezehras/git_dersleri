using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISETIA_
{
    public class Musteri
    {
        public string musteriAdi;
        public string musteriSoyadi;
        public int musteriMaas;
        public int musteriYas;
        public string musteriCinsiyeti;

        public void musteriBilgileriGoster()
        {
            Console.WriteLine("isim: "+musteriAdi);
            Console.WriteLine("Soyisim: " + musteriSoyadi );
            Console.WriteLine("Maaş: " + musteriMaas);
            Console.WriteLine("Yaş: "+ musteriYas);
            Console.WriteLine("cinsiyet: "+ musteriCinsiyeti);

            
        }
        private void İsimSoyisimGoster(string musteriİsim , string musteriSoyisim)
        {
            Console.WriteLine("Müşterinin adı soyadı : " + musteriİsim + musteriSoyisim);
        }





    }
}
