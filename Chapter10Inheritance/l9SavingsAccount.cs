using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l9SavingsAccount : l9BankAccount
    {
        public static bool IsActive { get; set; }

        public l9SavingsAccount(double balance, double interestRate) : base(balance, interestRate)
        {
            IsActive = Balance >= 25;

        }

        public override void Withdraw(double amount)
        {
            if(base.Balance < amount)
            {
                 Console.WriteLine("You can't withdraw because you don't have money in the account");
                //Environment.Exit(0);
            }
            else if(Balance < 25) {
                Console.WriteLine("Your account balance is too low, and your account is inactive.");
                IsActive = false;
            }
            else
            {
               base.Withdraw(amount);
            }
        }

        
        public override void Deposit(double amount)
        {
           base.Deposit(amount);

            if(base.Balance > 25)
            {
                Console.WriteLine("Your account is active!");
                IsActive = true;
                            }
        }

        public void MonhlyProcess()
        {
            if(NumOfWithdrawalsPerMonth > 4)
            {
                MonthlyServiceCharges += 1;
            }
            if(Balance < 25)
            {
                Console.WriteLine("The account is inactive, your balance less then $25. ");
                IsActive = false;
            }

        }
    }
}
