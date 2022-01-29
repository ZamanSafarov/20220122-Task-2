using System;

namespace task._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
             */
            double a = 43526;

            if (a >= 10000 && a < 100000)
            {
                a = a * 18 / 100;
                a = a * 3 / 100;
                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("5 reqemli deyl.");
            }
        }
    }
}
