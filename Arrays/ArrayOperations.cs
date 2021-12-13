using System;

namespace Arrays
{
    class ArrayOperations
    {
        public static void Run()
        {
            double[] array = new double[] { 10, 15, 20, 25, 5, 30, 13 };

            Console.WriteLine($"The total values in the array is: {GetTotal(array)}");
            Console.WriteLine($"The average of values in the array is: {GetAverage(array)}");
            Console.WriteLine($"The highest value in the array is: {GetHighest(array)}");
            Console.WriteLine($"The lowest value in the array is: {GetLowest(array)}");
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

        public static double GetAverage(double[] arr)
        {
            double avg = 0;

            foreach (var item in arr)
            {
                avg += item;
            }
            return avg / arr.Length;
        }

        public static double GetHighest(double[] arr) 
        {
            double highest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > highest)
                {
                    highest = arr[i];
                }
            }
            return highest;
        }

        public static double GetLowest(double[] arr)
        {
            double lowest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                }
            }
            return lowest;
        }
    }
}
