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
            // moved list of values here instead of wasting memory each time the methods are called
            // the code to add cards is now more concise and uniform
            var allValues = Enum.GetValues(typeof(Values))
                                            .Cast<Values>()
                                            .ToList();


            // default constructor is an ORDERED, UNSHUFFLED deck of cards. like it's brand new
            // TODO: Can I do this all in one method? the only difference in each is the suit. maybe i can loop through each suit once and call a single method instead of the 4 below
            AddHearts(allValues);
            AddDiamonds(allValues);
            AddSpades(allValues);
            AddClubs(allValues);
        }

        // TODO: shuffle
        public void Shuffle(Deck deck)
        {

        }

        // create 13 Hearts
        void AddHearts(List<Values> allvals)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Heart, allvals[i]) );
            }
        }

        // create 13 Diamonds
        void AddDiamonds(List<Values> allvals)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Diamond, allvals[i]));
            }
        }

        // create 13 Spades
        void AddSpades(List<Values> allvals)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Spade, allvals[i]));
            }
        }

        // create 13 Clubs
        void AddClubs(List<Values> allvals)
        {
            // loop through and assign that enum with a suit, add to deck

            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Club, allvals[i]));
            }
        }

        public Card GetCard()
        {
            return cardList.Pop();
        }
    }
}