using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Casting_och_Override
{
    class MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            this.doubleValue = doubleValue;
        }


        public static MyDoubleType operator +(MyDoubleType value1, double value2)
        {
            return new MyDoubleType(value1.DoubleValue + value2);
        }

        public static MyDoubleType operator +(MyDoubleType value1, MyDoubleType value2)
        {
            return new MyDoubleType(value1.DoubleValue + value2.DoubleValue);
        }

        public static MyDoubleType operator -(MyDoubleType value1, double value2)
        {
            return new MyDoubleType(value1.DoubleValue - value2);
        }

        public static MyDoubleType operator -(MyDoubleType value1, MyDoubleType value2)
        {
            return new MyDoubleType(value1.DoubleValue - value2.DoubleValue);
        }

        public static MyDoubleType operator /(MyDoubleType value1, double value2)
        {
            return new MyDoubleType(value1.DoubleValue / value2);
        }

        public static MyDoubleType operator /(MyDoubleType value1, MyDoubleType value2)
        {
            return new MyDoubleType(value1.DoubleValue / value2.DoubleValue);
        }
        public static MyDoubleType operator *(MyDoubleType value1, double value2)
        {
            return new MyDoubleType(value1.DoubleValue * value2);
        }

        public static MyDoubleType operator *(MyDoubleType value1, MyDoubleType value2)
        {
            return new MyDoubleType(value1.DoubleValue * value2.DoubleValue);
        }

        //public static bool operator ==(MyDoubleType value1, double value2)
        //{
        //    return value1.DoubleValue == value2;
        //}

        //public static bool operator !=(MyDoubleType value1, double value2)
        //{
        //    return !(value1 == value2);
        //}

        public static bool operator ==(MyDoubleType value1, MyDoubleType value2)
        {
            return value1.DoubleValue == value2.DoubleValue;
        }

        public static bool operator !=(MyDoubleType value1, MyDoubleType value2)
        {
            return !(value1 == value2);
        }

        public static bool operator <(MyDoubleType value1, MyDoubleType value2)
        {
            return value1.DoubleValue > value2.DoubleValue;
        }

        public static bool operator >(MyDoubleType value1, MyDoubleType value2)
        {
            return value1.DoubleValue > value2.DoubleValue;
        }

        public static bool operator <=(MyDoubleType value1, MyDoubleType value2)
        {
            return value1.DoubleValue <= value2.DoubleValue;
        }

        public static bool operator >=(MyDoubleType value1, MyDoubleType value2)
        {
            return value1.DoubleValue >= value2.DoubleValue;
        }

        public override string ToString() => $"The value is: {doubleValue}";
    }
}
