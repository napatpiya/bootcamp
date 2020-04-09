using System;

namespace Phone.Models
{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            // your code here
            return $"... {_ringTone} ...";
        }     
        public string Unlock() 
        {
            // your code here
            return $"Galaxy {_versionNumber} unlocked with fingerprint scanner";
        }
        public override void DisplayInfo() 
        {
            // your code here            
            Console.WriteLine("##############################");
            Console.WriteLine($"Galaxy " + _versionNumber);
            Console.WriteLine($"Battery Percentage: " + _batteryPercentage);
            Console.WriteLine($"Carrier: " + _carrier);
            Console.WriteLine($"Ring Tone: " + _ringTone);
            Console.WriteLine("##############################");
            Console.WriteLine("");
        }
    }
}


        