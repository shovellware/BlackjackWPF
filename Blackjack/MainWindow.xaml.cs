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
            List<Card> myList = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                myList.Add(myDeck.GetCard());
            }
            deckList.ItemsSource = myList;

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
