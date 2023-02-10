using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l10Ship
    {
        public string ShipName { get; set; }
        public string YearBuilt { get; set; }

        public l10Ship(string shipName, string yearBuilt)
        {
            ShipName = shipName;
            YearBuilt = yearBuilt;
        }

        public virtual String toString()
        {
            return "The ship name is " + ShipName + "." + " The year that the ship was built is: " + YearBuilt;
        }
    public static void Run()
    {

            l10Ship ship = new l10Ship("Vera", "1991");

            Console.WriteLine(ship.toString());
    }
    }

}
