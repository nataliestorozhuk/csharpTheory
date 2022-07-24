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

            String[] name = { "Harrison, Rose", "James, Jean", "Smith, William", "Smith, Brad" };
            String[] phoneNum = { "555-2234", "555-9098", "555-1785", "555-9224" };

            String nameEntered = "Smith";

            for (int i = 0; i < name.Length; i++)
            {
if (name[i] == nameEntered)
                {
                    Console.WriteLine();
                }
                for (int j = 0; j < phoneNum.Length; j++)
                {
                    if( name[i]== 0)
                    {
                        Console.WriteLine(phoneNum[j]);
                    }
                }
            }

        }





        //List<PhoneNumberList> phones = new List<PhoneNumberList>()
        //    {

        //        new PhoneNumberList("Harrison", "Rose", "555-2234"),
        //        new PhoneNumberList("James","Jean", "555-9098"),
        //        new PhoneNumberList("Smith","William", "555-1785"),
        //        new PhoneNumberList("Smith","Brad", "555-9224")
        //    };

    }


    //public class PhoneNumberList
    //{

    //    public string firstName;
    //    public string lastName;
    //    public string phoneNumber;

    //    public PhoneNumberList(string firstName, string lastName, string phoneNumber)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //        this.phoneNumber = phoneNumber;
    //    }
    //}
}
