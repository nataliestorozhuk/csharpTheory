using System;

namespace ClassesAndObjects
{
    class GeometryCalculator
    {
        public static void Run()
        {

            Console.WriteLine("Geometry Calculator");
            Console.WriteLine();
            Console.WriteLine("1. Calculate the Area of a Circle\n2. Calculate the Area of a Rectangle\n" +
                "3. Calculate the Area of a Triangle\n4. Quit");
            Console.WriteLine();
            Console.WriteLine("Please enter your choice from 1-4:");
            String option = Console.ReadLine();
            double opt = Convert.ToDouble(option);

            if (opt < 1 || opt > 4)
            {
                Console.WriteLine("The number is outside the range. Please enter a number from 1-4.");
            }

            else if (opt == 1)
            {
                Console.WriteLine("Please enter the radius of the circle: ");
                string radius = Console.ReadLine();
                double r = Convert.ToDouble(radius);

                Console.WriteLine($"The area of the circle is: {GetCircleArea(r)}");
            }

            else if (opt == 2)
            {
                Console.WriteLine("Please enter a length of the rectangle: ");
                string length = Console.ReadLine();
                double l = Convert.ToDouble(length);
                Console.WriteLine("Please enter a width of the rectangle: ");
                string width = Console.ReadLine();
                double w = Convert.ToDouble(width);
                Console.WriteLine($"The area of the rectangle is: {GetRectangleArea(l, w)}");
            }
            else if (opt == 3)
            {
                Console.WriteLine("Please enter a length of the triangle base: ");
                string baseLength = Console.ReadLine();
                double bL = Convert.ToDouble(baseLength);
                Console.WriteLine("Please enter triangle's height: ");
                string height = Console.ReadLine();
                double h = Convert.ToDouble(height);

                Console.WriteLine($"The area of the triangle is: {GetRectangleArea(bL, h)}");
            }
            else if (opt == 4)
                return;
        }

        public static double GetCircleArea(double radius)
        {
            if (radius < 1)
            {
                Console.WriteLine("Error! Cannot accept negative values.");

            }

            return Math.PI * Math.Pow(radius, 2);
        }
        public static double GetRectangleArea(double length, double width)
        {
            if (length < 1 && width < 1)
            {
                Console.WriteLine("Error! Cannot accept negative values.");

            }
            return length * width;
        }
        public static double GetTriangleArea(double baseLength, double height)
        {
            if (baseLength < 1 && height < 1)
            {
                Console.WriteLine("Error! Cannot accept negative values.");
            }
            return baseLength * height * 0.5;
        }
    }
}
