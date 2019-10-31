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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private Entree entree { get; set; }

        private Side side { get; set; }

        private Drink drink { get; set; }
        /// <summary>
        /// The constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigate to the Customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {          
            //NavigationService.Navigate(new CustomizeCombo());
        }

        void SelectBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            entree = new Brontowurst();
            NavigationService.Navigate(new CustomizeCombo(entree));
        }

        void SelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            entree = new DinoNuggets();
            NavigationService.Navigate(new CustomizeCombo(entree));
        }
    }
}
