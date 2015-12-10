using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Point
    {
        private int x;
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X {
            get { return x; }
            set { x = value; }
        }

        public void Labb3()   //Default konstruktor
        {
            X = 45;
            Y = 12;
        }

        public void Labb3(int x, int y) /*: this()*/   //Initierande konstruktor
        {
            X = x;
            Y = y;
        }


        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetX()
        {
            return x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetY()
        {
            return y;

        }
    }
}