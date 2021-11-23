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

        public SavingAccount(double balance)
        {
            this.balance = balance;

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

            double x = annualInterestRate / 12;
            return balance * x;
        }
    }
}
