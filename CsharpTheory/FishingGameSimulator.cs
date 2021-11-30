using System;

namespace CsharpTheory
{
    class FishingGameSimulator
    {
        public static void Run()
        {
            const int CUBE_SIDES = 6;
            const int MAX_ROLLS = 5;
            int points = 0;
            int pointsCounter = 0;

            FishingGameSimulator cube = new FishingGameSimulator(CUBE_SIDES);


            Console.WriteLine("This simulates the rolling of a " + CUBE_SIDES + " sided die. ");
            Console.WriteLine("Initial value of the dice: ");
            Console.WriteLine(cube.Value);

            Console.WriteLine("Rolling the dice ");

            for (int i = 0; i < MAX_ROLLS; i++)
            {
                cube.Roll();
                Console.WriteLine();
                Console.WriteLine("Do you want to fish more items? (press 'y' for yes or 'n' for no): ");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    cube.Roll();

                    if (cube.Value == 1)
                    {
                        Console.WriteLine("You got a huge fish!");
                        points = 50;
                    }
                    else if (cube.Value == 2)
                    {
                        Console.WriteLine("You got an old shoe)");
                        points = 40;
                    }
                    else if (cube.Value == 3)
                    {
                        Console.WriteLine("You got a middle fish.)");
                        points = 35;
                    }
                    else if (cube.Value == 4)
                    {
                        Console.WriteLine("You got a goldfish.)");
                        points = 25;
                    }
                    else if (cube.Value == 5)
                    {
                        Console.WriteLine("You got an angelfish.)");
                        points = 10;
                    }
                    else if (cube.Value == 6)
                    {
                        Console.WriteLine("You got a tulka.))");
                        points = 5;
                    }
                   
                    Console.WriteLine("The fishing points are: " + points);
                    pointsCounter += points;

                }
                else
                    Console.WriteLine("The total points are: " + pointsCounter);
            }



        }
        private int Sides { get; set; }
        private int Value { get; set; }


        public FishingGameSimulator(int sides)
        {
            this.Sides = sides;
            Roll();
        }

        private void Roll()
        {
            Random rand = new Random();

            Value = rand.Next(Sides) + 1;

        }

    }
}
