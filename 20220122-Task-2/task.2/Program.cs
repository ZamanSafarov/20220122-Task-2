using System;

namespace task._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;
             */
            double a = 444;
            bool True = a >= 100 && a < 1000;
            if (True)
            {
                a = a * 1000;

                a += 444;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("3 reqemli deyl.");
            }
        }
    }
}
