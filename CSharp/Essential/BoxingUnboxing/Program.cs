using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> listObject1 = new List<object>();
            listObject1.Add(7);
            listObject1.Add(28);
            listObject1.Add(-1);
            listObject1.Add(true);
            listObject1.Add("Chair");

            foreach (var val in listObject1)
            {
                Console.WriteLine(val);
            }

            List<object> listObject2 = new List<object>();
            listObject2.Add(7);
            listObject2.Add(28);
            listObject2.Add(-1);
            listObject2.Add(3);
            listObject2.Add(9);

            int sum = 0;
            foreach (var num in listObject2)
            {
                sum += (int)num;
            }

            Console.WriteLine(sum);
        }
    }
}
