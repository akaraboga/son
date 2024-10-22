using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.haftaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string ad1 = "Demet Evgar";
            string ad2 = "Hakkı Bulut";
            string BoşSlot = "";

            Console.WriteLine("Yer değiştirmeden once :{0} , {1}",ad1,ad2);

            BoşSlot = ad1;
            ad1 = ad2;
            ad2=BoşSlot;

            Console.WriteLine("Yer değiştirdikten sonra : {0},{1}",ad1,ad2);


            Random();

            yas();

            Anı();


            Console.ReadLine();
        }

        public static void Random()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);

            Console.WriteLine("Rastgele sayi : {0} ve 3 ile bolumunden kalanı : {1}", sayi, sayi % 3);

        }

        public static void yas()
        {
            Console.Write("Yaşinizi giriniz : ");
            int yaş = Convert.ToInt32(Console.ReadLine());

            if (yaş < 18)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

        }

        public static void Anı()
        {
            Console.Write("10 kere donecek metni giriniz :");
            string metin = Console.ReadLine();


            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{i} {metin}");
            }

        }




    }
}
