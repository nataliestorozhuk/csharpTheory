using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    public class Cube
    {
        //private int sides;
        //private int value;

        public int sides { get; set; }
        public int value { get; set; }

        public Cube(int numSides)
        {
            sides = numSides;
            roll();
        }

        private void roll()
        {
            Random rand = new Random();

            value = rand.Next(sides) + 1;
        }
       
    }


}
