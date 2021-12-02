using System;

namespace Arrays
{
    class RainfallClass
    {
        public static void Run()
        {
            int jan = 50;
            int feb = 40;
            int mar = 30;

            var result = CollectRainData(new double[] { jan, feb, mar }, 3);
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
                output = output / 3;
            }

            else if (function == 3)
            {
                int max = 0;
                for (int i = 1; i < arr.Length; i++)
                {

                    if (arr[i] > arr[max])
                    {
                        max = i;
                    }
                    return max;
                }
            }
            else if (function == 4)
            {
                int min = 0;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[min])
                    {
                        min = i;
                    }
                    return min;
                }
            }
            return output;

        }
    }
}
