namespace CsharpTheory
{
    public class LocalFunc
    {
        //Fields
        public int High, Low;

        public int MyProperty { get; set; }

        public float Average()
        {
            // local function
            // method inside a method

            int IamLocalFunction(int x)
            {
                return 10 + x;
            }

            // local variable
            int lv = 120;
            
            return (High + Low) / 2 + IamLocalFunction(lv);
        }
    }
}
 
 