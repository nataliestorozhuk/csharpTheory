using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l9SumOfNumbersInString
    {

        public static void Run()
        {
            string userInput = "3214";
            
            char[] arr = new char[userInput.Length];


            for (int i = 0; i < userInput.Length; i++)
            {
                arr[i] = userInput[i];


            }

            int total = 0;
            int largest = userInput[0];
            int smallest = userInput[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > largest)
                    largest = arr[i];
                else if (arr[i] < smallest)
                    smallest = arr[i];
            }

            foreach (char value in arr)
           {

                total += int.Parse(value.ToString());

            }

            Console.WriteLine($"The total is: {total}");
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine($"The smallest number is: {smallest}");

        }
    }
}
