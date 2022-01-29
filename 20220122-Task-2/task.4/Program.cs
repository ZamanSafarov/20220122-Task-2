using System;

namespace task._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
             */
            double a = 345;
            if (a >= 100 && a < 1000)
            {
                a = a * 10;

                a += 7;

                a = a * 7 / 100;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("3 reqemli deyl.");
            }
        }
    }
}
