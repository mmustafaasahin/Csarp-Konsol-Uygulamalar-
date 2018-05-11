using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairenin_Çevresi_ve_Alanı__Konsol_
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159265359; //const metodu ile Pi sayısını 3'e sabitledik.
            Double alan, cevre, yaricap;
            Console.Write("Yarıçapi gir : ");
            yaricap = Convert.ToInt32(Console.ReadLine()); // Kullanıcı tarafından girilen sayıyı tam sayıya çevirdik.
            cevre = 2 * PI * yaricap;
            alan = PI * (Math.Pow(yaricap, 2)); //sayının karesini aldık.
            Console.Write("Dairenin çevresi (cm) = " + cevre + "\n");
            Console.Write("Dairenin alanı (cm) = " + alan + "\n");
            Console.Write("Çıkmak için enter tuşuna basınız...");
            Console.ReadLine();

            return;

        }
    }
}
