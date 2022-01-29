using System;

namespace task._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 
             5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
             Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. 
             Sonra yekunda alinan iki cavablarin her birinin 10%-ni tapib topla.
             */
            double a = 25732;
            double b = 19034;
            double c = 30527;
            double d = 432;
            double e = 628;
            double hasil;
            double cem;
            double cem1 = 0;
            double hasil1 = 0;
            double total;

            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000)
            {
                a = a * 5 / 100;
                b = b * 5 / 100;
                c = c * 5 / 100;
                hasil = a * b * c;
                Console.WriteLine("Hasil:" + hasil);

                hasil = hasil * 10 / 100;
                Console.WriteLine("Hasilin 10%-i:" + hasil);
                hasil1 = hasil;
                
                    
            }
            else
            {
                Console.WriteLine("5 Reqemli deyl");
            }

            Console.WriteLine("--------------------------------");

            if (a >= 100 && a < 1000 || b >= 100 && b < 1000)
            {
                d = d * 3 / 100;
                e = e * 3 / 100;
                cem = d + e;
                Console.WriteLine("Cem:" + cem);

                cem = cem * 10 / 100;
                Console.WriteLine("Cemin 10%-i:" + cem);
                cem1 = cem;
                
                

            }
            else
            {
                Console.WriteLine("3 Reqemli deyl.");
            }

            Console.WriteLine("---------------------------");

            total = cem1 + hasil1;
            Console.WriteLine("Toatal hasil + cem :" + total);









        }
    }
}
