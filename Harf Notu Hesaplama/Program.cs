using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harf_Notu_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Vize Notunuz=");
            int vize = int.Parse(Console.ReadLine());
 
                    Console.Write("Final notunuz=");
                    int final = int.Parse(Console.ReadLine());
 
                        double ortalama = (vize * 0.40) + (final * 0.60);
 
            if (ortalama > 0 & ortalama < 38) { Console.Write("Ortalama ve harf notunuz={0} ", ortalama); 
                Console.Write("FF Harf notu ile kaldınız.\n "); } 
            else if (ortalama > 38 & ortalama < 45) {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("FD Harf notu ile kaldınız.\n");
            }
            else if (ortalama > 45 & ortalama <= 52)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("DD Harf notu ile şartlı geçtiniz.\n");
            }
            else if (ortalama > 52 & ortalama < 59)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("DC Harf notu ile şartlı geçtiniz.\n");
            }
            else if (ortalama > 59 & ortalama < 66)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("CC Harf notu ile geçtiniz.\n");
            }
            else if (ortalama > 66 & ortalama < 73)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("CB Harf notu ile geçtiniz.\n");
            }
            else if (ortalama > 73 & ortalama < 80)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("BB Harf notu ile geçtiniz.\n");
            }

            else if (ortalama > 80 & ortalama < 84)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("BA Harf notu ile geçtiniz.\n");
            }
            else if (ortalama > 84 & ortalama <= 100)
            {
                Console.Write("Ortalama ve harf notunuz={0} ", ortalama);
                Console.Write("AA Harf notu ile geçtiniz.\n");
            }
            {
                
                }
            Console.ReadKey();
        }
    }
}
