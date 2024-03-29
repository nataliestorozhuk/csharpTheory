﻿using System;
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
            Console.WriteLine($"It will be {WordCounter.GetWordsAmount(str)} words.");

        }

        public static int GetWordsAmount(string str)
        {
            int a = 0, myWord = 1;

            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    myWord++;
                }
                a++;  
            }
            return myWord;
        }
    }
}
