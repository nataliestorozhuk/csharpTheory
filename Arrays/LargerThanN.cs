using System;

namespace Arrays
{
    class LargerThanN
    {
        public static void Run()
        {
            int result;

            int[] array = { 5, 15, 7, 21, 97, 3, 48, 23 };

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            result = GetGreaterThenN(array, num);

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

        public static int GetGreaterThenN(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (n > array[i])
                {
                    Console.WriteLine("\nn");
                }
            }
            return 1;
        }
    }
}

