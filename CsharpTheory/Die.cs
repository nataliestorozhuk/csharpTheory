using System;

namespace CsharpTheory
{
    class Die
    {
        public static void Run()
        {
            const int DIE1_SIDES = 6;
            const int DIE2_SIDES = 12;
            const int MAX_ROLLS = 5;

            Die die1 = new Die(DIE1_SIDES);
            Die die2 = new Die(DIE2_SIDES);

            Console.WriteLine("This simulates the rolling of a " + DIE1_SIDES + " sided die and a " + DIE2_SIDES + " sided die.");
            Console.WriteLine("Initial value of the dice: ");
            Console.WriteLine(die1.Value + " " + die2.Value);

            Console.WriteLine("Rolling the dice " + MAX_ROLLS + " times.");

            for (int i = 0; i < MAX_ROLLS; i++)
            {
                die1.roll();
                die2.roll();

                Console.WriteLine(die1.Value + " " + die2.Value);
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
