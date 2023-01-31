using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter10Inheritance
{
    internal class l1EmployeeAndProductionWorker
    {

        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string HireDate { get; set; }


        public l1EmployeeAndProductionWorker(String n, String num, String date)
        {
            EmployeeName = n;
            EmployeeNumber = num;
            HireDate = date;
        }

        public l1EmployeeAndProductionWorker()
        {
            EmployeeName = "";
            EmployeeNumber = "";
            HireDate = "";
        }


        private bool isValidEmpNum(String e)
        {
            bool status = true;

            if (e.Length != 5)
                status = false;
            if (e[3] != '-') return false;

            int numberPart;
            if (!int.TryParse(e.Substring(0, 3), out numberPart)) return false;
            if (numberPart < 100 || numberPart >= 1000) return false;

            char letterPart = e[4];
            if (letterPart < 'A' || letterPart > 'M') return false;


            return status;
        }

        public String toString()
        {
            String str = "Name: " + EmployeeName + "\nEmployee Number: ";

            if (EmployeeNumber == "")
                str += "INVALID EMPLOYEE NUMBER";
            else
                str += EmployeeNumber;
            return
            str += ("\nHire Date: " + HireDate);
        }


        private class ProductionWorker: l1EmployeeAndProductionWorker
       {

            public static  int DAY_SHIFT = 1;
            public static  int NIGHT_SHIFT = 2;
            public int Shift { get; set; }
            public double HourlyPayRate { get; set; }


            public ProductionWorker(String n, String num, String date,
                           int sh, double rate): base(n, num, date)
            {
                
                Shift = sh;
                HourlyPayRate = rate;
            }
            public ProductionWorker(): base()

            {
                Shift = DAY_SHIFT;
                HourlyPayRate = 0.0;
            }
        }


    }
}
