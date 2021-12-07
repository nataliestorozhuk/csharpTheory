using System;
using System.Collections;

namespace Arrays
{
    class ChargeAccountValidation
    {
        public static void Run()
        {
            ArrayList array = new ArrayList();
            array.Add(5658845);
            array.Add(4520125);
            array.Add(7895122);
            array.Add(8777541);
            array.Add(8451277);
            array.Add(1302850);
            array.Add(8080152);
            array.Add(4562555);
            array.Add(5552012);
            array.Add(5050552);
            array.Add(7825877);
            array.Add(1250255);

            Console.WriteLine("Enter the charge account number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num != array == true)
            {
                Console.WriteLine("The number is valid. ");
            }
            else
                Console.WriteLine("The number is valid. ");
        }

        public static int SequantialSearch(int[] array, int value)
        {
            int index = 0;          //Loop control variable.
            int element = -1;      //Element the value is found at.
            bool found = false;   //Flag indicating search result.

            //Search the array.
            while (!found && index < array.Length)
            {
                if (array[index] == value)
                {
                    found = true;
                    element = index;
                }
                index++;
            }


            return element;
        }
    }
}
