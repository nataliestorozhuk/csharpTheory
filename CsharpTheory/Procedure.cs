using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class Procedure
    {
        public string ProcedureName { get; set; }
        public string ProcedureDate { get; set; }
        public string PractitionerName { get; set; }
        public double ProcedureCharges { get; set; }

        public Procedure(string procedureName, string procedureDate, string practitionerName, double procedureCharges)
        {
            ProcedureName = procedureName;
            ProcedureDate = procedureDate;
            PractitionerName = practitionerName;
            ProcedureCharges = procedureCharges;
        }
    }

}
