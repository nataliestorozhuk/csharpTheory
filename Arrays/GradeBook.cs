using System;

namespace Arrays
{
    class GradeBook
    {

        public static void Run()
        {
            string[] studentsNames = new string[5];
            char[] gradeCharacters = new char[] { 'A', 'B', 'C', 'D', 'F' };
            double[] student1 = new double[4];
            double[] student2 = new double[4];
            double[] student3 = new double[4];
            double[] student4 = new double[4];
            double[] student5 = new double[4];


            for (int i = 0; i < studentsNames.Length; i++)
            {
                Console.WriteLine("Enter students name (A, B, C or D): ");
                string studentsAnswer = Console.ReadLine().ToUpper();

            }
        }

        public static string[] GetStudentName()
        {
            string[] studentsNames = new string[5];
            for (int i = 0; i < studentsNames.Length; i++)
            {
                Console.WriteLine($"Enter student name: {i}");
                studentsNames[i] = Console.ReadLine().ToUpper();
            }
            return studentsNames;
        }
    }
}
