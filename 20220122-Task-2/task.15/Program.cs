using System;

namespace task._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
             3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
             Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
             Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
             Sonra alinan cavabin ustune gel 6 reqemli ededi.
             Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
             Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
             Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
            */
            double a = 628;
            double b = 492;
            double c = 8623;
            double d = 1954;
            double e = 37658;
            double f = 75496;
            double g = 584632;
            double cem = 0; // 3 reqemli ededlerin cemi
            double hasil = 0; // 4 reqemli ededlerin hasili
            double Total;
            double cem1 = 0; // 5 reqemli ededlerin cemi
            double hasil1 = 0; // 3 reqemli ededlerin bir birine vurulmasi
            double cem2 = 0; //4 reqemli ededlerin cemini.
            if (a >= 100 && a< 1000 && b >= 100 && b < 1000)
            {
                cem = a + b;
                Console.WriteLine("3 Reqemli ededlerin cemi :" + cem);

                Console.WriteLine("--------------------");
                hasil1 = a * b;
                hasil1 = hasil1 * 10 + 1;
                Console.WriteLine("3 Reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmasi :" + hasil1);

                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("3 Reqemli deyl.");
            }

            if (c >= 1000 && c < 10000 && d >= 1000 && d < 10000)
            {
                hasil = c * d;
                Console.WriteLine("4 Reqemli ededlerin bir birine vurulmasi :" + hasil);

                Console.WriteLine("--------------------");
                cem2 = c + d;
                Console.WriteLine("4 Reqemli ededlerin cemi :" + cem2);

                Console.WriteLine("--------------------");

            }
            else
            {
                Console.WriteLine("4 Reqemli deyl.");
            }

            if (e >= 10000 && e < 100000 && f >= 10000 && f < 100000)
            {
                cem1 = e + f;
                Console.WriteLine("5 Reqemli ededlerin cemi :" + cem1);

                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("5 Reqemli deyl.");
            }

            if (g >= 100000 && g < 1000000 )
            {

            }
            else
            {
                Console.WriteLine("6 Reqemli deyl.");
            }
            Total = cem + hasil;

            Console.WriteLine("3 Reqemli ededlerin cemi + 4 Reqemli ededlerin bir birine vurulmasi :" + Total);

            Console.WriteLine("--------------------");

            Total = Total * 10 + 7; // neticenin axirina 7 reqemini artir 

            Console.WriteLine("Neticenin axirina 7 reqemini artir :" + Total);

            Console.WriteLine("--------------------");

            Total += cem1;

            Console.WriteLine("Neticenin üzərinə 5 reqemli ededlerin cemini artirmaq :" + Total);

            Console.WriteLine("--------------------");

            Total -= hasil1;

            Console.WriteLine("Neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini :" + Total);

            Console.WriteLine("--------------------");

            Total += g;

            Console.WriteLine("Alinan cavabin ustune gel 6 reqemli ededi :" + Total);

            Console.WriteLine("--------------------");

            Total -= cem + cem2;

            Console.WriteLine("Alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini :" + Total);

            Console.WriteLine("--------------------");

            Total = Total * 18 / 100;
            Console.WriteLine("alinan cavabin 18 % -i :" + Total);

            Console.WriteLine("--------------------");

            Total = Total * 3 / 100;
            Console.WriteLine("alinan cavabin 3 % -i :" + Total);

            Console.WriteLine("--------------------");

            Total = Total * 1 / 100;
            Console.WriteLine("alinan cavabin 1 % -i :" + Total);

            Console.WriteLine("--------------------");

            Total += cem1;
            Console.WriteLine("Alinan cavabin ustune 5 reqemli ededlerin cemini gel :" + Total);

            Console.WriteLine("--------------------");
        }
    }
}
