using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l12CargoShip: l10Ship
    {
        public int CargoCapacity { get; set; }

        public l12CargoShip(int cargoCapacity, string ShipName, string YearBuilt) : base(ShipName, YearBuilt)
        {
            CargoCapacity = cargoCapacity;
        }

        public override String toString()
        {
            return "The ship's name is " + ShipName + "." + " The ship's cargo capacity is: "
                    + CargoCapacity + ".";
        }

        public static void Run()
        {
            l12CargoShip cargoShip = new l12CargoShip(10000, "Vera", "1991");
            Console.WriteLine(cargoShip.toString());
        }
    }
}
