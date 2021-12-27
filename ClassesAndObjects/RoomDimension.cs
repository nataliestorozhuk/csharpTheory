using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class RoomDimension
    {
        private double lenght;
        private double width;

        public RoomDimension(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public static double GetRoomArea(double l, double w)
        {
            return l * w;
        }
    }

    class RoomCarpet
    {
        private RoomDimension size;
        private double carpetCost;


    }
}
