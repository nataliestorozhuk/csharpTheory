namespace Arrays
{
    class ChargeAccountValidation
    {
        public int SequantialSearch(int[] array, int value)
        {
            int index = 0;          //Loop control variable.
            int element = -1;      //Element the value is found at.
            bool found = false;   //Flag indicating search result.

            //Search the array.
            while (!found && index < array.Length)
            {
                if (array[index] == value)
                {
                    found = true;
                    element = index;
                }
                index++;
            }


            return element;
        }
    }
}
