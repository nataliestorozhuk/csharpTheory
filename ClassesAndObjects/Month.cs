using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Month
    {
        public static void Run()
        {
            //Month month1 = new Month(11);
            //Console.WriteLine(month1.GetMonthName());

            //Month m1 = new Month(3);
            //Month m2 = new Month(5);
            //Console.WriteLine(m1.GreaterThan(m2));

            Month m1 = new Month(7);
            Month m2 = new Month(5);
            Console.WriteLine(m1.LessThan(m2));

        }

        public int MonthNumber
        { get; set; }
        public string MonthName { get; set; }

        public Month()
        {
            MonthNumber = 1;
        }

        public Month(int monthNumber)
        {
            this.MonthNumber = monthNumber;

            if (monthNumber < 1 && monthNumber > 12)
                this.MonthNumber = monthNumber;
            else
                monthNumber = 1;
        }

        public Month(string monthName)
        {
            if (monthName == "January")
                MonthNumber = 1;
            else if (monthName == "February")
               MonthNumber = 2;
            else if (monthName == "March")
                MonthNumber = 3;
            else if (monthName == "April")
                MonthNumber = 4;
            else if (monthName == "May")
                MonthNumber = 5;
            else if (monthName == "June")
                MonthNumber = 6;
            else if (monthName == "July")
                MonthNumber = 7;
            else if (monthName == "August")
                MonthNumber = 8;
            else if (monthName == "September")
                MonthNumber = 9;
            else if (monthName == "October")
                MonthNumber = 10;
            else if (monthName == "November")
                MonthNumber = 11;
            else if (monthName == "December")
                MonthNumber = 12;


        }
        public string GetMonthName()
        { 
            string monthName ="";

            if (MonthNumber == 1)
                monthName = "January";
            else if (MonthNumber == 2)
                monthName = "February";
            else if (MonthNumber == 3)
                monthName = "March";
            else if (MonthNumber == 4)
                monthName = "April";
            else if (MonthNumber == 5)
                monthName = "May";
            else if (MonthNumber == 6)
                monthName = "June";
            else if (MonthNumber == 7)
                monthName = "July";
            else if (MonthNumber == 8)
                monthName = "August";
            else if (MonthNumber == 9)
                monthName = "September";
            else if (MonthNumber == 10)
                monthName = "October";
            else if (MonthNumber == 11)
                monthName = "November";
            else if (MonthNumber == 2)
                monthName = "December";

            return monthName;

        }

        public override string ToString()
        {
            return $"The month name is: {GetMonthName()}";
        }
        public bool Equals(Month object2)
        {
            return object2.MonthNumber == this.MonthNumber;
        }

        public bool GreaterThan(Month obj)
        {
            return this.MonthNumber > obj.MonthNumber;
        }

        public bool LessThan(Month obj)
        {
            return this.MonthNumber < obj.MonthNumber;
        }
    }
}
