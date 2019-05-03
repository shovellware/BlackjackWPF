using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackjackGame.Card;

namespace BlackjackGame
{
    public class Deck
    {
        // a stack of cards is a deck
        public Stack<Card> cardList = new Stack<Card>();
        public Deck()
        {
            // default constructor is an ORDERED, UNSHUFFLED deck of cards. like it's brand new
            AddHearts();
            AddDiamonds();
            AddSpades();
            AddClubs();
        }

        // TODO: shuffle
        public void Shuffle(Deck deck)
        {

        }

        // create 13 Hearts
        // TODO: see below
        // WHY IS IT REPEATING JACK 4 TIMES JUST BECAUSE THE VALUE IS THE SAME
        void AddHearts()
        {
            // suit and value are properly added here
            var allValues = Enum.GetNames(typeof(Values));

            foreach (var name in allValues)
            {
                // during this addition is where the jack problem arises
                cardList.Push(new Card(Suit.Heart, (Values)Enum.Parse(typeof(Values), name)));
            }
        }

        // create 13 Diamonds
        void AddDiamonds()
        {
            var allValues = Enum.GetNames(typeof(Values));

            foreach (var name in allValues)
            {
                cardList.Push(new Card(Suit.Diamond, (Values)Enum.Parse(typeof(Values), name)));
            }
        }

        // create 13 Spades
        void AddSpades()
        {
            var allValues = Enum.GetValues(typeof(Values))
                                            .Cast<Values>()
                                            .ToList();

            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Spade, allValues[i]));
            }
        }

        // create 13 Clubs
        void AddClubs()
        {
            // give me a list of possible enum values (13 total)
            // loop through and assign that enum with a suit, add to deck

            var allValues = Enum.GetValues(typeof(Values))
                                            .Cast<Values>()
                                            .ToList();

            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Club, allValues[i]));
            }
        }

        public Card GetCard()
        {
            return cardList.Pop();
        }
    }
}