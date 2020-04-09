using System;

namespace Phone.Models
{
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            // your code here
            return $"... {_ringTone} ...";
        }
        public string Unlock() 
        {
            // your code here
            return $"Nokia {_versionNumber} unlocked with passcode";
        }
        public override void DisplayInfo() 
        {
            // your code here
            Console.WriteLine("##############################");
            Console.WriteLine($"Nokia " + _versionNumber);
            Console.WriteLine($"Battery Percentage: " + _batteryPercentage);
            Console.WriteLine($"Carrier: " + _carrier);
            Console.WriteLine($"Ring Tone: " + _ringTone);
            Console.WriteLine("##############################");
            Console.WriteLine("");
        }
    }    
} 

       