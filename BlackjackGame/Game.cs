using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    class Game
    {
        // all the game logic will be in this class
        // deck to be used for the game
        Deck gameDeck = new Deck();
        // gameDeck.Shuffle(); - knuth shuffle


        // track user hand and opponents hand

        // user hand - size can increase to an unknown size based on how many cards are given
        // user hand will be a list of <Card>
        // sum of user hand will be added to a total

        // TODO: win/loss conditions
        /* RULES - each player given 2 cards
         * opponent showing 1 card face up, 1 card face down
         * player hand total is displayed
         * player has option to hit, stand
         * if player hit, add next card to hand
         * 
         */
    }
}