using System;
using System.Collections.Generic;

namespace Arrays
{
    class GradeBook
    {
        public static void Run()
        {

            Student[] studentsArr = 
            { 
                new Student("Nata", new double[] { 94, 87, 95.5, 67 }),
                new Student("Kolya", new double[] { 84, 87, 95.5, 67 }),
                new Student("Sasha", new double[] { 78, 87, 83.1, 71 }),
                new Student("Sofa", new double[] { 56, 87, 82, 79 })
            };

            List<Student> studentsList = new List<Student>()
            {
                new Student("Nata", new double[] { 94, 87, 95.5, 67 }),
                new Student("Kolya", new double[] { 84, 87, 95.5, 67 }),
                new Student("Sasha", new double[] { 78, 87, 83.1, 71 }),
                new Student("Sofa", new double[] { 56, 87, 82, 79 })
            };




            //foreach (Student student in studentsArr)
            //{
            //    Console.WriteLine($"Student name: {student.Name}");
            //    Console.WriteLine($"Test average is: {student.Average}");
            //    Console.WriteLine($"Letter grade based on the average is: {student.LetterGrade}");
            //    Console.WriteLine("-----------------------");
            //}

            foreach (Student student in studentsArr)
            {
                var (name, avg, letter) = student.GetAllData();
                
                Console.WriteLine($"Student name: {name}");
                Console.WriteLine($"Test average is: {avg}");
                Console.WriteLine($"Letter grade based on the average is: {letter}");
                Console.WriteLine("-----------------------");
            }


            //for (int i = 0; i < studentsArr.Length; i++)
            //{
            //    //Student s  = students[i]; /// option 2

            //    Console.WriteLine($"Student name: {studentsArr[i].Name}");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine($"Test average is: {studentsArr[i].Average}");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine($"Letter grade based on the average is: {studentsArr[i].LetterGrade}");
            //}

        }
    }





}

