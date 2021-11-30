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

        public int Sides { get; set; }
        public int Value { get; set; }

        public Cube(int numSides)
        {
            Sides = numSides;
            Roll();
        }

        private void Roll()
        {
            Random rand = new Random();

            Value = rand.Next(Sides) + 1;
        }
       
    }


}
