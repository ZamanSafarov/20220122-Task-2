using System;

namespace task_._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. 
             * Example1: 333= 73338
             */
            double a = 4444;

            bool True = a > 1000 && a < 10000;
            if (True)
            {
                a = a * 10;
                a += 8;
                a = 700000 + a;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("4 reqemli deyl.");
            }
            


            
        }
    }
}
