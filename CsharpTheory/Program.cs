using System;

namespace CsharpTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SavingAccount
            double annualInterestRate = 0.5;
            double startingBalance = 100.0;
            double numOfMonths = 2;

            SavingAccount savingAccount = new SavingAccount(startingBalance);
            for (int i = 0; i < numOfMonths; i++)
            {

                Console.WriteLine("Enter amount deposited into the account during the month: ");
                var deposit = double.Parse(Console.ReadLine());
                savingAccount.Add(deposit);
                Console.WriteLine("Enter amount withdrawn from the account during the month: ");
                var withdrawn = double.Parse(Console.ReadLine());
                savingAccount.Add(withdrawn);
                                
            }

            Console.WriteLine(savingAccount.GetBalanceWithInterestRate()); 



            #endregion

            #region FreezingAndBoiling
            //double temperature = 15;
            //FreezingAndBoilingPoints f = new FreezingAndBoilingPoints(temperature);

            // Display elements will freeze.
            //if (f.IsEthylBoiling())
            //{
            //    Console.WriteLine("Ethyl alcohol will freeze.");
            //}

            //if (f.IsOxygenFreezing())
            //{
            //    Console.WriteLine("Oxygen will freeze.");
            //}

            //if (f.IsWaterFreezing())
            //    Console.WriteLine("Water will freeze.");

            //// Display if elements will boil.
            //if (f.IsEthylFreezing())
            //{
            //    Console.WriteLine("Ethyl alcohol will boil.");
            //}

            //if (f.IsOxygenBoiling())
            //{
            //    Console.WriteLine("Oxygen will boil.");
            //}

            //if (f.IsWaterBoiling())
            //{
            //    Console.WriteLine("Water will boil.");
            //}
            #endregion

            #region MonthDays
            //int month = 2;
            //int year = 1958;
            //MonthDays mD = new MonthDays(month, year);
            //mD.GetNumberOfDays(); 
            #endregion




        }
    }
}
