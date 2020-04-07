using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static void FindMinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];
            int sum = array[0];

            for (int i=1; i<array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
            }

            Console.WriteLine($"Min value = {min}");
            Console.WriteLine($"Max value = {max}");
            Console.WriteLine($"Sum values = {sum}");

        }
        public static int[] RandomArray()
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i=0; i<10; i++)
            {
                int val = rand.Next(2, 25);
                array[i] = val;
            }
            
            FindMinMax(array);

            return array;

        }

        public static string TossCoin()
        {
            Random rand = new Random();
            string result = "Heads";

            Console.WriteLine("Tossing a Coin!");
            if (rand.Next(0, 2) == 1)
            {
                result = "Tails";
                Console.WriteLine(result);
                return result;
            } else
            {
                Console.WriteLine(result);
                return result; 
            }
        }

        public static int TossCoin(int num)
        {
            Random rand = new Random();
            string result = "Heads";
            int count = 0;

            Console.WriteLine("Tossing a Coin!");

            for (int i=0; i<num; i++)
            {
                if (rand.Next(0, 2) == 1)
                {
                    result = "Tails";
                    Console.WriteLine(result);
                } else
                {
                    result = "Heads";
                    Console.WriteLine(result);
                    count++;
                }
            }

            return count;
        }

        public static double TossMultipleCoins()
        {
            double ratio = 0.00;
            Random rand = new Random();
            int num = rand.Next(1, 6);

            ratio = Convert.ToDouble(TossCoin(num)) / Convert.ToDouble(num);

            Console.WriteLine($"Heads Ratio = {ratio}");

            return ratio;
        }

        public static List<string> Shuffle(List<string> name)
        {
            Random rand = new Random();

            int n = name.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string val = name[k];
                name[k] = name[n];
                name[n] = val;
            }

            return name;
        }

        public static List<string> Names()
        {
            List<string> name = new List<string>();
            name.Add("Todd");
            name.Add("Tiffany");
            name.Add("Charlie");
            name.Add("Geneva");
            name.Add("Sydney");

            name = Shuffle(name);

            List<int> arrayIndex = new List<int>();

            for (int i=0; i<name.Count; i++)
            {
                if (name[i].Length < 5)
                {
                    arrayIndex.Add(i);
                }
            }

            for (int i=0; i<arrayIndex.Count; i++)
            {
                name.RemoveAt(arrayIndex[i]);
            }
            
            Console.WriteLine(string.Join((","), name));

            return name;
        }

        static void Main(string[] args)
        {
            // Random Array
            // Create a function called RandomArray() that returns an integer array

            // - Place 10 random integer values between 5-25 into the array
            // - Print the min and max values of the array
            // - Print the sum of all the values
            Console.WriteLine(String.Join((","), RandomArray()));


            // Coin Flip
            // Create a function called TossCoin() that returns a string
            // - Have the function print "Tossing a Coin!"
            // - Randomize a coin toss with a result signaling either side of the coin 
            // - Have the function print either "Heads" or "Tails"
            // - Finally, return the result
            TossCoin();
            // Create another function called TossMultipleCoins(int num) that returns a Double
            // - Have the function call the tossCoin function multiple times based on num value
            // - Have the function return a Double that reflects the ratio of head toss to total toss
            TossMultipleCoins();


            // Names
            // Build a function Names that returns a list of strings.  In this function:
            // - Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // - Shuffle the list and print the values in the new order
            // - Return a list that only includes names longer than 5 characters
            Names();
        }
    }
}
