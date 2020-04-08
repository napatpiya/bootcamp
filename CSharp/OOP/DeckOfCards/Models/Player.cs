using System;
using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void draw(Deck cards)
        {
            Hand.Add(cards.deal());
            display();
        }

        public Card discard(int num)
        {
            if (num <= Hand.Count)
            {
                Card det = Hand[num-1];
                Hand.RemoveAt(num-1);
                return det;
            }
            else
            {
                return null;
            }
        }

        public void display()
        {
            int count = 1;
            Console.WriteLine($"Player {Name}");
            foreach (Card hand in Hand)
            {
                Console.WriteLine($"My card #{count} is {hand.Suit}, {hand.StringVal}, {hand.Val}");
                count++;
            }
            Console.WriteLine("##################################");
        }

    }
}