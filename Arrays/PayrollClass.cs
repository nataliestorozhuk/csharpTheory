namespace Arrays
{
    class PayrollClass
    {
        private int[] employeeId = { 5658845, 4520125, 7895122, 8777541, 8451277, 1302850, 7580489 };
        private int[] hours = new int[7];
        private double[] payRate = new double[7];
        private double[] wages = new double[7];

      

        public int[] EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public int[] Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public double[] PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
        public double[] Wages
        {
            get { return wages; }
            set { wages = value; }
        }

        public double GetGrossPay(int employeeId)
        {

            return 1;
        }
    }
}
