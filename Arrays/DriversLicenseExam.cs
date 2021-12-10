using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DriversLicenseExam
    {
        public static void Run() {

          
        }

        char[] correctAnswers = new char[] { 'B', 'D', 'A', 'A', 'C' };
        char[]  studentsAnswers = new char[5];

        //public static bool Passed(char[] studAnsw)
        //{

        //    return;
        //}
        private static int totalCorrect(char[] correctAnsw, char[] studAnswers)
        {
            int numCorrect = 0;

            for (int i = 0; i < correctAnsw.Length; i++)
                if (correctAnsw[i] == studAnswers[i])
                    numCorrect++;

            return numCorrect;
        }

    }
}
