using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgifter2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            int myInt2;
            Add(ref myInt);
            Multiply( ref myInt);
            AddOut(out myInt2);
            Console.WriteLine(myInt.ToString() + myInt2);
            Console.ReadLine();
        }
        static void Add(ref int nummer)
        {
            nummer += 10;
        }
        static void AddOut(out int nummer)
        {
            nummer = 10;
        }
        static void Multiply(ref int talet)
        {
            talet *= 10;
        }

        //static int Add(int number)
        //{
        //    return number + 10;
        //}
        //static int Multiply(int tal)
        //{
        //    return tal * 10;
        //}
    }
}
