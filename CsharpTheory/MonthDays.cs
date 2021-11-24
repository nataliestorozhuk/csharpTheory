using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
   public class MonthDays
    {
        public static void run()
        {
            int month = 2;
            int year = 1958;
            MonthDays mD = new MonthDays(month, year);
            mD.GetNumberOfDays();
        }

        private int month;
        private int year;

        public MonthDays(int month, int year)
        {
            this.month = month;
            this.year = year;

        }

        public void GetNumberOfDays()
        {

            switch (month)
            {
                case 1:
                    if (month == 1)
                        Console.WriteLine("31 days");
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                        Console.WriteLine("29 days");
            else
                        Console.WriteLine("28 days");
                    break;
                case 3:
                    if (month == 3)
                        Console.WriteLine("31 days");
                    break;
                case 4:
                    if (month == 4)
                        Console.WriteLine("30 days");
                    break;
                case 5:
                    if (month == 5)
                        Console.WriteLine("31 days");
                    break;
                case 6:
                    if (month == 6)
                        Console.WriteLine("30 days");
                    break;
                case 7:
                    if (month == 7)
                        Console.WriteLine("31 days");
                    break;
                case 8:
                    if (month == 8)
                        Console.WriteLine("31 days");
                    break;
                case 9:
                    if (month == 9)
                        Console.WriteLine("30 days");
                    break;
                case 10:
                    if (month == 10)
                        Console.WriteLine("31 days");
                    break;
                case 11:
                    if (month == 11)
                        Console.WriteLine("30 days");
                    break;
                case 12:
                    if (month == 12)
                        Console.WriteLine("31 days");
                    break;
            }
            
        }
    }
}
