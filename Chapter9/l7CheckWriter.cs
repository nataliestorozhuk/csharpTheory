using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l7CheckWriter
    {
        static Dictionary<int, string> numbers = new Dictionary<int, string>()
    {
        {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"},
        {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"},
        {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"},
        {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"},
        {18, "eighteen"}, {19, "nineteen"}, {20, "twenty"}
    };

        public static void Run()
        {
            var date = "08/23/2022";
            var payeesName = "John Philips";
            decimal amount  = decimal.Parse("20.15");


            string spelledOutAmount = "";
            int dollars = (int)amount;
            int cents = (int)(amount * 100) % 100;



            if (dollars > 20)
            {
                spelledOutAmount += numbers[dollars / 100] + " hundred ";
                dollars %= 100;
                if (dollars > 0)
                {
                    spelledOutAmount += numbers[dollars] + " dollars";
                }
            }
            else
            {
                spelledOutAmount += numbers[dollars] + " dollars";
            }
            spelledOutAmount += " and " + numbers[cents] + " cents";

            Console.WriteLine("------------------------------");
            Console.WriteLine("Date: " + date);
            Console.WriteLine("Pay to the order of: " + payeesName);
            Console.WriteLine("$" + amount);
            Console.WriteLine("(" + spelledOutAmount + ")");
            Console.WriteLine("------------------------------");


        }
    }
}
