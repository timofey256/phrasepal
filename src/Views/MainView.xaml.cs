using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PhrasePal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public interface IDeck
    {
        public string Name { get; set; }
    }

    public class Deck : IDeck
    { 
        public string Name { get; set; }

        public Deck(string name)
        {
            Name = name;
        }
    }

    public partial class MainWindow : Window
    {
        public ObservableCollection<Deck> Decks { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void OnDeleteScaleUnit(object sender, RoutedEventArgs e)
        { }

        private void OnAddScaleUnit(object sender, RoutedEventArgs e)
        { }

        private void OnDeleteMachineFunction(object sender, RoutedEventArgs e)
        { }

        private void OnAddMachineFunction(object sender, RoutedEventArgs e)
        { }

        private void OnDeckDetails(object sender, RoutedEventArgs e)
        { }

        private Grid CreateNewDeckComponent(Deck deck) 
        {
            Grid deckPanel = new Grid();
            deckPanel.Margin = new Thickness(0, 10, 0, 0);
            deckPanel.Height = 70.0;
            deckPanel.Background = Brushes.Aqua;

            ColumnDefinition c1 = new ColumnDefinition();
            ColumnDefinition c2 = new ColumnDefinition();
            deckPanel.ColumnDefinitions.Add(c1);
            deckPanel.ColumnDefinitions.Add(c2);

            TextBlock deckLabel = new TextBlock();
            deckLabel.Text = deck.Name;
            deckLabel.FontSize = 13.0;
            deckLabel.Margin = new Thickness(20, 0, 0, 0);
            deckLabel.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(deckLabel, 0);

            Button deckDetails = new Button();
            deckDetails.Click += new RoutedEventHandler(OnDeckDetails);
            deckDetails.HorizontalAlignment = HorizontalAlignment.Right;
            deckDetails.Margin = new Thickness(0, 0, 20, 0);
            deckDetails.Height = 20;
            deckDetails.Width = 20;
            deckDetails.Content = "...";
            Grid.SetColumn(deckDetails, 1);

            deckPanel.Children.Add(deckLabel);
            deckPanel.Children.Add(deckDetails);
            return deckPanel;
        }

        private void OnAddNewDeck(object sender, RoutedEventArgs e)
        {
            Deck d = new Deck("MyNewDeck1");
            Grid deckComponent = CreateNewDeckComponent(d);
            lstDecks.Children.Add(deckComponent);
        }
    }

    
}
