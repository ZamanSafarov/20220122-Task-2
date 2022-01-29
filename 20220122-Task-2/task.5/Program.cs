using System;

namespace task._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. 
                       Alinan cavabin 44 % tap.
             */
            double a = 6248;

            if (a >= 1000 && a < 10000)
            {
                a += 40000;
                

                a = a * 100;

                a += 44;

                a = a * 44 / 100;

                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("4 reqemli deyl.");
            }

        }
    }
}
