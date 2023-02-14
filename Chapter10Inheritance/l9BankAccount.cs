using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal abstract class l9BankAccount
    {
        public double Balance { get; set; }
        public int NumOfDepositsPerMonth { get; set; }
        public int NumOfWithdrawalsPerMonth { get; set; }
        public double AnnualInterestRate { get; set; }
        public double MonthlyServiceCharges { get; set; }

        protected l9BankAccount(double balance, double interestRate)
        {
            Balance = balance;
            AnnualInterestRate = interestRate;
        }

        
        public void deposit(double amount)
        {
            Balance += amount;
            NumOfDepositsPerMonth++;
        }

        
        public void withdraw(double amount)
        {
            Balance -= amount;
            NumOfWithdrawalsPerMonth++;
            
        }

        public void calcInterest()
        {
            double monthlyInterest = AnnualInterestRate / 12;
             monthlyInterest = Balance * monthlyInterest;
            Balance += monthlyInterest;
           
        }

        public void monthlyProcess()
        {
            Balance -= MonthlyServiceCharges;
            calcInterest();

            NumOfDepositsPerMonth = 0;
            NumOfWithdrawalsPerMonth = 0;
            MonthlyServiceCharges = 0;
           
        }
    }

}
