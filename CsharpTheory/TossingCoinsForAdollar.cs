using System;

namespace CsharpTheory
{
    class TossingCoinsForAdollar
    {
        public static void Run()
        {
            double balance = 0.0;

            //Coin quarter = new Coin();
            //Coin dime = new Coin();
            //Coin nickel = new Coin();

            Coin coins = new Coin();

            while (balance <= 1.0)
            {
                double quater = coins.Toss() == "heads" ? 0.25 : 0.0;
                double dime = coins.Toss() == "heads" ? 0.10 : 0.0;
                double nickle = coins.Toss() == "heads" ? 0.05 : 0.0;

                balance += quater + dime + nickle;
                Console.WriteLine(quater);
                Console.WriteLine(dime);
                Console.WriteLine(nickle);

            }
            Console.WriteLine();
            Console.WriteLine($"Your balane is: ${balance}");

        }
    }
}
