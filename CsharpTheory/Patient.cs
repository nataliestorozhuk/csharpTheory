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
            Patient patient = new Patient("Nata", "no middle name", "Stor", "12 Beyer ave.", "Phila", "PA", "19116", "Nick", "609-849-1648");
            Procedure procedure1 = new Procedure("Exam", "November 25th 2021", "Dr. Irvine", 250.00);
            Procedure procedure2 = new Procedure("E-ray", "November 25th 2021", "Dr. Jamison", 500.00);
            Procedure procedure3 = new Procedure("Blood test", "November 25th 2021", "Dr. Smith", 200.00);

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
