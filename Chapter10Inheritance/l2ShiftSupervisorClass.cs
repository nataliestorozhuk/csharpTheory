using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l2ShiftSupervisorClass: l1EmployeeAndProductionWorker
    {

        public double AnnualSalary { get; set; }
        public double ProductionBonus { get; set; }


        public l2ShiftSupervisorClass(double annualSalary, double productionBonus)
        {
            AnnualSalary = annualSalary;
            ProductionBonus = productionBonus;
        }

        public  l2ShiftSupervisorClass(string empName, string empNumber, string hireDate, double annualSalary, double productionBonus) : base(empName, empNumber, hireDate) {

            if(productionBonus <= 0)
            {
                Console.WriteLine("Error: bonus cannot be negative or $0.");
            }
            else
            {
                AnnualSalary= annualSalary;
            }
            AnnualSalary = annualSalary;
            ProductionBonus = productionBonus;
        }

        public static void Run() {

            l2ShiftSupervisorClass s = new l2ShiftSupervisorClass("Nata", "123-AC", "01/01/2020", 75000, 500);

            Console.WriteLine("Employee name: " + s.EmployeeName);
            Console.WriteLine("Employee number: " + s.EmployeeNumber);
            Console.WriteLine("Hire date: " + s.HireDate);
            Console.WriteLine("Employee's annual salary: " + s.AnnualSalary);
            Console.WriteLine("Employee's production bonus: " + s.ProductionBonus);

        }
    }

    
}
