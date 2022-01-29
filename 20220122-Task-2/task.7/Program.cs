using System;

namespace task._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2 dene 5 reqemli eded verilib. Bu ededleri toplayib. 
            Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap            
             */
            double a = 24156;
            double b = 63214;
            double c;


            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000)
            {
                c = a + b;

                c += 500000;

                c = c * 10 + 5;

                c = c * 5 / 100;

                Console.WriteLine(c);
                


            }
            
            else
            {
                Console.WriteLine("5 reqemli deyl.");
            }

        }
    }
}
