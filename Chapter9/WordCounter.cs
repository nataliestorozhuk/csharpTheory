using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class WordCounter
    {

        public static void Run()
        {
            Console.WriteLine("Please enter a string");

            string str = Console.ReadLine();

            Console.WriteLine($"User entered {str}");
            Console.WriteLine($"It will be {BackwardString.GetReverse(str)}");

        }

        public static string GetWordsAmount(string str)
        {

        }
    }
}
