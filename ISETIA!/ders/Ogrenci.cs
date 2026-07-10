using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISETIA_
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string ogrenciAdi;
        private string ogrenciSoyadi;
        private int vize1;
        private int vize2;
        private int final;
        private string okulİsmi;

        public Ogrenci(int _ogrenciNo, string _ogrenciAdi,string _ogrenciSoyadi,string _okulİsmi,int _vize1,int _vize2,int _final)
        {
            ogrenciNo = _ogrenciNo;
            ogrenciAdi= _ogrenciAdi;
            ogrenciSoyadi = _ogrenciSoyadi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulİsmi = _okulİsmi;
        }

        private void ogrenciBilgileriniGoster()
        {
            Console.WriteLine("Öğrenci Adı Soyadı: " + ogrenciAdi + ogrenciSoyadi);
            Console.WriteLine("Öğrenci Numarası: " + ogrenciNo);
            Console.WriteLine("Okul İsmi: " + okulİsmi);
            Console.WriteLine("Vize1: " + vize1);
            Console.WriteLine("Vize2: " + vize2);
            Console.WriteLine("Final: " + final);

        }
        public double ogrenciNotunuBul()
        {
            double ortalama = (vize1 + vize2 + final) / 3;
            return ortalama;
        }
        public void okulGetir()
        {
            Console.WriteLine("okul ismi: " + okulİsmi);
        }
    }
}
