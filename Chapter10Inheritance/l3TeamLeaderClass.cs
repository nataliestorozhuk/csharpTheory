using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter10Inheritance
{
    internal class l3TeamLeaderClass: l1EmployeeAndProductionWorker
    {

        public double MonthlyBonus { get; set; }
        public int ReqTrainingHours { get; set; }
        public int TrainingHoursAttended { get; set; }


        //public l3TeamLeaderClass(double monthlyBonus, int reqTrainingHours, int trainingHoursAttended)
        //{
        //    MonthlyBonus = monthlyBonus;
        //    ReqTrainingHours = reqTrainingHours;
        //    TrainingHoursAttended = trainingHoursAttended;
        //}

        public l3TeamLeaderClass(string EmpName, string EmpNumber, string HireDate, double monthlyBonus, int reqTrainingHours, int trainingHoursAttended): base(EmpName, EmpNumber, HireDate) 
            {
            MonthlyBonus = monthlyBonus;
            ReqTrainingHours = reqTrainingHours;
            TrainingHoursAttended = trainingHoursAttended;
        }

    public static void Run()
    {
        l3TeamLeaderClass obj = new l3TeamLeaderClass("Nata", "123-AC", "01-01-1978", 127.25, 40, 38);

            Console.WriteLine(obj.EmployeeName);
            Console.WriteLine(obj.EmployeeNumber);
            Console.WriteLine(obj.HireDate);
            Console.WriteLine(obj.MonthlyBonus);
            Console.WriteLine(obj.ReqTrainingHours);
            Console.WriteLine(obj.TrainingHoursAttended);
        }
    }
}
