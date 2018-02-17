using System;
using System.Collections.Generic;
using System.Text;

namespace deckOfCards
{
    public class Card
    {
        public string stringVal, suit;
        public int val;
        private string[] _theFace = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public override string ToString()
        {
            return stringVal.ToString();
        }
        public Card(int cardVal, string cardSuit)
        {
            val = cardVal;
            suit = cardSuit;
            stringVal = _theFace[cardVal - 1];
        }
    }
}
