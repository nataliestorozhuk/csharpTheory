using System;

namespace CsharpTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SavingAccount
            double numOfMonths = 2;
            double deposits = 0;
            double withdrawals = 0;
            
          
            

            SavingAccount savingAccount = new SavingAccount(500.0, 23.0);
            for (int i = 0; i < numOfMonths; i++)
            {

                Console.WriteLine("Enter amount deposited into the account during the month " + (i + 1) + ": ");
                 deposits = deposits + double.Parse(Console.ReadLine());
                savingAccount.Add(deposits);
                
                Console.WriteLine("Enter amount withdrawn from the account during the month " + (i + 1) + ": ");
                 withdrawals += double.Parse(Console.ReadLine());
                savingAccount.Subtract(withdrawals);
               
                                
            }

            Console.WriteLine("The ending balance is: " + savingAccount.GetAccountBalance());
            Console.WriteLine("The total amount of deposits is: " + deposits);
            Console.WriteLine("The total amount of withdrawals is: " + withdrawals);
            Console.WriteLine("The total interest earned: " + savingAccount.GetBalanceWithInterestRate());



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
