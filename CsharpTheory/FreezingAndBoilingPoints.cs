using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class FreezingAndBoilingPoints
    {
        public static void run()
        {
            double temperature = 15;
            FreezingAndBoilingPoints f = new FreezingAndBoilingPoints(temperature);

            //Display elements will freeze.
            if (f.IsEthylBoiling())
            {
                Console.WriteLine("Ethyl alcohol will freeze.");
            }

            if (f.IsOxygenFreezing())
            {
                Console.WriteLine("Oxygen will freeze.");
            }

            if (f.IsWaterFreezing())
                Console.WriteLine("Water will freeze.");

            // Display if elements will boil.
            if (f.IsEthylFreezing())
            {
                Console.WriteLine("Ethyl alcohol will boil.");
            }

            if (f.IsOxygenBoiling())
            {
                Console.WriteLine("Oxygen will boil.");
            }

            if (f.IsWaterBoiling())
            {
                Console.WriteLine("Water will boil.");
            }
        }
        private double temperature;

        public FreezingAndBoilingPoints(double temperature)
        {

            this.temperature = temperature;
        }

        public void SetTepmerature(double temperature)
        {
            this.temperature = temperature;
        }

        public double GetTemperature()
        {
            return temperature;
        }

        public bool IsEthylFreezing()
        {

            if (temperature <= -173.0)
            {
                return true;
            }
            else
                return false;

        }

        public bool IsEthylBoiling()
        {

            if (temperature >= 172.0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsOxygenFreezing()
        {

            if (temperature <= -362.0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsOxygenBoiling()
        {

            if (temperature >= -306.0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsWaterFreezing()
        {

            if (temperature <= 32.0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsWaterBoiling()
        {

            if (temperature >= 212.0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
