using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    internal class l10PersonAndCustomerClasses
    {
        
        public string name { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }

        public l10PersonAndCustomerClasses(string name, string address, string telephone)
        {
            this.name = name;
            this.address = address;
            this.telephone = telephone;
        }



        public static void Run()
        {

        }




    }

    class Customer: l10PersonAndCustomerClasses
    {

        public Customer(string name, string address, string telephone, int customerNumber, bool onMailingList) : base(name, address, telephone)
        {
            this.customerNumber = customerNumber;
            this.onMailingList = onMailingList;
        }


        private int customerNumber;
        private bool onMailingList;
    }
}