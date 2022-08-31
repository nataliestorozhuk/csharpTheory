using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l10WordCounter
    {

        public static void Run()
        {

            string text = "the big red fox jumped over the lazy dog";

            int wordCount = 1;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    wordCount++;
                } 
            }
            Console.WriteLine($"There are {wordCount} words in a sentence");
        }
    }
}
