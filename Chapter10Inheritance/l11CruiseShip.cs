using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Inheritance
{
    internal class l11CruiseShip: l10Ship
    {

        public int MaxNumberOfPassengers { get; set; }

        public l11CruiseShip(int maxNumberOfPassengers, string ShipName, string YearBuilt): base(ShipName, YearBuilt) 
        {
            MaxNumberOfPassengers = maxNumberOfPassengers;
        }

        
    public override String toString()   
        {
            return "The ship's name is " + ShipName + "." + " The maximum number of passengers is: "
                    + MaxNumberOfPassengers + ".";
        }

        public static void Run()
        {
            l11CruiseShip cruiseShip = new l11CruiseShip(500, "Vera","1991");
            Console.WriteLine(cruiseShip.toString());
        }
    }
}
