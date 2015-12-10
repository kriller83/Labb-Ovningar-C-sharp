using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3;

namespace Ovningsuppgifter_ARV
{
    internal class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D()
        {
            Z = 35;
            X = 45;
            Y = 55;
        }
        public Point3D(int z, int x, int y) : this()
        {
            Z = z;
            X = x;
            Y = y;
        }
        public override string ToString() /*=> $"X är = {X} och Y är = {Y} och Z = {Z}";*/
        {
            return $"Z: {Z} X: {X} & Y: {Y} {base.ToString()}";
        }
    }
}
