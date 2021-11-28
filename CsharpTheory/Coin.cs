using System;

namespace CsharpTheory
{
    class Coin
    {
        public static void Run()
        {
            int headsCounter = 0;
            int tailsCounter = 0;

            Coin coin = new Coin();

            Console.WriteLine("Initial side up is: " + coin.GetSideUp());

            for (int i = 0; i < 20; i++)
            {
                Coin coins = new Coin();
                Console.WriteLine("The side is: " + coins.GetSideUp());

                if (coins.GetSideUp() == "heads")
                {
                    headsCounter++;

                }
                else
                {
                    tailsCounter++;
                }

            }
            Console.WriteLine("Heads: " + headsCounter);
            Console.WriteLine("Tails: " + tailsCounter);
        }

        private string SideUp { get; set; }

        public Coin()
        {
            Toss();
        }

        private void Toss()
        {
            Random random = new Random();
            int number = random.Next(0, 2);


            if (number == 0)
            {
                SideUp = "heads";
            }

            else
            {
                SideUp = "tails";
            }
        }

        public string GetSideUp()
        {
            return SideUp;
        }

    }
}
