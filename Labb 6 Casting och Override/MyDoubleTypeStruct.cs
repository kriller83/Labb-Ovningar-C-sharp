using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Casting_och_Override
{
    struct MyDoubleTypeStruct
    {
        public double DoubleValue { get; set; }

        public MyDoubleTypeStruct(double doubleValue)
        {
            this.DoubleValue = doubleValue;
        }

        public static MyDoubleTypeStruct operator +(MyDoubleTypeStruct value1, double value2)
        {
            value1.DoubleValue += value2;
            return value1;
        }

        public static MyDoubleTypeStruct operator +(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {
            value1.DoubleValue += value2.DoubleValue;
            return value1;
        }

        public static MyDoubleTypeStruct operator /(MyDoubleTypeStruct value1, double value2)
        {
            value1.DoubleValue /= value2;
            return value1;
        }

        public static MyDoubleTypeStruct operator /(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {
            value1.DoubleValue /= value2.DoubleValue;
            return value1;
        }
        public static MyDoubleTypeStruct operator *(MyDoubleTypeStruct value1, double value2)
        {
            value1.DoubleValue *= value2;
            return value1;
        }

        public static MyDoubleTypeStruct operator *(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {
            value1.DoubleValue *= value2.DoubleValue;
            return value1;
        }

        public static bool operator ==(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {

            return value1.DoubleValue == value2.DoubleValue;
        }

        public static bool operator !=(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {

            return value1.DoubleValue != value2.DoubleValue;
        }

        public static bool operator >(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {

            return value1.DoubleValue > value2.DoubleValue;
        }

        public static bool operator <(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {
            
            return value1.DoubleValue < value2.DoubleValue;
        }
        public static bool operator <=(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {

            return value1.DoubleValue <= value2.DoubleValue;
        }

        public static bool operator >=(MyDoubleTypeStruct value1, MyDoubleTypeStruct value2)
        {
            
            return value1.DoubleValue >= value2.DoubleValue;
        }

        public override string ToString() => $"Doublevalue is: {DoubleValue}";
    }
}
