using BlackjackGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // deck initialize test
            Deck myDeck = new Deck();

            #region deck display testing
            //List<Card> myList = new List<Card>();

            //for (int i = 0; i < 52; i++)
            //{
            //    myList.Add(myDeck.GetCard());
            //}
            //deckList.ItemsSource = myList;
            #endregion

            // both players automatically given 2 cards
            BlackjackGame.Player dominic = new Player();
            BlackjackGame.Player cpu = new Player();

            for (int i = 0; i < 2; i++)
            {
                dominic.cardsInHand.Add(myDeck.GetCard());
                cpu.cardsInHand.Add(myDeck.GetCard());
            }

            cpuCards.ItemsSource = cpu.cardsInHand;
            playerCards.ItemsSource = dominic.cardsInHand;
            

        }


        private void HitButton_Click(object sender, RoutedEventArgs e)
        {

            // draw a card to add to user's hand
            //BlackjackGame.Deck testing = new Deck();
            //MessageBox.Show(testing.GetCard());
            
        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {
            // keep current cards and see results of the round
        }
    }
}
