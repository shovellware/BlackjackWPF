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

            // data binding demo
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });

            // must have same name as the code in .xaml
            lvDataBinding.ItemsSource = items;

        }

        // data binding demo
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return this.Name + ", " + this.Age + " years old";
            }
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
