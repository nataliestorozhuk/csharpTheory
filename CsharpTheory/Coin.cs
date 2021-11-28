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
                //Coin coins = new Coin();
                Console.WriteLine("The side is: " + coin.Toss());

                if (coin.Toss() == "heads")
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

        //public Coin()
        //{
        //    Toss();
        //}

        public string Toss()
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
            return SideUp;
        }

        public string GetSideUp()
        {
            return SideUp;
        }

    }
}
