namespace DeckOfCards.Models
{
    public class Card
    {
        public string Suit {get;}
        public string StringVal {get;}
        public int Val {get;}

        public Card(string suit, string svalue, int val)
        {
            Suit = suit;
            StringVal = svalue;
            Val = val;
        }


    }
}