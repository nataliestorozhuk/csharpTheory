using System;

namespace CsharpTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 2;
            int year = 1958;

            MonthDays mD = new MonthDays(month, year);

            mD.GetNumberOfDays();

        }
    }
}
