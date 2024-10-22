using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşlarını hesaplamak istediğiniz  kişilerin yaşlarını giriniz");

            Console.Write("1.yaş : ");
            int yas1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.yaş : ");
            int yas2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.yaş : ");
            int yas3 = Convert.ToInt32(Console.ReadLine());

            int sonuc = YasHesap(yas1, yas2, yas3);

            Console.Write("En büyük yas : " + sonuc);

            Console.ReadLine();
        }


        public static int YasHesap(int yıl1, int yıl2, int yıl3)
        {
            int enb = 0;

            if (yıl1 > yıl2 && yıl1 > yıl3)
            {
                return enb = yıl1;
            }
            else if (yıl2 > yıl1 && yıl2 > yıl3)
            {
                return enb = yıl2;
            }
            else
            {
                return enb = yıl3;
            }


        }
    }
}
