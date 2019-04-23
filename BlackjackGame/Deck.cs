using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackjackGame.Card;

namespace BlackjackGame
{
    class Deck
    {
        // a stack of cards is a deck
        List<Card> cardList = new List<Card>();
        public Deck()
        {
            // default constructor is an ORDERED, UNSHUFFLED deck of cards. like it's brand new
            // completeDeck.Push(AddHearts());
            AddHearts();
            AddDiamonds();
            AddSpades();
            AddClubs();

        }

        public void Shuffle(Deck deck)
        {

        }

        // create 13 Hearts
        // WHY WHY WHY IS IT REPEATING JACK 4 TIMES JUST BECAUSE THE VALUE IS THE SAME
        // MIGHT HAVE TO SCRAP ENUM SCHEME AND USE DICT OR 
        void AddHearts()
        {
            string[] allValues = Enum.GetNames(typeof(Values));

            foreach (var name in allValues)
            {
                cardList.Add(new Card(Suit.Heart, (Values)Enum.Parse(typeof(Values), name)));
            }
        }

        // create 13 Diamonds
        void AddDiamonds()
        {
            var allValues = Enum.GetNames(typeof(Values));

            foreach (var name in allValues)
            {
                cardList.Add(new Card(Suit.Diamond, (Values)Enum.Parse(typeof(Values), name)));
            }
        }

        // create 13 Spades
        void AddSpades()
        {
            List<Values> allValues = Enum.GetValues(typeof(Values))
                                            .Cast<Values>()
                                            .ToList();

            for (int i = 0; i < 13; i++)
            {
                cardList.Add(new Card(Suit.Spade, allValues[i]));
            }
        }

        // create 13 Clubs
        void AddClubs()
        {
            // give me a list of possible enum values (13 total)
            // loop through and assign that enum with a suit, add to deck

            List<Values> allValues = Enum.GetValues(typeof(Values))
                                            .Cast<Values>()
                                            .ToList();

            for (int i = 0; i < 13; i++)
            {
                cardList.Add(new Card(Suit.Club, allValues[i]));
            }
        }

        public void GetCards()
        {
            foreach (Card item in cardList)
            {
                Console.WriteLine("You draw: {0}, {1}", item.CardValue, item.CardSuit);
            }
        }
        // TODO: shuffle
    }
}
