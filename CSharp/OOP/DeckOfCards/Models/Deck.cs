using System;
using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            reset();
        }

        public void reset()
        {
            cards = new List<Card>();
            string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] sval = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

            for (int i=0; i<suit.Length; i++)
            {
                for (int j=0; j<sval.Length; j++)
                {
                    cards.Add(new Card(suit[i], sval[j], j+1));
                }
            }
        }

        public void display()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine($"The card is {card.StringVal}, {card.Suit}, {card.Val}");
            }
            Console.WriteLine("##################################");
        }

        public void shuffle()
        {
            Random rand = new Random();
            for (int j=0; j<5; j++)
            {
                for (int i=0; i<cards.Count; i++)
                {
                    int index = rand.Next(0, cards.Count);
                    Card temp = cards[index];
                    cards[index] = cards[i];
                    cards[i] = temp;
                }
            }
        }

        public Card deal()
        {
            Card pick = cards[0];
            cards.RemoveAt(0);
            return pick;
        }

    }
}