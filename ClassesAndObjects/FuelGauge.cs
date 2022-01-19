using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class FuelGauge
    {
        public static void Run()
        {
            FuelGauge fuel = new FuelGauge();
            Odometer odometer = new Odometer(0, fuel);

            //for (int i = 0; i < FuelGauge.; i++)
            //{
            //    fuel.AddGallons();
            //}

            // dive until you can't drive no longer.
            while (fuel.AmountOfFuel > 0)
            {

                // add mile driven
                odometer.AddMileage();

                // Display the mileage.
                Console.WriteLine("Mileage: " + odometer.Mileage);

                // Display the amount of fuel.
                Console.WriteLine("Fuel level: " + fuel.AmountOfFuel + " gallons");
                Console.WriteLine("------------------------------");
            }

        }

        public readonly int MAXIMUM_GALLONS = 15;
        public int AmountOfFuel { get; set; }

        public FuelGauge()
        {
            AmountOfFuel = 0;
        }

        public FuelGauge(int amountOfFuel)
        {
            if (amountOfFuel <= MAXIMUM_GALLONS)
            {
                AmountOfFuel = amountOfFuel;
            }
            else
            {
                amountOfFuel = MAXIMUM_GALLONS;
            }
        }

        public void AddGallons()
        {
            if(AmountOfFuel < MAXIMUM_GALLONS)
            {
                AmountOfFuel++;
            }
            else
            {
                Console.WriteLine("OVERFLOWING!!!!");
            }
        }

        public void BurnFuel()
        {
            if (AmountOfFuel < 0)
            {
                AmountOfFuel--;
            }
            else
            {
                Console.WriteLine("YOU ARE OUT OF FUEL!");
            }
        }
    }
    class Odometer
    {
        public readonly int MAXIMUM_MILEAGE = 999999;
        public readonly int MPG = 24;
        public int Mileage { get; set; }
        public int CurrentMilage { get; set; }

        // Field to reference a FuelGauge object
        private FuelGauge FuelGauge;

        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            Mileage = mileage;
            this.CurrentMilage = mileage;
            FuelGauge = fuelGauge;
        }

        public void AddMileage()
        {

            if (Mileage < MAXIMUM_MILEAGE)
            {
                Mileage++;
            }
            else
            {
                Mileage = 0;
            }


            int driven = CurrentMilage - Mileage;
            if (driven % MPG == 0)
            {
                FuelGauge.BurnFuel();
            }
        }
    }
}
