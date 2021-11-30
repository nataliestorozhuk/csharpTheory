using System;

namespace CsharpTheory
{
    class Die
    {
        public static void Run()
        {
            const int DIE1_SIDES = 6;
            const int MAX_ROLLS = 5;

            Die die1 = new Die(DIE1_SIDES);


            Console.WriteLine("This simulates the rolling of a " + DIE1_SIDES + " sided die. ");
            Console.WriteLine("Initial value of the dice: ");
            Console.WriteLine(die1.Value);

            Console.WriteLine("Rolling the dice ");
                        
            for (int i = 0; i < MAX_ROLLS; i++)
            {
                //die1.roll();
                Console.WriteLine("Do you want to fish more items? (press 'y' for yes or 'n' for no): ");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    die1.roll();

                    Console.WriteLine(die1.Value);
                }
                else

                    return;
            }

        }
        private int Sides { get; set; }
        private int Value { get; set; }


        public Die(int sides)
        {
            this.Sides = sides;
            roll();
        }

        private void roll()
        {
            Random rand = new Random();

            Value = rand.Next(Sides) + 1;

        }

    }
}
