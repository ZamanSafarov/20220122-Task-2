using System;

namespace task._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              4 dene 6 reqemli eded verilib.Ededlerin hamisinin 10 faizini tap ve topla. 
              Sonra hamisinin 15 faizini tap ve topla.
              Sonra yekunda alinanlar iki cavabi vur biri birine. 
              Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
            */
            double a = 123456;
            double b = 123457;
            double c = 123458;
            double d = 123459;
            double cem;
            double cem2;
            double hasil;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d <= 1000000)
            {
                a = a * 10 / 100;
                b = b * 10 / 100;
                c = c * 10 / 100;
                d = d * 10 / 100;
                
                cem = a + b + c + d;
                Console.WriteLine("Ededlerin 10%-nin toplanmasi:" + cem);

                Console.WriteLine("------------------------");

                a = a * 150 / 100;
                b = b * 150 / 100;
                c = c * 150 / 100;
                d = d * 150 / 100;

                cem2 = a + b + c + d;
                Console.WriteLine("Ededlerin 15%-nin toplanmasi:" + cem2);

                Console.WriteLine("------------------------");

                hasil = cem * cem2;
                hasil = hasil * 10 / 100;
                hasil = hasil * 110 / 100;
                Console.WriteLine("Cavab:" + hasil);



            }
            else
            {
                Console.WriteLine("6 Reqemli deyl");
            }
        }
    }
}
