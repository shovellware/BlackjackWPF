using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Player
    {
        public List<Card> CardsInHand { get; set; } = new List<Card>();
        
        // count cards for the user
        //public int HandTotal { get; set; }
        private int _handTotal;
        public int HandTotal
        {
            get { return _handTotal; }
            set { _handTotal = AddHand(CardsInHand); }
        }

        static int AddHand(List<Card> hand)
        {
            int sum = 0;
            // get the value of each key value pair, and add it to the sum for a hand total
            foreach (Card item in hand)
            {
                sum += item.CardRank.Value;
            }

            return sum;
        }
    }
}
