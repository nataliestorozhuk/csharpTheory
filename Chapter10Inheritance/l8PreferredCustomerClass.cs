using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l8PreferredCustomerClass: Customer
    {
        public static readonly double FivePercent = 0.05;
        public static readonly double SixPercent = 0.06;
        public static readonly double SevenPercent = 0.07;
        public static readonly double TenPercent = 0.10;


        public double PurchaseAmount { get; set; }

        public l8PreferredCustomerClass(string name, string address, string telephone, int customerNumber, bool onMailingList) : base(name, address, telephone, customerNumber, onMailingList)
        {
        }

        public static void Run()
        {
              

        }
    }
}
