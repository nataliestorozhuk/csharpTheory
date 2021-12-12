namespace Arrays
{
    public class Student
    {
        private double[] tests = new double[4];
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Average { get; set; }
        public char LetterGrade { get; set; }

        public Student(string name, double[] tests)
        {
            Name = name;
            this.tests = tests;
            GetAverage();
            GetLetterGrade();
            GetAllData();
        }

        public double GetAverage()
        {
            double total = 0.0;
            foreach (var test in tests)
            {
                total += test;
            }
            return Average = (total / 4);
        }


        //public double GetAverage(Student s)
        //{
        //    double total = 0.0;
        //    foreach (var test in s.tests)
        //    {
        //        total += test;
        //    }
        //    return Average = (total / 4);
        //}

        public char GetLetterGrade()
        {

            if (Average >= 90.99 && Average <= 100)
                LetterGrade = 'A';
            else if (Average >= 80.99 && Average <= 89.99)
                LetterGrade = 'B';
            else if (Average >= 70.99 && Average <= 79.99)
                LetterGrade = 'C';
            else if (Average >= 60.99 && Average <= 69.99)
                LetterGrade = 'D';
            else if (Average <= 59.99)
                LetterGrade = 'F';
            return LetterGrade;
        }


        public (double, string, char) GetAllData()
        {
            double total = 0.0;
            foreach (var test in tests)
            {
                total += test;
            }
            Average = (total / 4);


            if (Average >= 90.99 && Average <= 100)
                LetterGrade = 'A';
            else if (Average >= 80.99 && Average <= 89.99)
                LetterGrade = 'B';
            else if (Average >= 70.99 && Average <= 79.99)
                LetterGrade = 'C';
            else if (Average >= 60.99 && Average <= 69.99)
                LetterGrade = 'D';
            else if (Average <= 59.99)
                LetterGrade = 'F';

            return (Average, Name, LetterGrade);
        }

    }


}
