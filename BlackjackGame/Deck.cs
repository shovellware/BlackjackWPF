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
        // a stack of cards to be treated as a real deck
        public Stack<Card> cardList = new Stack<Card>();
        public Deck()
        {
            // a list of KeyValuePairs. pass it to my card-creating methods
            // this is -absolutely- necessary because the value of each card can be, for example, a face(king) and a RANK(10)
            var allRanks = Card.GetRanks();

            // default constructor is an ORDERED, UNSHUFFLED deck of cards. like it's brand new
            // TODO: Can I do this all in one method? the only difference in each is the suit. maybe i can loop through each suit once and call a single method instead of the 4 below
            AddHearts(allRanks);
            AddDiamonds(allRanks);
            AddSpades(allRanks);
            AddClubs(allRanks);
        }

        // TODO: shuffle
        public void Shuffle(Deck deck)
        {

        }

        // the following methods assign a SUIT to the proper cards
        // create 13 Hearts
        void AddHearts(List<KeyValuePair<string, int>> ranks)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Heart, ranks[i]) );
            }
        }

        // create 13 Diamonds
        void AddDiamonds(List<KeyValuePair<string, int>> ranks)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Diamond, ranks[i]));
            }
        }

        // create 13 Spades
        void AddSpades(List<KeyValuePair<string, int>> ranks)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Spade, ranks[i]));
            }
        }

        // create 13 Clubs
        void AddClubs(List<KeyValuePair<string, int>> ranks)
        {
            for (int i = 0; i < 13; i++)
            {
                cardList.Push(new Card(Suit.Club, ranks[i]));
            }
        }

        public Card GetCard()
        {
            return cardList.Pop();
        }
    }
}