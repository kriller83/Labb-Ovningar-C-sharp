using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Circle
    {
        private double diameter;
        private Point center;

        public void SetDiameter(double diameter)
        {
            if (diameter > 0)
                this.diameter = diameter;
            else
                this.diameter = 5;

        }
        public double GetDiameter()
        {
            return diameter;
        }
        public double GetCircumference()
        {
            double result = diameter * Math.PI;
            return result;
        }
        public void SetCenter(Point myPoint)
        {
            center = myPoint;
        }
        public Point GetCenter()
        {
            return center;
        }
        public string GetCircle()
        {
            return $"diameter = {diameter}\r\nomkrets = {GetCircumference()}\r\nX är = {center.GetX()}\r\nY är = {center.GetY()}";
        }

    }
    //public class Circle
    //{
    //    private double diameter;

    //    public void SetDiameter(double diameter)
    //    {
    //        if (diameter > 0)
    //            this.diameter = diameter;
    //        else
    //            this.diameter = 5;

    //    }
    //    public double GetDiameter()
    //    {
    //        return diameter;
    //    }
    //    public double GetCircumference()
    //    {
    //        double result = diameter * Math.PI;
    //        return result;
    //    }

    //}
}

//f10 och f11