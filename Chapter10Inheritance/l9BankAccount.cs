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

        
        public virtual void Deposit(double amount)
        {
            Balance += amount;
            NumOfDepositsPerMonth++;
        }

        
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
            NumOfWithdrawalsPerMonth++;
            
        }

        public void CalcInterest()
        {
            double monthlyInterest = AnnualInterestRate / 12;
             monthlyInterest = Balance * monthlyInterest;
            Balance += monthlyInterest;
           
        }

        public  virtual void MonthlyProcess()
        {
            Balance -= MonthlyServiceCharges;
            CalcInterest();

            NumOfDepositsPerMonth = 0;
            NumOfWithdrawalsPerMonth = 0;
            MonthlyServiceCharges = 0;
           
        }
    }

}
