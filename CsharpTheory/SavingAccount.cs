using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class SavingAccount
    {

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
