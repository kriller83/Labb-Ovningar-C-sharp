using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6_Casting_och_Override;

namespace Labb6_Casting_och_Override
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Uppgift3();
            //Uppgift1();

            //MyDoubleType mdt1 = new MyDoubleType(5);
            //MyDoubleType mdt2 = mdt1 + 5;
            //MyDoubleType mdt3 = mdt1 + mdt2;
            //MyDoubleType mdt4 = new MyDoubleType(5);
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);

            MyDoubleTypeStruct mdt1 = new MyDoubleTypeStruct(5);
            MyDoubleTypeStruct mdt2 = mdt1 + 5;
            MyDoubleTypeStruct mdt3 = mdt1 + mdt2;
            MyDoubleTypeStruct mdt4 = new MyDoubleTypeStruct(5);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);


            Console.ReadLine();
        }

        private static void Uppgift1()
        {
            Literals litteraler = new Literals();
            Console.WriteLine(litteraler);
        }

        private static void Uppgift3()
        {
            Point point = new Point(1, 2);
            Point3D point3D = new Point3D(4, 7, 9);
            Point3D point1 = (Point3D)point;  //typcastar point3D till point
            Point point2 = (Point)point3D;  //typcastar Point till point3D

            Console.WriteLine(point);
            Console.WriteLine(point3D);
            Console.WriteLine(point1);
            Console.WriteLine(point2);

        }
    }
}
