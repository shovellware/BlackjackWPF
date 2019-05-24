using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Player
    {
        // couldnt just do regular properties. the way listview works in xaml it has to return a list.
        // so a public one here can do for now while I work on functionality. will look into later
        public List<Card> cardsInHand = new List<Card>();
        

        // count cards for the user
        //public int HandTotal { get; set; }
        private int _handTotal;
        public int HandTotal
        {
            get { return _handTotal; }
            set { _handTotal = AddHand(cardsInHand); }
        }

        static int AddHand(List<Card> hand)
        {
            int sum = 0;
            // get the value of each key value pair, and add it to the sum for a hand total
            foreach (var item in hand)
            {
                sum += item.CardRank.Value;
            }

            return sum;
        }
    }
}
