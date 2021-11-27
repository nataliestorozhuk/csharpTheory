using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class Coin
    {
        public static void Run()
        {
            int headsCounter = 0;
            int tailsCounter = 0;

            Coin coin = new Coin();

            Console.WriteLine("Initial side up is: " + coin.SideUp);

            for (int i = 0; i < 20; i++)
            {
                Coin coins = new Coin();
               
                if(coin.SideUp == "heads")
                {
                    headsCounter++;

                }
                else
                {
                    tailsCounter++;
                }

                Console.WriteLine("Heads: " + headsCounter);
                Console.WriteLine("Tails: " + tailsCounter);
            }
        }
        
        public string SideUp { get; set; }

        public Coin()
    {
            Toss();            
        }

        private void Toss()
        {
            Random random = new Random();
            int number = random.Next(2-0);

            if (number == 0)
            {
                SideUp = "heads";
            }

            if (number == 1)
            {
                SideUp = "tails";
            }
        }
            }
}
