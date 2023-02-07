using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l7PersonAndCustomerClasses
    {


        public string name { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }

        public l7PersonAndCustomerClasses(string name, string address, string telephone)
        {
            this.name = name;
            this.address = address;
            this.telephone = telephone;
        }



        public static void Run()
        {
            Customer customer = new Customer("John Doe", "123 Main St", "555-555-5555", 123456, true);

            Console.WriteLine("Customer Name: " + customer.name);
            Console.WriteLine("Address: " + customer.address);
            Console.WriteLine("Telephone: " + customer.telephone);
            Console.WriteLine("Customer Number: " + customer.customerNumber);
            Console.WriteLine("On Mailing List: " + customer.onMailingList);

            Console.ReadLine();


        }

            }

    class Customer : l7PersonAndCustomerClasses
    {

        public Customer(string name, string address, string telephone, int customerNumber, bool onMailingList) : base(name, address, telephone)
        {
            this.customerNumber = customerNumber;
            this.onMailingList = onMailingList;
        }

        public int customerNumber { get; set; }
        public bool onMailingList { get; set; }


    }
}
