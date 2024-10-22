using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz :");
            int sayi=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CiftMi(sayi) ? "çift" : "Tek");
           

            Console.ReadLine();
        }

        public static bool CiftMi(int s1)
        {
           return s1 % 2 == 0;  
        }
    }
}
