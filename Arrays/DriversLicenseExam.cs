using System;
using System.Linq; // for advance work with data

namespace Arrays
{
    class DriversLicenseExam
    {
        public static void Run()
        {
            char[] correctAnswersArr = new char[] { 'B', 'D', 'A', 'A', 'C' };
            char[] studentsAnswersArr = new char[5];



            //for (int i = 0; i < studentsAnswersArr.Length; i++)
            //{
            //    Console.WriteLine("Enter students answers (A, B, C or D): ");
            //    string studentsAnswer = Console.ReadLine().ToUpper();
            //    studentsAnswersArr[i] = Convert.ToChar(studentsAnswer);
            //}

             PassedWithLinq(correctAnswersArr, new char[] { 'B', 'B', 'A', 'A', 'C' });

       

            //Console.WriteLine(Passed(correctAnswersArr, studentsAnswersArr));
            //Console.WriteLine("The total of correct answers is: " + TotalCorrect(correctAnswersArr, studentsAnswersArr));
            //Console.WriteLine("The total of incorrect answers is: " + TotalIncorrect(correctAnswersArr, studentsAnswersArr));
            //Console.WriteLine("The amount of missed questions is: " + QuestionMissed(correctAnswersArr, studentsAnswersArr));

        }



        public static bool PassedWithLinq(char[] cArr, char[] sArr)
        {
            // return cArr.Intersect(sArr).Count() == 4 ? true : false;

            return cArr.Count(x => sArr.Contains(x)) == 4 ? true : false; 
        }



        public static bool Passed(char[] corrAnswers, char[] studAnsw)
        {
            bool results = false;
            int counter = 0;

            for (int i = 0; i < corrAnswers.Length; i++)
            {

                if (corrAnswers[i] == studAnsw[i])
                {
                    results = true;
                    counter++;
                    if (counter == 4)
                        break;
                }
                else
                {
                    results = false;
                }
            }
            return results;
        }

        public static int TotalCorrect(char[] correctAnsw, char[] studAnswers)
        {
            int numCorrect = 0;

            for (int i = 0; i < correctAnsw.Length; i++)
                if (correctAnsw[i] == studAnswers[i])
                    numCorrect++;

            return numCorrect;
        }
        private static int TotalIncorrect(char[] correctAnsw, char[] studAnswers)
        {
            int numIncorrect = 0;

            for (int i = 0; i < correctAnsw.Length; i++)
                if (correctAnsw[i] != studAnswers[i])
                    numIncorrect++;


            return numIncorrect;
        }

        private static int QuestionMissed(char[] correctAnsw, char[] studAnswers)
        {
            int[] missedQuestions = new int[correctAnsw.Length];

            for (int i = 0; i < correctAnsw.Length; i++)
                if (correctAnsw[i] != studAnswers[i])
                    missedQuestions[i] = (i + 1);

            return missedQuestions.Length;
        }

    }
}
