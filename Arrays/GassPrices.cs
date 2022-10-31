using System;
using System.IO;
using System.Linq;

namespace Arrays
{
    class GassPrices
    {
        public static void Run()
        {

            string path = @"D:\OneDriveInn\OneDrive\Desktop\Files for C# exercises\1994_Weekly_Gas_Averages.txt";

            if (File.Exists(path))
            {
                string[] gasPricesArr = File.ReadAllLines(path);
                double[] gasPricesDoubleArr = Array.ConvertAll(gasPricesArr, s => double.Parse(s));

                int[] monthsInYear = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12 };
                double avg = 0;


                for (int i = 0; i < monthsInYear.Length; i++)
                {
                    int weekNum = GetWeeksInTheMonth(monthsInYear[i]);
                    double[] targerArr = new double[weekNum];

                    Array.Copy(gasPricesDoubleArr, 0, targerArr, 0, weekNum);

                    avg = targerArr.Sum() / weekNum;

                    Console.WriteLine($"The average gas price per month {i + 1} is: \t {avg}");
                }


                GetLowestAvgPrice(gasPricesDoubleArr);
                GetHighestAvgPrice(gasPricesDoubleArr);

            }
        }

        public static void GetLowestAvgPrice(double[] gasPriceArr)
        {
            double lowest = gasPriceArr[0];
            int week = 0;
            string month = "";

            for (int i = 0; i < gasPriceArr.Length; i++)
            {
                if (gasPriceArr[i] < lowest)
                {
                    lowest = gasPriceArr[i];
                    week = i + 1;
                }

            }
            month = new DateTime(1994, 1, 1).AddDays(7 * (week - 1)).ToString("MMMM");

            Console.WriteLine($"The lowest average price of the year is week {week}, {month}, number:  {lowest}");

        }

        public static void GetHighestAvgPrice(double[] gasPriceArr)

        {
            double highest = gasPriceArr[0];
            int week = 0;
            int year = 1994;
            string month = "";

            for (int i = 0; i < gasPriceArr.Length; i++)
            {
                if (gasPriceArr[i] > highest)
                {
                    highest = gasPriceArr[i];
                    week = i + 1;
                    month = new DateTime(year, 1, 1).AddDays(7 * (week - 1)).ToString("MMMM");
                }

            }
            Console.WriteLine($"The lowest average price of the year is week {week}, {month}, number:  {highest}");
        }

        public static int GetWeeksInTheMonth(int monthINum)
        {
            var year = 1995;


            var daysInMonth = DateTime.DaysInMonth(year, monthINum);
            var firstDayOfMonth = (int)new DateTime(year, monthINum, 1).DayOfWeek;
            int weeksInMonth = (int)Math.Ceiling((firstDayOfMonth + daysInMonth) / 7.0);
            return weeksInMonth;
        }




    }
}

