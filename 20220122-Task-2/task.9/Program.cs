using System;

namespace task._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 6 reqemli eded verilib.Her birinin 10 faizini tapib neticeleri topla.Alinan cavabin 10% tap.

            double a = 123456;
            double b = 234567;
            double c = 654321;
            double d;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000)
            {
                a = a * 10 / 100;
                b = b * 10 / 100;
                c = c * 10 / 100;
                d = a + b + c;
                Console.WriteLine("Cem:" + d);

                Console.WriteLine("------------------------");
                d = d * 10 / 100;   //cavabin 10% - i
                Console.WriteLine("Cavab:" + d);



            }
            else
            {
                Console.WriteLine("6 Reqemli deyl");
            }
        }
    }
}
