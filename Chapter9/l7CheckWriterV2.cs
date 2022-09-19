using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l7CheckWriterV2
    {
            StringBuilder convertedNumber;

        public static void Run()
        {
            var date = "08/23/2022";
            var payeesName = "John Philips";
            var amount = "185";






        }

		public void  ConvertNumber (char paymentChar, int paymentInt)
		{
			var testTens = false;
			var digit = 0;
			string[] ones = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
			string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };


			bool continueProgram = false;
			//handles the values between 1-19 and 10000
			if ((paymentInt >= 0 && paymentInt <= 19) || paymentInt == 10000)
			{
				if (paymentInt < 1.0 && paymentInt >= 0.0)
					convertedNumber.Append("zero");
				else if (paymentInt <= 9)
					convertedNumber.Append(ones[paymentInt - 1]);
				else if (paymentInt != 10000)
					convertedNumber.Append(teens[paymentInt - 10]);
				else
					convertedNumber.Append("ten thousand");

				convertedNumber.Append(" "); //adds a space
				continueProgram = true; //temporarily used to test whether or not the value has been converted
										//if not, resume the conversion 
			}

			if (!continueProgram) 
			{
				for (int count = 0; count < (int)strlen(paymentChar); count++)
				{
					testTens = false;

					//gets the digit value that we are going to convert by subtracting 48 from the ASCII value of the char
					dDear TH Weiss,

Could you please be so kind to file ISF per the documentation attached.


					//handles conversion of values between 1000-9999
					if (paymentInt <= 9999 && paymentInt >= 1000) //deals with 4 digits
					{
						if (count != 2) //if count == 2, that means we are in the tens place
							findDigitName();
						else if (paymentChar[count] == '1')  //since we are now in the tens place, we are testing if the first value is '1'
						{
							testTens = true;  //if the value is 1, we assign the last two digits their name (11-19)
							findTensName();
							count = (int)strlen(paymentChar);  //sets count to the length of the C-String, ending the loop
						}
						else
							findTensName();



						if (paymentChar[count] != '0')
						{
							if (count == 0)
								convertedNumber.append(" thousand ");
							else if (count == 1)
								convertedNumber.append(" hundred ");
							else
								convertedNumber.append(" ");
						}
					}

					//handles conversion of values between 100-999
					else if (paymentInt <= 999 && paymentInt >= 100) //deals with numbers with 3 digits
					{
						if (count != 1) //deals with numbers not in the tens place
							findDigitName();
						else if (paymentChar[count] == '1') //likewise with the 1000s conversion, this will deal with digits 10-19
						{
							testTens = true;
							findTensName();
							count = (int)strlen(paymentChar);
						}
						else
							findTensName();


						if (paymentChar[count] != '0')
						{
							if (count == 0)
								convertedNumber.append(" hundred ");
							else
								convertedNumber.append(" ");
						}
					}

					//handles conversion of values between 20-99
					else if (paymentInt <= 99 && paymentInt >= 20)
					{
						if (count != 0)
							findDigitName();
						else if (paymentChar[count] == '1')
						{
							testTens = true;
							findTensName();
							count = (int)strlen(paymentChar);
						}
						else
							findTensName();

						if (paymentChar[count] != '0')
							convertedNumber.append(" ");
					}
				}
			} //End of the conversion

		}
	}
}