using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck oneDeck = new Deck();
            Card firstCard = oneDeck.GetCard(0);
            Console.WriteLine(firstCard.val);
            oneDeck.Deal();

            Console.WriteLine(oneDeck.cards[50].val);
            oneDeck.ResetDeck();
            Console.WriteLine(oneDeck.cards[51].stringVal);
            Console.WriteLine(oneDeck.cards.Count);

            oneDeck.Shuffle();

            Console.WriteLine(oneDeck.cards[51].stringVal);
            Console.WriteLine(oneDeck.cards.Count);
            Player ted = new Player("Ted");
            ted.Draw(2, oneDeck);

            Player jack = new Player("Jack");
            jack.Draw(5, oneDeck);
            ted.Draw(3, oneDeck);

            Card discardOne = jack.Discard(0);
            Console.WriteLine("{0} DISCARDS {1} of {2}s", jack.name, discardOne.stringVal, discardOne.suit);

           Card discardTwo = ted.Discard(5); 
           if(discardTwo != null) { 
                Console.WriteLine("{0} DISCARDS {1} of {2}s", ted.name, discardTwo.stringVal, discardTwo.suit);
           }
           else
           {
                Console.WriteLine("Discard choose was out of hand range... returned NULL");
           }

            Card discardThree = ted.Discard(4);
            Console.WriteLine("{0} DISCARDS {1} of {2}s", ted.name, discardThree.stringVal, discardThree.suit);
        }
    }
}
