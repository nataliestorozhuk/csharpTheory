using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class BackwardString
    {
        public static void Run()
        {
        Console.WriteLine("Please enter a string");

           string str = Console.ReadLine();

            Console.WriteLine($"User entered {str}");
            Console.WriteLine($"Reversed will be {BackwardString.GetReverse(str)}");

        }

        public static string GetReverse(string str)
        {
            int l;
            string strReversed = "";

            l = str.Length - 1;

            for (int i = l; i >= 0; i--)
            {
                strReversed = strReversed + str[i];
            }
            return strReversed;
        }
    }
}
