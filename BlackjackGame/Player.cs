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

        //public Card Hand
        //{
        //    get { return myVar; }
        //    set { myVar.Add(value); }
        //}


        // count cards for the user
        public int HandTotal { get; set; }
    }
}
