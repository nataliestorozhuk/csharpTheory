using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l13AlphabeticTelephoneNumberTranslator
    {

        public static void Run()
        {
            Console.Write("Enter a telephone number (xxx-xxx-xxxx): ");
            string number = Console.ReadLine();

            // Create a dictionary to store the numeric equivalents of alphabetic characters
            var letterToNumber = new Dictionary<char, int>
        {
            { 'a', 2 }, { 'b', 2 }, { 'c', 2 },
            { 'd', 3 }, { 'e', 3 }, { 'f', 3 },
            { 'g', 4 }, { 'h', 4 }, { 'i', 4 },
            { 'j', 5 }, { 'k', 5 }, { 'l', 5 },
            { 'm', 6 }, { 'n', 6 }, { 'o', 6 },
            { 'p', 7 }, { 'q', 7 }, { 'r', 7 }, { 's', 7 },
            { 't', 8 }, { 'u', 8 }, { 'v', 8 },
            { 'w', 9 }, { 'x', 9 }, { 'y', 9 }, { 'z', 9 }
        };


            // Convert the alphabetic characters in the number to their numeric equivalents
            string convertedNumber = "";
            foreach (char c in number)
            {
                if (char.IsLetter(c))
                {
                    convertedNumber += letterToNumber[char.ToLower(c)];
                }
                else
                {
                    convertedNumber += c;
                }
            }


            // Display the converted number
            Console.WriteLine("Converted number: " + convertedNumber);

        }
    }
}
