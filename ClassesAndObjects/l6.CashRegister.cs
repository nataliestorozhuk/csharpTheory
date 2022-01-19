using System;

namespace Chapter8_ClassesAndObjects
{
    class CashRegister
    {

        public static void Run()
        {
            int quantity = 5;

            RetailItem item = new RetailItem("Jacket", 12, 59.95);
            CashRegister cashRegister = new CashRegister(item, quantity);

            Console.WriteLine($"The sale's subtotal is: $ {cashRegister.GetSubtotal()}");
            Console.WriteLine($"The amount of sales tax is: $ {cashRegister.GetTax()}");
            Console.WriteLine($"The total is: $ {cashRegister.GetTotal()}");

        }

        public int Quantity { get; set; }
        RetailItem retail;
        const double TAX = 0.06;

        public CashRegister(RetailItem retail, int quantity)
        {
            this.retail = retail;
            Quantity = quantity;
        }

        public double GetSubtotal()
        {
            return Quantity * retail.Price;
        }
        public double GetTax()
        {
            return GetSubtotal() * TAX;
        }
        public double GetTotal()
        {
            return GetSubtotal() + GetTax();


        }
    }

    public class RetailItem
    {

        public String Description { get; set; }
        public int UnitsOnHand { get; set; }
        public double Price { get; set; }

        public RetailItem(string description, int unitsOnHand, double price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

    }
}

