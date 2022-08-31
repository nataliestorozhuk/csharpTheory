using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l11SalesAnalysis
    {
        public static void Run()
        {

            string data = "2541.36,2965.88,1965.32,1845.23,7021.11,9652.74,1469.36";


            string[] splitted = data.Split(",");

            double total = 0;

            foreach (string digit in splitted)
            {
                total += Double.Parse(digit);
            }
            Console.WriteLine($"The total amount for a week is: {total}");
            Console.WriteLine($"The avarage for a week is: {total / splitted.Length}");
        }

    }
}
