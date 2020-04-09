using System;
using System.Collections.Generic;
using System.Linq;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a Buffet, a SweetTooth, and a SpiceHound.
            Buffet buff = new Buffet();
            SweetTooth sweetT = new SweetTooth();
            SpiceHound spiceH = new SpiceHound();

            // have both the SweetTooth and Spice hound "Consume" from the Buffet until Full.
            Console.WriteLine("## SWEETTOOTH ##");
            while (!sweetT.IsFull)
            {
                sweetT.Consume(buff.Serve());
            }
            Console.WriteLine("########################################################");
            Console.WriteLine("## SPICEHOUND ##");
            while (!spiceH.IsFull)
            {
                spiceH.Consume(buff.Serve());
            }
            
            Console.WriteLine("########################################################");

            // write to the console which of the two consumed the most items and the number of items consumed.
            List<IConsumable> allHistory = new List<IConsumable>();
            foreach (var thing in sweetT.ConsumptionHistory)
            {
                allHistory.Add(thing);
            }
            foreach (var thing in spiceH.ConsumptionHistory)
            {
                allHistory.Add(thing);
            }

            var sortHistory = allHistory.GroupBy(item => item.Name);
            var sorted = sortHistory.OrderByDescending(group => group.Count());   

            Console.WriteLine("## GROUP ITEMS BY NUMBER OF ITEMS CONSUMED ##");
            foreach(var group in sorted)    
            {    
                int count = 0;
                foreach(var item in group)
                {
                    count++;
                }
                Console.WriteLine(group.Key + " - " + count);             
            } 
        }
    }
}
