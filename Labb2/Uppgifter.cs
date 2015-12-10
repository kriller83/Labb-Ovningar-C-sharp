using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Uppgifter
    {
        static void Main(string[] args)
        {
            DelUppgift1();
            DelUppgift2();
            DelUppgift3();
            DelUppgift4();
        }
        private static void DelUppgift1()
        {
            int year = 34;
            Console.WriteLine("Hej jag är {0} år", year);
            year = 55;
            Console.WriteLine("Hej jag är {0} år", year);
        }
        private static void DelUppgift4()
        {
            string text = ("Dow Jones ökade med");
            double number = 4.6;
            Console.WriteLine($"{text} {number} %");

            text = ("Nasdaq ökade med");
            number = 4.1;
            Console.WriteLine($"{text} {number} %");

            text = ("Stockholm sjönk med");
            number = -2.4;
            Console.WriteLine($"{text} {number} %");

            text = ("Milano gick ner");
            number = -6.7;
            Console.WriteLine($"{text} {number} %");

            text = ("Paris gick ner");
            number = -5.5;
            Console.WriteLine($"{text} {number} %");
        }

        private static void DelUppgift2()
        {
            const double PI = 3.141592654;
            //PI++;  fungerar ej
            Console.WriteLine("PI med två decimaler är lika med {0:F2}, och lite grovt är PI lika med {0:F0}", PI);
        }

        private static void DelUppgift3()
        {
            string city = ("bor i Helsingborg");
            string place = ("Hemköp");
            Console.WriteLine($"Jonas {city} på Stattena vid {place}");

            city = ("bor i Halmstad");
            place = ("Maxi");
            Console.WriteLine($"Jonas {city} på Statena vid {place}");
        }

       
    }
}
