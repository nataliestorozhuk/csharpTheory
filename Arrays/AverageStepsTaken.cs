using System;
using System.IO;
using System.Linq;

namespace Arrays
{
    class AverageStepsTaken
    {
        public static void Run()
        {
            string path = @"D:\OneDriveInn\OneDrive\Desktop\Files for C# exercises\steps.txt";

            if (File.Exists(path))
            {
                string[] stepsArr = File.ReadAllLines(path);
                //converting string elements into integer.
                int[] stepsIntArr = Array.ConvertAll(stepsArr, s => int.Parse(s));

                //creating an array of day in the months.
                int[] yearArr = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int total = 0;
                int avg = 0;
                int minDay = 0;

                for (int i = 0; i < yearArr.Length; i++)
                {
                    // create target array where values will be copied from stepsIntArr
                    int[] targerArr = new int[yearArr[i]];
                    //using Copy method of Array class 
                    Array.Copy(stepsIntArr, minDay, targerArr, 0, yearArr[i]);

                    minDay += yearArr[i];
                    //finding average steps per month taken.
                    avg = targerArr.Sum() / yearArr[i];

                    //foreach (var item in targerArr)
                    //{
                    //    total += item;
                    //}


                    Console.WriteLine($"The average steps per month {i+1} is: { avg}");


                }

                Console.WriteLine(total);
                //Console.WriteLine($"The average number of steps taken in January is: {GetJan(stepsIntArr)}");
                //Console.WriteLine($"The average number of steps taken in February is: {GetFeb(stepsIntArr)}");
                //Console.WriteLine($"The average number of steps taken in March is: {GetMar(stepsIntArr)}");
                //Console.WriteLine($"The average number of steps taken in April is: {GetApr(stepsIntArr)}");
                //Console.WriteLine($"The average number of steps taken in May is: {GetMay(stepsIntArr)}");
            }

        }
        public static int GetJan(int[] arr)
        {
            int month1 = 0;

            for (int i = 0; i < 31; i++)
            {

                month1 += arr[i];

            }
            return month1 / 31;
        }

        public static int GetFeb(int[] arr)
        {
            int month2 = 0;

            for (int i = 31; i < 59; i++)
            {

                month2 += arr[i];

            }
            return month2 / 28;

        }
        public static int GetMar(int[] arr)
        {
            int month3 = 0;

            for (int i = 59; i < 90; i++)
            {

                month3 += arr[i];

            }
            return month3 / 31;
        }
        public static int GetApr(int[] arr)
        {
            int month4 = 0;

            for (int i = 90; i < 120; i++)
            {

                month4 += arr[i];

            }
            return month4 / 30;
        }
        public static int GetMay(int[] arr)
        {
            int month5 = 0;

            for (int i = 120; i < 150; i++)
            {

                month5 += arr[i];

            }
            return month5 / 31;
        }

    }
}
