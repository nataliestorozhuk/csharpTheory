using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l15PigLatin
    {

        public static void Run()
        {
            string sentence = "I SLEPT MOST OF THE NIGHT";

            string[] words = sentence.Split(' ');
            string[] pigLatinWords = words.Select(ConvertToPigLatin).ToArray();
            string pigLatinSentence = string.Join(" ", pigLatinWords);
            



        }

         static  string ConvertToPigLatin(string word)
        {
            if (word.Length == 0)
            {
                return word;
            }

            char firstLetter = word[0];

            if (IsVowel(firstLetter))
            {
                return word + "way";
            }
            else
            {
                return word.Substring(1) + firstLetter + "ay";
            }
        }

        static bool IsVowel(char letter)
        {
            return "aeiouAEIOU".IndexOf(letter) != -1;
        }

    }
    }
}
