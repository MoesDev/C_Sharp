using System;
using System.Collections.Generic;
using System.Text;

namespace deckOfCards
{
    class Player
    {
        public string name;
        private List<Card> _hand = new List<Card>();

        public List<Card> hand = new List<Card>();

        public Player(string nameGiven)
        {
            InitPlayer(nameGiven);
            Console.WriteLine("Hi! Welcome {0}!", name);
        }

        public void InitPlayer(string namePassed)
        {
            name = namePassed;
            hand = _hand;
        }
        public void Draw(int numGiven, Deck deckName)
        {
            int numCards = 1;
            while (numCards <= numGiven)
            {
                Card addCard = deckName.Deal();
                _hand.Add(addCard);
                numCards++;
                Console.WriteLine("Player {0} you drew {1} of {2}s", name, addCard.stringVal, addCard.suit);
            }
        }

        public Card Discard(int indexOfHand)
        {
            if(_hand.Count > indexOfHand)
            {
                Card discardCard = _hand[indexOfHand];
                _hand.RemoveAt(indexOfHand);
                return discardCard;
            }
            else
            {
                return null;
            }
        }
    }
}
