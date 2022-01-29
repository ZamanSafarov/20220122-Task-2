using System;

namespace task._6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
             4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. 
             Alinan cavabin kvadratini tap.
            */
            double a = 2844;
            double b; // Alinan cavabin kvadratini tap.


            if (a >= 1000 && a < 10000)
            {
                a = a * 20 / 100;

                a = a * 10 / 100;

               b = Math.Pow(a, 2);

                Console.WriteLine("Cavabin kvadrati :" + b);//Alinan cavabin kvadratini tap.
            }
            else
            {
                Console.WriteLine("4 Reqemli deyl.");
            }

            
        }
    }
}
