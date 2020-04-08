using System;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Deck d1 = new Deck();
            d1.shuffle();
            Player tom = new Player("Tom");
            tom.draw(d1);
            tom.draw(d1);
            tom.draw(d1);
            tom.draw(d1);
            tom.draw(d1);
            tom.discard(1);
            tom.display();
        }
    }
}
