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
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Current drink
        /// </summary>
        private Drink drink;     

        /// <summary>
        /// The constructor
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The other constructor
        /// </summary>
        /// <param name="drink">the drink</param>
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            if(drink is Sodasaurus)
            {
                this.drink = drink;
            }
        }

        /// <summary>
        /// Apply the flavor to the description of the drink if the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeFlavor(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                if(drink is Sodasaurus soda)
                {
                    soda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                }
                NavigationService?.Navigate(new DrinkSelection());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
