using System;

namespace task._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
             I ededin 4%-ni tap.
             Sonra II ededin 9% ni tap.
             Sonra Cavablari toplayib 10 %ni tap.
            */

            double a = 8524;
            
            double b = 3245728;
            
            double c;

            if (a > 1000 && a < 10000)
            {
                a = a * 4 / 100;
                Console.WriteLine("I eded:" + a);
            }
            else
            {
                Console.WriteLine("4 Reqemli deyl.");
            }
            if (b > 1000000 && b < 10000000)
            {
                b = b * 9 / 100;

                Console.WriteLine("II eded:" + b);
            }
            else
            {
                Console.WriteLine("7 Reqemli deyl.");
            }
            c = a + b;

            Console.WriteLine("Cemi:" + c);

            Console.WriteLine("------------------------");

            c = c * 10 / 100;

            Console.WriteLine("Cavab:" + c);// ededin 10%-zi
        }
    }
}
