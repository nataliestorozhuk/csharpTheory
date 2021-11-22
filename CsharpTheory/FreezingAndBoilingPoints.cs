using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTheory
{
    class FreezingAndBoilingPoints
    {
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
