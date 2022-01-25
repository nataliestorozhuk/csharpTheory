using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8_ClassesAndObjects
{
    class l12HeadsOrTailsGame
    {
        public static void Run()
        {
            
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
}
