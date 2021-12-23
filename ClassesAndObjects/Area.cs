using System;

namespace ClassesAndObjects
{
    class Area
    {
        public static void Run()
        {

        }

        public static double GetArea(double rd)
        {
            return Math.PI * Math.Pow(rd, 2);
        }
        public static double GetArea(double width, double length)
        {
            return width * length;
        }
        public static double GetArea(double cylinderRadius, double height)
        {
            return Math.PI * Math.Pow(cylinderRadius, 2) * height;
        }
    }
}
