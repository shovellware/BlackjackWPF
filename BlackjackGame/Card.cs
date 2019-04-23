using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Card
    {
        public enum Suit { Heart, Diamond, Spade, Club }
        public enum Values
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack = 10,
            Queen = 10,
            King = 10,
            Ace = 11
        }
        public Suit CardSuit { get; set; }
        public Values CardValue { get; set; }


        // generates a single card with a suit and a rank
        public Card(Suit suit, Values values)
        {
            CardSuit = suit;
            CardValue = values;
        }
    }
}

// i need to create 52 cards
// each card is unique, and has its own rank and suit
// the cards can be shuffled
// the cards can then be placed on a stack after the shuffle
