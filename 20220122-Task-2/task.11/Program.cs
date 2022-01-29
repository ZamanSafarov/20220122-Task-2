using System;

namespace task._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.
               Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.
            */
            double a = 12345;
            double b = 23456;
            double c = 34567;
            double d = 45678;
            double cem;
            double cem2;
            double hasil;


            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 10000 && d<= 100000)
            {
                cem = a + c;
                cem2 = b + d;
                hasil = cem * cem2;
                c = c * 3 / 100; // III ededin 3 %
                Console.WriteLine("Cavab:" + (hasil - c));

            }
            else
            {
                Console.WriteLine("5 Reqemlid deyl.");
            }

        }
    }
}
