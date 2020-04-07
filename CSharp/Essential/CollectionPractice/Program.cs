using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            // Create an array of length 10 that alternates between true and false values, starting with true
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] stringArray = {"Tim", "Martin", "Nikki", "Sara"};
            Boolean[] booleanArray = {true, false, true, false, true, false, true, false, true, false};

            Console.WriteLine(String.Join((","),numArray));
            Console.WriteLine(String.Join((","),stringArray));
            Console.WriteLine(String.Join((","),booleanArray));

            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            // Output the length of this list after building it
            // Output the third flavor in the list, then remove this value
            // Output the new length of the list (It should just be one fewer!)
            List<string> icecream = new List<string>();

            icecream.Add("Vanila");
            icecream.Add("Strawbery");
            icecream.Add("Chocolate");
            icecream.Add("Mint");
            icecream.Add("GreenTea");

            Console.WriteLine(String.Join((","),icecream));
            Console.WriteLine(icecream.Count);
            Console.WriteLine(icecream[2]);
            icecream.RemoveAt(2);
            Console.WriteLine(icecream.Count);
            Console.WriteLine(String.Join((","),icecream));

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            Dictionary<string,string> userInfo = new Dictionary<string, string>();

            Random rand = new Random();

            foreach (string name in stringArray)
            {
                int r = rand.Next(icecream.Count);
                userInfo.Add(name, icecream[r]);
            }

            foreach (var entry in userInfo)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
