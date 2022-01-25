using System;
using System.Threading;

namespace Chapter8_ClassesAndObjectsj
{
    class l12HeadsOrTailsGame
    {
        public static void Run()
        {
            Coin coin = new Coin();

            Player player1 = new Player("Kate", "");
            Player player2 = new Player("Mark", "");

            int player1Points = 0;
            int player2Points = 0;

            while ( true )
            {
                //Console.WriteLine($" {player1.Name} please guess the side of the coin: heads or tails");
                string player1Guess = coin.Toss(); /*Console.ReadLine();*/

                player1.Side = coin.Toss();

                if (player1Guess == player1.Side)
                {
                    player1Points++;
                }
                else
                {
                    player1Points--;
                }
                
                Console.WriteLine($"Player's {player1.Name} points are:  {player1Points}");
                if (player1Points == 5) break;
                
                //Thread.Sleep(100);

                //Console.WriteLine($" {player2.Name} please guess the side of the coin: heads or tails");

                string player2Guess = coin.Toss(); /*Console.ReadLine();*/

                player2.Side = coin.Toss();

                if (player2Guess == player2.Side)
                {
                    player2Points++;
                }
                else
                {
                    player2Points--;
                }
              
                Console.WriteLine($"Player's {player2.Name}, points are: {player2Points}");
                if (player2Points == 5)  break;
            }

            if (player1Points == 5)
            {
                Console.WriteLine($"{player1.Name} is a winner!");

            }
            else if (player2Points == 5)
            {
                Console.WriteLine($"{player2.Name} is a winner!");
            }
        }
    }

    class Coin
    {
        private string SideUp { get; set; }

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
    class Player
    {

        public string Name { get; set; }
        public string Side { get; set; }

        public Player(string name, string side)
        {
            Name = name;
            Side = side;
        }
    }
}




