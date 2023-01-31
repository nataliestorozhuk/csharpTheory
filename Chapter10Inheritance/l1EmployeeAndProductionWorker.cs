using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l1EmployeeAndProductionWorker
    {

        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string HireDate { get; set; }


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

        private class ProductionWorker: l1EmployeeAndProductionWorker
       {
            public int Shift { get; set; }
            public double HourlyPayRate { get; set; }



        }
    }
}
