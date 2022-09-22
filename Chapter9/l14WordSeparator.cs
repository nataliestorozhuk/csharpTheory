using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l14WordSeparator
    {

        public static void Run()
        {
            var sentence = "StopAndSmellTheRoses.";
           //to keep track of the indexes of the elements in the string array.
            int index = 0;
            string result = " ";

            for (int i = 0; i < sentence.Length; i++)
            {
                if(Char.IsUpper(sentence[i]) && index > 0)
                {
                    result += " ";
                    result += Char.ToLower(sentence[i]);
            }else
            {
                result += sentence[i];
            }
                index++;
                }

            Console.WriteLine("Original sentence: " + sentence + "\nFormatted sentence: " + result);

        }
    }
}
