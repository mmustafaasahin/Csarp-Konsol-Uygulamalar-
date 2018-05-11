using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_5_Sayıyı_Ekrana_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilk;
            int ikinci;
            int ucuncu;
            int dorduncu;
            int besinci;

            Console.Write("1.sayıyı gir ");
            ilk = Convert.ToInt32(Console.ReadLine());

                Console.Write("2.sayıyı gir ");
                ikinci = Convert.ToInt32(Console.ReadLine());

                     Console.Write("3.sayıyı gir ");
                     ucuncu = Convert.ToInt32(Console.ReadLine());

                        Console.Write("4.sayıyı gir ");
                        dorduncu = Convert.ToInt32(Console.ReadLine());

                             Console.Write("5.sayıyı gir ");
                             besinci = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("--------------------");

            Console.WriteLine("Girilen 1.Sayı={0}", ilk);
            Console.WriteLine("Girilen 2.Sayı={0}", ikinci);
            Console.WriteLine("Girilen 3.Sayı={0} ", ucuncu);
            Console.WriteLine("Girilen 4.Sayı={0}", dorduncu);
            Console.WriteLine("Girilen 5.Sayı={0}", besinci);
            int toplam = ilk+ikinci+ucuncu+dorduncu+besinci;
            Console.WriteLine("Girilen Sayıların Toplamı  =  " + toplam);
            Console.ReadLine();
        }
    }
}
