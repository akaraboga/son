using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gidilen yol kaç km : ");
            double Yol=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kaç saat de gidildi : ");
            double Zaman=Convert.ToDouble(Console.ReadLine());

            double sonuc=YolHesap(Yol, Zaman);

            Console.WriteLine("Gidilen yol {0} km ",sonuc);

            Console.ReadLine();

        }

        public static double YolHesap(double s1,double s2)
        {
            return s1*s2;
        }
    }
}
