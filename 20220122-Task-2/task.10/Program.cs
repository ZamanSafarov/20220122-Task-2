using System;

namespace task._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
             Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel
            */
            double a = 2542;
            double b = 4904;
            double c = 5872; 
            double d;
            double e;
            double cem;

            if (a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000)
            {
                a = a * 1 / 100;
                b = b * 2 / 100;
                e = c * 3 / 100;
                d = a - b - e;

                Console.WriteLine("Neticelerin Çıxılması:" + d);

                Console.WriteLine("------------------------");

                c = c * 7 / 100; //III ededin 7%
                cem = c + d;

                Console.WriteLine("Cavab:" + cem);

            }
            else
            {
                Console.WriteLine("4 Reqemli deyl");
            }
        }
    }
}
