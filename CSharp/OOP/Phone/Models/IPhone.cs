using System;

namespace Phone.Models
{
    public class IPhone : Phone, IRingable 
    {
        public IPhone(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            // your code here
            return $"... {_ringTone} ...";
        }     
        public string Unlock() 
        {
            // your code here
            return $"iPhone {_versionNumber} unlocked with face scanner";
        }
        public override void DisplayInfo() 
        {
            // your code here       
            Console.WriteLine("##############################");
            Console.WriteLine($"iPhone " + _versionNumber);
            Console.WriteLine($"Battery Percentage: " + _batteryPercentage);
            Console.WriteLine($"Carrier: " + _carrier);
            Console.WriteLine($"Ring Tone: " + _ringTone);
            Console.WriteLine("##############################");   
            Console.WriteLine(""); 
        }
    }
}