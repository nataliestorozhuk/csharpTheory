using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l16LongestWordInString
    {

        public static void Run()
        {
            string sentence = ("The quick brown fox jumped over the lazy dog flslslslslslslsls");

            string[] words = sentence.Split(" ");

            //will hold the length of the longest word
            var longestWord = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > longestWord)
                    longestWord = words[i].Length;
            }

            Console.WriteLine(longestWord);
        }
    }

    class Words
    {
        public int Index { get; set; }
        public string Word { get; set; }
        public int Len { get; set; }
            
    }
}
