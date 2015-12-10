using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ovningsuppgifter_ARV
{
    internal class Program
    {
        private static void Main(string[] args) //lever bara innanför sitt egna scope
        {
            Uppgift1();
            Uppgift2();

            C myC = new C();
            {
                Console.WriteLine(myC);
            }
            Console.ReadLine();
        }

        private static void Uppgift1()
        {
            object myObject = new object();
            string myString = "hej";
            double myDouble = 4.5;
            string newDoubleString = myDouble.ToString();
            Console.WriteLine(myDouble);
            char oneCharcter = 'k';
            bool isFalse = true;
            string doublestring = "5";
            double holdingString = double.Parse(doublestring);

            object nyttObjekt = myString;
            Console.WriteLine(nyttObjekt);
            nyttObjekt = myDouble;
            Console.WriteLine(nyttObjekt);

            string nySträng = myObject.ToString();
            Console.WriteLine(nySträng);
            nySträng = myDouble.ToString();
            Console.WriteLine(nySträng);

            //myString = "4.2";
            //double NyDubbel = double.Parse(myString);

            C c1 = new C();  //Impicit
            B b1 = new C();
            A a1 = new C();
            C c2 = (C)a1;  //Explicit

            //Test med as:
            A a2 = (A)new A();
            B b3 = a1 as B;
            if (b3 != null)
            {
                //Konverterad
            }
            //Test med is:
            A a4 = new A();
            bool hej = a4 is B;

            C c3 = new C();
            bool tjosan = c3 is object;

            //Boxing
            int tal = 8;
            object boxen = tal;

            //Unboxing 
            int tal2 = (int)boxen;
        }

        private static void Uppgift2()
        {
            Point3D newPoint = new Point3D
            {
                Y = 4,
                X = 16,
                Z = 7
            };
            Console.WriteLine(newPoint.ToString());
        }
    }
}
