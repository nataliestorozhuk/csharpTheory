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

        }

        public string SideUp { get; set; }

        public Coin()
        {

            Toss();
            
        }

        private void Toss()
        {
            Random random = new Random();
            int number = random.Next(2-1);

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
