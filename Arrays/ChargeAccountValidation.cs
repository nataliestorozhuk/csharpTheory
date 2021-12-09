using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Arrays
{
    class ChargeAccountValidation
    {
        public static void Run()
        {
            int result;

            int[] array = {5658845, 4520125, 7895122, 8777541, 8451277, 1302850, 8080152, 4562555, 5552012, 5050552, 7825877, 1250255 };
            //List<int> a = new List<int>();
            string path = @"D:\OneDriveInn\OneDrive\Desktop\ChargeAccountModification.txt";

            if (!File.Exists(path)) {

                int[] createText = { 5658845, 4520125, 7895122, 8777541, 8451277, 1302850, 8080152, 4562555, 5552012, 
                    5050552, 7825877, 1250255 };

                // Array.Convert()
                File.WriteAllLines(path, Array.ConvertAll(createText, x => x.ToString()) );
            }

            Console.WriteLine("Enter the charge account number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            result = SequantialSearch(array, num);

            if (result != -1)
            {
                Console.WriteLine("The number is valid. ");
            }
            else
                Console.WriteLine("The number is invalid. ");
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
