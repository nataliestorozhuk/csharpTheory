using System;
using System.Text;

namespace Chapter9
{
    class SentenceCapitalizer
    {
        public static void Run()
        {
            String text = "hello world. the weather is beautiful. sunny day.";

            //Console.WriteLine($"User entered {text}");

            Console.WriteLine(SentenceCapitalizer.GetSentenceCapitalize(text));

        }

        public static string GetSentenceCapitalize(string str)
        {
            int pos = 0;
            bool capitalize = true;

            StringBuilder sb = new StringBuilder(str);

            while (pos < sb.Length)
            {
                if (sb[pos] == '.')
                {
                    capitalize = true;
                }
                else if (capitalize && !Char.IsWhiteSpace(sb[pos]))
                {
                    sb[pos] = Char.ToUpper(sb[pos]);
                    capitalize = false;
                }
                pos++;

            }
            return sb.ToString();
        }

    }
}


