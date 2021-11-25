using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpTheory
{
    class DepositAndWithdrawalFiles
    {
public static void Run()
        {
            SavingAccount savingAccount = new SavingAccount(500.00, 15.0);

            string[] lines = File.ReadAllLines(@"D:\OneDriveInn\OneDrive\Desktop\Deposits.txt");
            foreach (var line in lines)
            {


                savingAccount.Add(double.Parse(line));
            }
            Console.WriteLine(savingAccount.GetAccountBalance());

            string[] lines2 = File.ReadAllLines(@"D:\OneDriveInn\OneDrive\Desktop\Withdrawals.txt");
            foreach (var line in lines2)
            {
                savingAccount.Subtract(double.Parse(line));
            }
            Console.WriteLine(savingAccount.GetAccountBalance());
            Console.WriteLine("The ending balance with the total interest earned is: " + savingAccount.GetBalanceWithInterestRate());
            
        }

    }
}
