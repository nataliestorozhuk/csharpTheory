namespace ClassesAndObjects
{
    class TheParkedCar
    {
        // Demo of the program
        public static void Run()
        {

            TheParkedCar car = new TheParkedCar("Nissan", "Murano", "White", "AVN1547",30);

            TheParkingMeter meter = new TheParkingMeter(15);

            ThePoliceOfficer officer = new ThePoliceOfficer("Mike Smith", "546464fsf");

            if (officer.IsIllegallyParked(car, meter))
            {

                TheParkingTicket ticket = officer.GenerateTicket(car, meter);
                System.Console.WriteLine("Ticket generated.");
                System.Console.WriteLine(ticket);
            }
            else
            {
                System.Console.WriteLine("No ticket.");
            }


        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string LicenceNumber { get; set; }
        public double NumberOfMinutesCarParked { get; set; }

        // No-arg. constructor.
        public TheParkedCar() { }

        // Constructor.
        public TheParkedCar(string make, string model, string color, string licenceNumber, double numberOfMinutesCarParked)
        {
            Make = make;
            Model = model;
            Color = color;
            LicenceNumber = licenceNumber;
            NumberOfMinutesCarParked = numberOfMinutesCarParked;
        }
    }

    // TheParkingMeter class.
    class TheParkingMeter
    {
        public int ParkingTime { get; set; }

        public TheParkingMeter(int parkingTime)
        {
            ParkingTime = parkingTime;
        }
    }

    // TheParkingTicket class
    class TheParkingTicket
    {
        private TheParkedCar Car;
        //private TheParkingMeter Meter;
        private ThePoliceOfficer Officer;
        public double Fine { get; set; }

        public TheParkingTicket(TheParkedCar car, ThePoliceOfficer officer)
        {
            this.Car = car;
            this.Officer = officer;
        }

        public override string ToString()
        {
            return $"\nCar Maker: {Car.Make}" +
                $"\nCar Model: {Car.Model}" +
                $"\nCar Color: {Car.Color}" +
                $"\nCar License Number:" +
                $" {Car.LicenceNumber}" +
                $"\nFine: ${Fine}" +
                $"\nOfficer Name: {Officer.PoliceOfficerName}" +
                $"\nOfficer Badge#: {Officer.BadgeNumber}";
        }
    }

    // ThePoliceOfficer class
    class ThePoliceOfficer
    {
        public string PoliceOfficerName { get; set; }
        public string BadgeNumber { get; set; }

        public ThePoliceOfficer(string policeOfficerName, string badgeNumber)
        {
            PoliceOfficerName = policeOfficerName;
            BadgeNumber = badgeNumber;
        }

        // IsIllegallyParked method determines if a car parked illegally.
        public bool IsIllegallyParked(TheParkedCar car, TheParkingMeter meter)
        {

            return car.NumberOfMinutesCarParked > meter.ParkingTime;
        }

        // TheParkingTicket method generates a ticked if a car parked more time then it was paid.
        public TheParkingTicket GenerateTicket(TheParkedCar car, TheParkingMeter meter)
        {
            TheParkingTicket ticket = new TheParkingTicket(car, this);
            double remainder = car.NumberOfMinutesCarParked - meter.ParkingTime;

            if (IsIllegallyParked(car, meter))
            {
                if (remainder <= 60)
                {
                    ticket.Fine = 25;
                }
                else
                {
                    ticket.Fine = 25 + (10 * (remainder / 60));
                }
            }
            return ticket;
        }
    }
}
