using System;
using System.Collections.Generic;
using System.Text;

namespace deckOfCards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        private string[] suits = { "Diamond", "Heart", "Club", "Spade" };

        public Deck()
        {
            InitDeck();
        }

        public void InitDeck()
        {
            foreach (string suit in suits)
            {
                for (int val = 1; val <= 13; val++)
                {
                    Card oneCard = new Card(val, suit);
                    cards.Add(oneCard);
                    // TEST Console.WriteLine("This was created {0}", oneCard.stringVal);
                }
            }
        }
        public Card GetCard(int index)
        {
            Card card = cards[index];
            return card;
        }
        public Card Deal()
        {
            if (cards.Count > 0)
            {
                Card topCard = GetCard(0);
               // TEST Console.WriteLine("first index contains value {0} and deck has {1} cards", cards[0].val, cards.Count);
                cards.RemoveAt(0);
               // TEST Console.WriteLine("NOW first index contains value {0} and deck has {1} cards", cards[0].val, cards.Count);
                return topCard;
            }
            else{
                Console.WriteLine("Out of Cards...");
                ResetDeck();
                Shuffle();
                return Deal();
            }
        }
        public void ResetDeck()
        {
            Console.WriteLine("Grabbing a New Deck!");
            cards.Clear();
            InitDeck();
        }
        public void Shuffle()
        {
            Random indexRand = new Random();

            for (int index = 0; index < cards.Count-1; index++)
            {
                int ranomIndex = indexRand.Next(cards.Count);
                Card temp = cards[index];
                cards[index] = cards[ranomIndex];
                cards[ranomIndex] = temp;
            }
        }

    }
}
