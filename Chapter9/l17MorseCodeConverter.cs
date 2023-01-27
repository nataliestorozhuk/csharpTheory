using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l17MorseCodeConverter
    {

           static Dictionary<char, string> morseCode = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
        {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
        {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
        {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
        {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
        {'Z', "--.."},

        {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
        {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."},
        {'8', "---.."}, {'9', "----."},

        {'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {'!', "-.-.--"},
        {'-', "-....-"}, {'/', "-..-."}, {'@', ".--.-."}, {'(', "-.--."},
        {')', "-.--.-"}
    };

            public static void Run()
            {
                Console.WriteLine("Enter a string to convert to Morse code:");
                string input = Console.ReadLine();

                string morse = "";


                // Convert each character to its Morse code equivalent
                foreach (char c in input.ToUpper())
                {
                    if (morseCode.ContainsKey(c))
                    {
                        morse += morseCode[c] + " ";
                    }
                }

                Console.WriteLine("Morse code: " + morse);

            }
        
    }
}
