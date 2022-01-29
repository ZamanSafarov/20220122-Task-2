using System;

namespace task._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6 dene 6 reqemli eded verilib. Evvel hamisini topla . 
             Sonra I ve III ededi bir birine yapishdir ve bir eded al.
             I neticeden II neticeni cix. Alinan cavabin 10% tap. 
             Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.
            */
            double a = 209734;
            double b = 410325;
            double c = 893413;
            double d = 234518;
            double e = 673142;
            double f = 763516;
            double cem;
            double IandIII;//I ve III ededi bir birine yapishdir
            double Ferq;
            double Yekun;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 100000 && e < 1000000)
            {
                cem = a + b +c + d + e + f;

                Console.WriteLine("Ededlerin cemi:" + cem);

                Console.WriteLine("------------------------");

                a *= 1000000;

                IandIII = a + c;//I ve III ededi bir birine yapishdir

                Console.WriteLine("I ve III ededi bir birine yapishdir :" + IandIII);

                Console.WriteLine("------------------------");

                Ferq = cem - IandIII;

                Console.WriteLine("I neticeden II neticeni cix :" + Ferq);

                Console.WriteLine("------------------------");

                Ferq = Ferq * 10 / 100;//Alinan cavabin 10% tap.

                Console.WriteLine("Ferqin 10 %-i :" + Ferq);

                Console.WriteLine("------------------------");

                Yekun = Ferq + e + f;
                //Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.
                Yekun = Yekun * 11 / 100;    

                Console.WriteLine("Yekun cavabin 11%-i :" + Yekun);
            }
            else
            {
                Console.WriteLine("6 Reqemli deyl");    
            }
             
        }
    }
}
