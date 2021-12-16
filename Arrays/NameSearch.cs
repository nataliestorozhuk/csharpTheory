using System;
using System.IO;



class NameSearch
{
    public static void Run()
    {
        string pathBoy = @"D:\OneDriveInn\OneDrive\Desktop\Files for C# exercises\BoyNames.txt";

        string pathGirl = @"D:\OneDriveInn\OneDrive\Desktop\Files for C# exercises\GirlNames.txt";

        if (File.Exists(pathBoy))
        {
            string[] boyNamesArr = File.ReadAllLines(pathBoy);

            string[] girlNamesArr = File.ReadAllLines(pathGirl);

            string boy = "Brandon";
            string girl = "Ol";

            var result = Array.Find(boyNamesArr, element => element == boy);
            var result1 = Array.Find(girlNamesArr, element => element == girl);


            Console.WriteLine(result);
            Console.WriteLine(result1);
        }



    }
}

