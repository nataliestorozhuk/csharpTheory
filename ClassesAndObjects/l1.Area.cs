using System;

namespace ClassesAndObjects
{
    class Area
    {
        public static void Run()
        {           
            Console.WriteLine($"The area of a circle is: {GetArea(1.3)}");
            Console.WriteLine();
            Console.WriteLine($"The area of a rectangle is: {GetArea(7.0, 5.5)}");
            Console.WriteLine();
            Console.WriteLine($"The area of a cylinder is: {GetArea(1.5, 5)}");
        }
        // Method that returns circle's area.
        public static double GetArea(double rd)
        {
            return Math.PI * Math.Pow(rd, 2);
        }
        // Method that returns rectangle's area.
        public static double GetArea(double width, double length)
        {
            return width * length;
        }
        // Method that returns cylinder's area.
        public static double GetArea(double cylinderRadius, int height)
        {
            return Math.PI * Math.Pow(cylinderRadius, 2) * height;
        }
    }
}
