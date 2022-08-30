using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l7CheckWriter
    {

        public static void Run()
        {
            var date = "08/23/2022";
            var payeesName = "John Philips";
            var amount = "185";

            WordNumber wordNumber = new WordNumber(); 


            Console.WriteLine($"                                        Date: {date}\n Pay to the Order of:" +
                $"     {payeesName}              ${amount}");
            

            //Console.WriteLine(new NumberTextConverter().ToText(amount));


        }

    }
    public class WordNumber
    {
        String[] numbers = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        public String GetOnes(int num)
        {
            String result = "";

            switch (num)
            {
                case 0:

                    result += "";
                    break;

                case 1:

                    result += "one";
                    break;

                case 2:

                    result += "two";
                    break;

                case 3:

                    result += "three";
                    break;

                case 4:

                    result += "four";
                    break;

                case 5:

                    result += "five";
                    break;

                case 6:

                    result += "six";
                    break;

                case 7:

                    result += "seven";
                    break;

                case 8:

                    result += "eight";
                    break;

                case 9:

                    result += "nine";
                    break;

            }
            return result;
        }

        public String GetTwos(int num)
        {
            String result = "";

            switch (num)
            {
                case 10:

                    result += "ten";
                    break;

                case 11:

                    result += "eleven";
                    break;

                case 12:

                    result += "twelve";
                    break;

                case 13:

                    result += "thirteen";
                    break;

                case 14:

                    result += "fourteen";
                    break;

                case 15:

                    result += "fifteen";
                    break;

                case 16:

                    result += "sixteen";
                    break;

                case 17:

                    result += "seventeen";
                    break;

                case 18:

                    result += "eighteen";
                    break;

                case 19:

                    result += "nineteen";
                    break;
            }

            if (num >= 1 && num <= 10)
            {
                switch (num)
                {
                    case 0:
                        result += "";
                        break;

                    case 1:
                        result += "one";
                        break;

                    case 2:
                        result += "two";
                        break;

                    case 3:
                        result += "three";
                        break;

                    case 5:
                        result += "five";
                        break;

                    case 6:
                        result += "six";
                        break;

                    case 7:
                        result += "seven";
                        break;

                    case 8:
                        result += "eight";
                        break;

                    case 9:
                        result += "nine";
                        break;
                }
            }
            return result;

        }

        public String GetHundreds(int num)
        {
            String result = "";

            switch (num / 100)
            {

                case 1:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 2:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 3:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 4:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 5:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 6:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 7:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 8:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

                case 9:

                    result += numbers[num / 100] + "hundred" + GetTwos((num % 100));
                    break;

            }
            return result;
        }

        public String GetThousands(int num)
        {
            String result = "";

            int thousand = num / 1000;
            int hundred = (num % 1000);

            switch (thousand)
            {

                case 1:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 2:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 3:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 4:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 5:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 6:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 7:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 8:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;

                case 9:

                    result += numbers[thousand] + "thousand" + GetTwos(hundred) + "hundred" + GetTwos((num % 1000) % 100);
                    break;
            }
            return result;
        }
    }
}
