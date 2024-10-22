using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad 1 :");
            string ad1 = Console.ReadLine();

            Console.WriteLine("Ad 2 :");
            string  ad2= Console.ReadLine();

            Console.WriteLine("Değiştirmeden once : {0} , {1}",ad1,ad2);

            değiştir(ref ad1,ref ad2);
            Console.WriteLine("Değiştirildikten sonra : {0} , {1}", ad1, ad2);
            Console.ReadLine();
        }


        public static void değiştir( ref string isim1, ref string isim2)
        {
            string yedek = isim1;
            isim1 = isim2;
            isim2= yedek;  
        }

    }
}
