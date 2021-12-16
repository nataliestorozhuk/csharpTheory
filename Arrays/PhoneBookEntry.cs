using System.Collections.Generic;

namespace Arrays
{
    class PhoneBookEntry
    {
        public static void Run()
        {
            GetTheData();
        }
        public string PersonsName { get; set; }
        public string PhoneNum { get; set; }

        public PhoneBookEntry(string personsName, string phoneNum)
        {
            PersonsName = personsName;
            PhoneNum = phoneNum;
        }

        public static void GetTheData()
        {
            List<PhoneBookEntry> phones = new List<PhoneBookEntry>()
            {
                new PhoneBookEntry("Nata", "215-111-1424"),
                new PhoneBookEntry("Nick", "215-000-1111"),
                new PhoneBookEntry("Oliver", "215-222-3333")
            };

            foreach (var item in phones)
            {
                System.Console.WriteLine(item.PersonsName);
                System.Console.WriteLine(item.PhoneNum);
                System.Console.WriteLine();
            }

        }
    }
}

