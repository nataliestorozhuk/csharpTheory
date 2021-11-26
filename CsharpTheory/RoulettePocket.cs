using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class RoulettePocket
    {
        public static void Run()
        {

            RoulettePocket roulettePocket = new RoulettePocket(37);

            Console.WriteLine(roulettePocket.GetPocketColor());
        }

        public int PocketNumber { get; set; }

        public RoulettePocket(int pocketNumber)
        {
            this.PocketNumber = pocketNumber;
        }

        public string GetPocketColor()
        {
            if (PocketNumber == 0)
            {
                return "green";
            }

            else if (PocketNumber >= 1 && PocketNumber <= 10)
            {
                if (PocketNumber % 2 == 0)
                {
                    return "black"; //even
                }
                else
                {
                    return "red"; // odd
                }
                            }
            else if (PocketNumber >= 11 && PocketNumber <= 18)
            {
                if (PocketNumber % 2 == 0)
                {
                    return "red"; // even
                }
                else
                {
                    return "black"; // odd

                }

            }
            else if (PocketNumber >= 19 && PocketNumber <= 28)
            {
                if (PocketNumber % 2 == 0)
                {
                    return "red"; // even
                }
                else
                {
                    return "black"; // odd

                }

            }
            else if (PocketNumber >= 29 && PocketNumber <= 36)
            {
                if (PocketNumber % 2 == 0)
                {
                    return "red"; // even
                }
                else
                {
                    return "black"; // odd

                }

            }
            else /*(PocketNumber < 0 && PocketNumber > 36)*/
            {
                return "Error!! The number is outside the range 0-36. Please enter another number.";
            }

        }

    }
}
