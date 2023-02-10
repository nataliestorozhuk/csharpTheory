using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class DemoOfShipClass
    {
        public static void Run()
        {
            //Create a Ship array.
            l10Ship[] shipsArray = new l10Ship[3];

            shipsArray[0] = new l10Ship("Aetna", "1990");
            shipsArray[1] = new l11CruiseShip(500, "Aetna", "1989");
            shipsArray[2] = new l12CargoShip(10000, "Oskar", "2002");


            //Print out the array.
            for (int i = 0; i < shipsArray.Length; i++)
            {
                Console.WriteLine(shipsArray[i].toString());
            }


        }
    }
}
