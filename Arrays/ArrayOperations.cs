using System;

namespace Arrays
{
    class ArrayOperations
    {
        public static void Run()
        {
            double[] array = new double[] { 10, 15, 20, 25, 5, 30, 13 };

            Console.WriteLine($"The total values in the array is: {GetTotal(array)}");
        }


        public static double GetTotal(double[] arr)
        {
            double total = 0;
            foreach (var item in arr)
            {
                total += item;
            }
            return total;
        }
    }
}
