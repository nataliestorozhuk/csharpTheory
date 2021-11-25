using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class Patient
    {
        public static void Run()
        {
            double totalCharges;

            Patient patient = new Patient("Nata", "no middle name", "Stor", "12 Beyer ave.", "Phila", "PA", "19116", "Nick", "609-849-1648");
            Procedure procedure1 = new Procedure("Exam", "November 25th 2021", "Dr. Irvine", 250.00);
            Procedure procedure2 = new Procedure("X-ray", "November 25th 2021", "Dr. Jamison", 500.00);
            Procedure procedure3 = new Procedure("Blood test", "November 25th 2021", "Dr. Smith", 200.00);

            Console.WriteLine("First name: " + patient.FirstName + "\n" + "Middle name: " + patient.MiddleName + "\n" + "Last name " + patient.LastName + "\n" + 
               "Patient's address: " + patient.Address + ", " + patient.City + ", " + patient.State + ", " + patient.ZipCode + "\n" + 
                "Emergency contact name: " + patient.EmergencyName + "\n" + "Emergency contact phone number: " + patient.EmergencyPhoneNumber);
            Console.WriteLine("");
            Console.WriteLine("Procedure #1: " + "\t\t\t" + "Procedure #2: " + "\t\t\t" + "Procedure #3: ");
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("Procedure name:" + procedure1.ProcedureName + "\t\t" + "Procedure name:" + procedure2.ProcedureName + 
                "\t\t" + "Procedure name:" + procedure3.ProcedureName);
            Console.WriteLine("Date:" + procedure1.ProcedureDate + "\t\t" + "Date:" + procedure2.ProcedureDate +
               "\t\t" + "Date:" + procedure3.ProcedureDate);
            Console.WriteLine("Practitioner:" + procedure1.PractitionerName + "\t\t" + "Practitioner:" + procedure2.PractitionerName +
               "\t\t" + "Practitioner:" + procedure3.PractitionerName);
            Console.WriteLine("Charge:" + procedure1.ProcedureCharges + "\t\t\t" + "Charge:" + procedure2.ProcedureCharges +
               "\t\t\t" + "Charge:" + procedure3.ProcedureCharges);
            Console.WriteLine("");
            Console.WriteLine("Total charges are: " + (procedure1.ProcedureCharges + procedure2.ProcedureCharges + procedure3.ProcedureCharges));
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhoneNumber { get; set; }

        public Patient(string firstName, string middleName, string lastName, string address, 
                            string city, string state, string zipCode, string emergencyName, string emergencyPhoneNumber)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            EmergencyName = emergencyName;
            EmergencyPhoneNumber = emergencyPhoneNumber;
        }

 



    }
}
