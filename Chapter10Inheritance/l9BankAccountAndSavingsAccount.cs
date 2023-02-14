using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l9BankAccountAndSavingsAccount
    {

    public static void Run()
        {
            l9BankAccount savingsAccount = new l9SavingsAccount(100, 2.1);

           // savingsAccount.deposit(100);
            savingsAccount.Withdraw(50);
            savingsAccount.Deposit(35);

            Console.WriteLine("Balance: $ " + savingsAccount.Balance + "\nInterest: $" + savingsAccount.AnnualInterestRate + "\n#Deposits: "
                +savingsAccount.NumOfDepositsPerMonth + "\n#Withdrawals: " + savingsAccount.NumOfWithdrawalsPerMonth);
        }
    }
}
