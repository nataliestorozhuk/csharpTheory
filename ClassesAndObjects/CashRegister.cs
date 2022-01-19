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





        public CashRegister(RetailItem retail, int quantity)
        {
            this.retail = retail;
            Quantity = quantity;
        }

        public double GetSubtotal()
        {
            return Quantity * retail.getPrice();
        }
        public double GetTax()
        {
            return GetSubtotal() * 0.06;
        }
        public double GetTotal()
        {
            return GetSubtotal() + GetTax();


        }
    }

    public class RetailItem
    {

        public static void Run()
        {
            RetailItem item1 = new RetailItem("Jacket", 12, 59.95);
            RetailItem item2 = new RetailItem("Designer Jeans", 40, 34.95);
            RetailItem item3 = new RetailItem("Shirt", 20, 24.95);

            Console.WriteLine("              Description        Units on Hand          Price");
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Item #1" + "\t\t" + item1.getDescription() + "\t\t" + item1.getunitsOnHand() + "\t\t\t"
                    + item1.getPrice());
            Console.WriteLine("Item #2" + "\t\t" + item2.getDescription() + "\t" + item2.getunitsOnHand() + "\t\t\t"
                    + item2.getPrice());
            Console.WriteLine("Item #3" + "\t\t" + item3.getDescription() + "\t\t" + item3.getunitsOnHand() + "\t\t\t"
                    + item3.getPrice());
        }

        private String description;
        private int unitsOnHand;
        private double price;

        public RetailItem(String description, int unitsOnHand, double price)
        {
            this.description = description;
            this.unitsOnHand = unitsOnHand;
            this.price = price;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public void setunitsOnHand(int unitsOnHand)
        {
            this.unitsOnHand = unitsOnHand;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public String getDescription()
        {
            return description;
        }

        public int getunitsOnHand()
        {
            return unitsOnHand;
        }

        public double getPrice()
        {
            return price;
        }
    }
}

