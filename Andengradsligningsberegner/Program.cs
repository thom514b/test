using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andengradsligningsberegner
{
    class Program
    {
        static void Main(string[] args)
        {
            Andengradsligning();

        }

        static void Andengradsligning()
        {
            double x1 = 0;
            double x2 = 0;
            double x = 0;
          

            Console.WriteLine("Indtast a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double D = b * b - (4 * a * c);
            Console.WriteLine("Diskriminanten er = " + D);

            double ds = Math.Sqrt(D);

            //Console.WriteLine(ds);
            Console.WriteLine("udregner");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);


            }

            Console.WriteLine();

            if (D > 0)
            {
                x1 = (-b + ds) / (2 * a);

                x2 = (-b - ds) / (2 * a);

                Console.WriteLine("x er lig med : " + x1);
                Console.WriteLine("x er lig med : " + x2);
            }
            else if (D == 0)
            {
                x = (-b + ds) / (2 * a);
                Console.WriteLine("x er lig med : " + x);

            }
            else
            {
                Console.WriteLine("Der er ingen løsninger");
            }
            Console.WriteLine();
            Console.WriteLine("tryk på hvilken som helst tast, for at udregne en ny ligning");
            Console.ReadKey();

            Console.WriteLine("indtast en ny andengradsligning");

            Console.ReadKey();

            Console.WriteLine();

            Andengradsligning();
        }
    }
}
