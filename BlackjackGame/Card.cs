using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Card
    {
        // generates a single card with a suit and a rank
        public Card(Suit suit, KeyValuePair<string, int> values)
        {
            CardSuit = suit;
            CardRank = values;
        }

        public enum Suit { Heart, Diamond, Spade, Club }
        
        // properties of a playing card
        public Suit CardSuit { get; set; }
        public KeyValuePair<string, int> CardRank { get; set; }
        

        public static List<KeyValuePair<string, int>> GetRanks()
        {
            Dictionary<string, int> cardRanks = new Dictionary<string, int>()
            {
                {"Two", 2},
                {"Three", 3 },
                {"Four", 4 },
                {"Five", 5 },
                {"Six", 6 },
                { "Seven", 7 },
                {"Eight", 8 },
                {"Nine", 9 },
                {"Ten", 10 },
                {"Jack", 10 },
                {"Queen", 10 },
                {"King", 10 },
                {"Ace", 11 }
            };
            return cardRanks.ToList();
        }
    }
}