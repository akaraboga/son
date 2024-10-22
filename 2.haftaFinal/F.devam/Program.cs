using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.devam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Toplama işlemi için iki tane sayi giriniz : ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            double toplam = Toplam(sayi1, sayi2);

            Console.WriteLine("Toplama işleminin sonucu :" + toplam);


            Donmem();

            bool hayır = false;
            bool evet = true;

            string H = EveyaH(hayır);
            string E=EveyaH(evet);

            Console.WriteLine( "Benimle  yemek yemeye gelir misin? : "+H);
            Console.WriteLine("Benimle kofte yemeye gelir misin^? : "+E);

            


            Console.ReadLine( );
        }

        public static void Donmem()
        {
            Console.WriteLine("Ben değer donmem,istesen de yapamam");
        }

        public static double Toplam(double s1, double s2)
        {
            double sonuc = s1 + s2;
            return sonuc;
        }

        public static string EveyaH(bool cevap)
        {
            return cevap ? "Evet" : "Hayır";
        }

    }
}
