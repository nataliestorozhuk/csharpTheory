using System;

namespace CsharpTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = 15;
            FreezingAndBoilingPoints f = new FreezingAndBoilingPoints(temperature);

            // Display elements will freeze.
            if (f.IsEthylBoiling())
            {
                Console.WriteLine("Ethyl alcohol will freeze.");
            }

            if (f.IsOxygenFreezing())
            {
                Console.WriteLine("Oxygen will freeze.");
            }

            if (f.IsWaterFreezing())
                Console.WriteLine("Water will freeze.");

            // Display if elements will boil.
            if (f.IsEthylFreezing())
            {
                Console.WriteLine("Ethyl alcohol will boil.");
            }

            if (f.IsOxygenBoiling())
            {
                Console.WriteLine("Oxygen will boil.");
            }

            if (f.IsWaterBoiling())
            {
                Console.WriteLine("Water will boil.");
            }


            #region MonthDays
            //int month = 2;
            //int year = 1958;
            //MonthDays mD = new MonthDays(month, year);
            //mD.GetNumberOfDays(); 
            #endregion




        }
    }
}
