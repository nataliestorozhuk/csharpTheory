using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class SavingAccount
    {
        public static void Run()
        {
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
        }


        private double annualInterestRate;
        private double balance;

        public SavingAccount(double balance, double annualInterestRate)
        {
            this.balance = balance;
            this.annualInterestRate = annualInterestRate;

        }



        public double Subtract(double subtractingAmount)
        {
            balance -= subtractingAmount;
            return balance;
        }

        public double Add(double add)
        {
            balance += add;
            return balance;
        }

        public double GetBalanceWithInterestRate()
        {

            double monthlyInterest = annualInterestRate / 12;
            return (balance * monthlyInterest) + balance;
        }

        public double GetAccountBalance()
        {
            return balance;
        }

        public double GetAnnualInterestRate()
        {
            return annualInterestRate;
        }
    }
}
