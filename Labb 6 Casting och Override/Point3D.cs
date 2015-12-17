﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Casting_och_Override
{
    internal class Point3D
    {
        public int Z { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator Point(Point3D point3D)
        {
            return new Point(point3D.X, point3D.Y);
        }

        public override string ToString() => $"X: {X}, Y:{Y}, Z:{Z}";
    }
}
