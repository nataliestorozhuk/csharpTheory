using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l8SumOfDigitsInString
    {

        public static void Run()
        {
            string numbers = ( "5,4,1,7" );

            string[] splitted = numbers.Split(",");

            int total = 0;

            //for (int i = 0; i < splitted.Length; i++)
            //{

            //     total += Int16.Parse(splitted[i]);
            //}

            foreach (string digit in splitted)
            {
                total += Int16.Parse(digit);
            }
                Console.WriteLine(total);
            
        }
    }
}
