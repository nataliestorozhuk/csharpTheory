using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8_ClassesAndObjects
{
    class SalesReceiptFile
    {
        public static void Run()
        {
            int quantity = 5;

            RetailItem item = new RetailItem("Jacket", 12, 59.95);
            CashRegister cashRegister = new CashRegister(item, quantity);

            string[] line =
            {
                "SALES RECEIPT",
                $"Unit price: ${item.Price}",
                $"Quantity: {quantity}",
                $"Subtotal: ${cashRegister.GetSubtotal()}",
                $"Sales tax: ${cashRegister.GetTax()}",
                $"Total: ${cashRegister.GetTotal()}"
            };

            File.WriteAllLines("sample.txt", line);

            Console.WriteLine("Data written successfully");


        }

    }
}

