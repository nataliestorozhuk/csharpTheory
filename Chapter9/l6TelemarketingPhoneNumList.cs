using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class l6TelemarketingPhoneNumList
    {

        public static void Run()
        {

            String[] names = { "Harrison, Rose", "James, Jean", "Smith, William", "Smith, Brad" };
            String[] phoneNum = { "555-2234", "555-9098", "555-1785", "555-9224" };

            String[] result = Array.FindAll(names, e => e.ToLower().StartsWith("smi"));

            foreach(String n in result)
            {
                var x = Array.IndexOf(names, n);
                var y = phoneNum[x];

                Console.WriteLine(n + "    " + y);
            }


        }

    }
}
