using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    public class Dice
    {
        //private int sides;
        //private int value;

        public int Sides { get; set; }
        public int Value { get; set; }

        public Dice(int numSides)
        {
            Sides = numSides;
            Roll();
        }

        public int Roll()
        {

            Random rand = new Random();

            Value = rand.Next(Sides) + 1;

            return Value;
        }
       
    }


}
