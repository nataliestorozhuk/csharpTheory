using System;

namespace Arrays
{
    class RainfallClass
    {
        public static void Run()
        {
            int jan = 10;
            int feb = 20;
            int mar = 5;
            int apr = 40;
            // 
            var result = CollectRainData(new double[] { jan, feb, mar, apr }, 3);
            Console.WriteLine(result);


        }

        public static double CollectRainData(double[] arr, int function)
        {
            double output = 0.0;


            foreach (var item in arr)
            {
                output += item;
            }

            if (function == 1)
            {
                _ = output;
            }

            else if (function == 2)
            {
                output = output / 4;
            }

            else if (function == 3)
            {

                double max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {

                    if (arr[i] > max)
                    {
                        max = arr[i];

                    }
                }
                return max;
            }
            else if (function == 4)
            {
                double min = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;
            }
            return output;

        }
    }
}
