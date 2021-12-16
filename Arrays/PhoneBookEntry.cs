using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class PhoneBookEntry
    {
        public static void Run()
        {

        }
        public string PersonsName { get; set; }
        public string PhoneNum { get; set; }

        public PhoneBookEntry(string personsName, string phoneNum)
        {
            PersonsName = personsName;
            PhoneNum = phoneNum;
        }
    }
}
