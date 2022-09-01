using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l12MiscellaneousStringOperations
    {
        public static void Run()
        {
            string text = "hello a beautiful world";
            Console.WriteLine(GetWordCount(text));

            char[] chars = { 'N', 'a', 't', 'a', 'l', 'i', 'y', 'a' };
            Console.WriteLine(ArrayToString(chars));

            string words = "nataliya";
            Console.WriteLine(GetMostFrequent(words));

            string string1 = "the dog jumped over the fence";
            string string2 = "the";
            string string3 = "that";
            Console.WriteLine(GetReplacedSubstring(string1, string2, string3));
        }

        public static int GetWordCount(string word)
        {
            string[] words = word.Split(' ');
            return words.Length;
        }

        public static string ArrayToString(char[] chars)
        {
            string str = ""; 

          return new string(chars);
        }

        public static char GetMostFrequent(string word)
        {
            string mostFrequent = "";
            int count = 0;

            String[] words = word.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                int temp = 0;

                for (int j = 0; j < words.Length; j++)
                {

                    if (words[i].Equals(words[j].ToLower()))
                    {
                        temp++;
                    }

                    if (temp > count)
                    {
                        count = temp;
                        mostFrequent = words[i];
                    }
                }
            }
            return mostFrequent[0];
        }

        public static string GetReplacedSubstring(string str1, string str2, string str3)
        {

           return str1.Replace(str2,str3);
        }

    }
}
