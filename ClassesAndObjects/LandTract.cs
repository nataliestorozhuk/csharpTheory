namespace ClassesAndObjects
{
    class LandTract
    {
        public static void Run()
        {
            LandTract landTract1 = new LandTract(7.5, 7.5);
            LandTract landTract2 = new LandTract(5.5, 7.5);

            if (landTract1.Equals(landTract2))
                System.Console.WriteLine("Both objects are the same");

            else
                System.Console.WriteLine("The objects are different");
            System.Console.WriteLine();
            System.Console.WriteLine($"Dimensions of the first object are: {landTract1}");
            System.Console.WriteLine($"Dimensions of the second object are: {landTract2}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Area of the firs object is: {landTract1.GetArea()}");
            System.Console.WriteLine($"Area of the second object is: {landTract2.GetArea()}");



        }
        public double TractsLength { get; set; }
        public double TractsWidth { get; set; }

        public LandTract(double tractsLength, double tractsWidth)
        {
            TractsLength = tractsLength;
            TractsWidth = tractsWidth;
        }

        public double GetArea()
        {
            return TractsLength * TractsWidth;
        }

        public override string ToString()
        {
            return $"length is: {TractsLength}, width is: {TractsWidth}";
        }

        // Equals methods that compares two object and returns true if they are the same, false otherwise.
        public bool Equals(LandTract object2)
        {
            bool status;

            if (TractsLength.Equals(object2.TractsLength) && TractsWidth.Equals(object2.TractsWidth))
            {
                status = true;
            }

            else
            {
                status = false;
            }
            return status;
        }
    }
}


