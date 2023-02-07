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

        public l8PreferredCustomerClass(string name, string address, string telephone, int customerNumber, bool onMailingList, double spending) : base(name, address, telephone, customerNumber, onMailingList)
        {
            this.PurchaseAmount= spending;
        }

        public string GetDiscount()
        {
            double discount = 0;

            if(PurchaseAmount >= 500 && PurchaseAmount < 1000)
            {
                discount = PurchaseAmount * FivePercent;
            }else if(PurchaseAmount >= 1000 && PurchaseAmount < 1500)
            {
                discount= PurchaseAmount * SixPercent;
            }
            else if (PurchaseAmount >= 1500 && PurchaseAmount < 2000)
            {
                discount= PurchaseAmount * SevenPercent;
            }
            else if (PurchaseAmount >= 2000) {
            PurchaseAmount= PurchaseAmount * TenPercent;
            }

            return discount.ToString("0.###");
        }

        public static void Run()
        {
            l8PreferredCustomerClass pc = new l8PreferredCustomerClass("Nata", "123 Main St.", "343-464-4543", 122112, false, 1100);

            Console.WriteLine("Customer info: " + "\n" + "Name: " + pc.Name + "\n" + "Adress: " + pc.Address + "\n" + "Phone Number: " + pc.Telephone + "\n" + "Customer Number: " + pc.customerNumber + "\n" + pc.onMailingList);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Preferred customer" + "\nPurchase amount: $" + pc.PurchaseAmount + "\nDiscount: $" + pc.GetDiscount());
        }
    }
}
