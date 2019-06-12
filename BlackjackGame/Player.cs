using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Player
    {
        // couldnt just do regular properties. the way listview works in xaml it has to return a list. see below
        // ----fixed-----
        // cards in hand is now a real property. this is necessary because wpf cannot do binding for fields
        //private List<Card> _cardsInHand = new List<Card>();
        //public List<Card> CardsInHand
        //{
        //    get { return _cardsInHand; }
        //    set { _cardsInHand = value; }
        //}

        // this shorthand version accomplishes everything from above, in one line
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
            foreach (var item in hand)
            {
                sum += item.CardRank.Value;
            }

            return sum;
        }
    }
}
