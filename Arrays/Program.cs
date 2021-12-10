using System;
using System.Drawing;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //SamplesArray.Run();
            //LargerThanN.Run();
            //ChargeAccountValidation.Run();
            //RainfallClass.Run();


        Point[] points = 
                { 
                    new Point(100, 200),
                    new Point(150, 250), 
                    new Point(250, 375),
                    new Point(275, 395), 
                    new Point(295, 450) 
                };

            // is greater than 100000.
            Point first = Array.Find(points, ProductGT10);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
        }

        // Return true if X times Y is greater than 100000.
        static bool ProductGT10(Point p)
        {
            return p.X * p.Y > 100000;
        }
    
    }
}
