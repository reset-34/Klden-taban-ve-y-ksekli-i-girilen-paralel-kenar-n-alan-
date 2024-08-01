using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klden_taban_ve_yüksekliği_girilen_paralel_kenarın_alanı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden tabanı  ve yüksekliği girilen paralel kenarın alanını bulan C# programını yazınız.
            Formül:
            Taban*yükseklik
             */

            int taban, yukseklik, alan;

            Console.WriteLine("Paralelkenarın tabanını giriniz");
            taban = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Paralelkenarın yüksekliğini giriniz");
            yukseklik = Int32.Parse(Console.ReadLine());

            alan = taban * yukseklik;

            Console.WriteLine("Paralel kenarın alanı =  " + alan);
            Console.ReadLine();
        }
    }
}
