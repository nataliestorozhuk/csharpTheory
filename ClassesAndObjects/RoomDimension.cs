using System;

namespace ClassesAndObjects
{
    class RoomDimension
    {

        public static void Run()
        {
            double lenght = 15.5;
            double widht = 12.3;
            double pricePerSquareFoot = 3.50;

            RoomDimension rd = new RoomDimension(lenght, widht);
            RoomCarpet roomCarpet = new RoomCarpet(rd, pricePerSquareFoot);

            Console.WriteLine(rd);
            Console.WriteLine(roomCarpet);


        }
        public double Lenght { get; set; }
        public double Width { get; set; }

        public RoomDimension(double lenght, double width)
        {
            this.Lenght = lenght;
            this.Width = width;
        }

        public double GetRoomArea()
        {
            return Lenght * Width;
        }

        public override string ToString()
        {
            return $"Dimension of the room are: (length = {Lenght}, width = {Width}).";
        }
    }

    class RoomCarpet
    {
        private RoomDimension size;
        public double CarpetCost { get; set; }

        public RoomCarpet(RoomDimension size, double carpetCost)
        {
            this.size = size;
            this.CarpetCost = carpetCost;

        }

        public double GetTotalCost()
        {
            return CarpetCost * size.GetRoomArea();
        }

        public override string ToString()
        {
            return $"Carpet cost per square feet = ${CarpetCost}.\nTotal cost = ${GetTotalCost()}.";
        }
    }
}
