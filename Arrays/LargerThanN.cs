using System;
using System.Collections.Generic;

namespace Arrays
{
    class LargerThanN
    {
        public static void Run()
        {


            int[] array = { 5, 15, 7, 21, 97, 3, 48, 23 };

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //GetGreaterThenN(array, num);


            //foreach (var item in GetGreaterThenN2(array, num) )
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in GetGreaterThenN2(array, num))
            //{
            //    Console.WriteLine(item);
            //}


            foreach (var item in GetGreaterThenN3(array, num))
            {
                Console.WriteLine(item);
            }


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

        public static void GetGreaterThenN(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > n)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }


        public static int[] GetData()
        {
            return new int[] { 10, 20, 343, 5, 3, 55 };
        }


        public static IEnumerable<int> GetGreaterThenN2(int[] array, int n)
        {
            foreach (int item in array)
            {
                if (item > n)
                {
                    yield return item;
                }
            }
        }


        public static int[] GetGreaterThenN3(int[] array, int n)
        {
            int[] outputArr = new int[array.Length];

            int counter = 0;
            foreach (int item in array)
            {
                if (item > n)
                {
                    outputArr[counter] = item;
                    counter++;
                }
            }

            return outputArr;
        }
    }
}

