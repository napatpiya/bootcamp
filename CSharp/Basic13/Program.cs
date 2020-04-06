using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        // Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i=1; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i=1; i<256; i=i+2)
            {
                Console.WriteLine(i);
            }
        }

        // Print Sum from 0 to 255
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int i=0; i<256; i++)
            {
                sum = sum + i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        // Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 

            for (int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // Find Max
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.

            int max = numbers[0];
            for (int i=1; i<numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }

        // Get Average
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.

            int sum = 0;
            double avg = 0.0;

            for (int i=0; i<numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }


        // Array with Odd Numbers
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].

            int[] array = new int[128];
            int index = 0;

            for (int i=1; i<256; i++)
            {
                if (i%2 != 0)
                {
                    array[index] = i;
                    index++;
                }
            }

            return array;

        }

        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).

            int num = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    num++;
                }
            }
            return num;
        }

        // Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]

            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
            }

        }

        // Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        // Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.

            int min = numbers[0];
            int max = numbers[0];
            int sum = numbers[0];

            for (int i=1; i<numbers.Length; i++)
            {
                sum += numbers[i];
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            int avg = sum / numbers.Length;
            Console.WriteLine($"min = {min}, max = {max}, avg = {avg}");

            int[] newArray;
            newArray = new int[] {max, min, avg};
        }

        // Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].

            for (int i=0; i<numbers.Length; i++)
            {
                if (i == numbers.Length-1)
                {
                    numbers[i] = 0;
                } else
                {
                    numbers[i] = numbers[i+1];
                }
                
                Console.WriteLine(numbers[i]);
            }
        }

        // Number to String
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] newArray = new object[numbers.Length];
            int index = 0;

            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] < 0) 
                {
                    newArray[index] = "Dojo";
                    index++;
                } else
                {
                    newArray[index] = numbers[i];
                    index++;
                }
            }

            foreach (object aa in newArray)
            {
                Console.WriteLine(aa);
            }

            return newArray;
        }


        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int[] array = {1,2,-3,4,5,-6,7};
            // LoopArray(array);
            // FindMax(array);
            // GetAverage(array);
            // Console.WriteLine(OddArray());
            // Console.WriteLine(GreaterThanY(array, 3));
            // SquareArrayValues(array);
            // EliminateNegatives(array);
            // MinMaxAverage(array);
            // ShiftValues(array);
            // NumToString(array);
        }
    }
}
