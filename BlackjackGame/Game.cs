using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    /* GAME CLASS MUST
     * track player and user hands
     * add to each hand
     * track sum of each hand
     * check win or loss conditions
     * 
     */

    class Game
    {
        // all the game logic will be in this class
        // deck to be used for the game
        Deck gameDeck = new Deck();
        // gameDeck.Shuffle(); - knuth shuffle

        public void Play()
        {
            // track user hand and opponents hand
            // user hand - size can increase to an unknown size based on how many cards are given
            // user hand will be a list of <Card>
            List<Card> userHand = new List<Card>();
            List<Card> opponentHand = new List<Card>();

            Player dominic = new Player();
            Player cpu = new Player();

            // initial deal cards
            userHand.Add(gameDeck.GetCard()); // 2 cards
            opponentHand.Add(gameDeck.GetCard()); // 2 cards
        }








        //public void Hit(List<Card> hand)
        //{
        //    hand.Add(gameDeck)
        //}




        

        // Method to add a card to user hand with button from main xaml page
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