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
    }
}
