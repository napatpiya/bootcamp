using System;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja nin = new Ninja();
            Buffet buff = new Buffet();

            while (!nin.IsFull)
            {
                nin.Eat(buff.Serve());
            }
        }
    }
}
