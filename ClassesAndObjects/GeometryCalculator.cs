using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class GeometryCalculator
    {
        public static void Run()
        {

        }

        public static double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double GetRectangleArea(double length, double width)
        {
            return length * width;
        }
        public static double GetTriangleArea(double baseLength, double height)
        {
            return baseLength * height * 0.5;
        }
    }
}
