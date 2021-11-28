using System;

namespace CsharpTheory
{
    class TossingCoinsForAdollar
    {
        public static void Run()
        {
            double balance = 0.0;


            Coin quarter = new Coin();
            Coin dime = new Coin();
            Coin nickel = new Coin();

            while (balance <= 1.0)
            {
                double q = quarter.Toss() == "heads" ? 0.25 : 0.0;
                double d = dime.Toss() == "heads" ? 0.10 : 0.0;
                double n = nickel.Toss() == "heads" ? 0.05 : 0.0;

                balance += q + d + n;
                Console.WriteLine(q);
                Console.WriteLine(d);
                Console.WriteLine(n);

            }
            Console.WriteLine();
            Console.WriteLine($"Your balane is: ${balance}");

        }
    }
}
