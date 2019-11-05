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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Combo to store the drink, side and entree
        /// </summary>
        private CretaceousCombo combo;
        
        /// <summary>
        /// private property to store the entree
        /// </summary>
        private Entree entree { get; set; }

        /// <summary>
        /// private property to store the side
        /// </summary>
        private Side side { get; set; } = new Fryceritops();

        /// <summary>
        /// private property to store the drink
        /// </summary>
        private Drink drink { get; set; } = new Sodasaurus();


        /// <summary>
        /// Constructor
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The other constructor that passes an entree
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.entree = combo.Entree;
            this.combo.Drink = drink;
            this.combo.Side = side;
        }

        /// <summary>
        /// Navigate to the side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Navigate to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        /// <summary>
        /// Navigate to the entree selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectEntree(object sender, RoutedEventArgs args)
        {
            if(combo.Entree is Entree entree)
            {
                if (entree is Brontowurst bw)
                {
                    NavigationService.Navigate(new CustomizeBrontowurst(bw));
                }
                else if (entree is DinoNuggets nuggets)
                {
                    NavigationService.Navigate(new CustomizeDinoNuggets(nuggets));
                }
                else if(entree is PrehistoricPBJ pbj)
                {
                    NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
                }
                else if(entree is PterodactylWings wings)
                {             
                }
                else if(entree is SteakosaurusBurger burger)
                {
                    NavigationService.Navigate(new CustomizeSteakosaurusBurger(burger));
                }
                else if(entree is TRexKingBurger TRburger)
                {
                    NavigationService.Navigate(new CustomizeTRexKingBurger(TRburger));
                }
                else if(entree is VelociWrap wrap)
                {
                    NavigationService.Navigate(new CustomizeVelociWrap(wrap));
                }
            }
        }

        /// <summary>
        /// Change the size of combo to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeComboSizeSmall(object sender, RoutedEventArgs args)
        {
            side.Size = DDSize.Small;
            drink.Size = DDSize.Small;
        }    
        
        /// <summary>
        /// change the size of combo to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeComboSizeMedium(object sender, RoutedEventArgs args)
        {
            side.Size = DDSize.Medium;
            drink.Size = DDSize.Medium;
        }

        /// <summary>
        /// change the size of combo to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeComboSizeLarge(object sender, RoutedEventArgs args)
        {
            side.Size = DDSize.Large;
            drink.Size = DDSize.Large;
        }
    }
}
