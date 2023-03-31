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
    
    }

    public partial class MainWindow : Window
    {
        public ObservableCollection<IDeck> Decks { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnDeleteScaleUnit(object sender, RoutedEventArgs e)
        { }

        private void OnAddScaleUnit(object sender, RoutedEventArgs e)
        { }
    }

    
}
