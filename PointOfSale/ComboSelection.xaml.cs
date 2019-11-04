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

        /// <summary>
        /// The constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigate to the Customize page, with the PterodactylWings object passed in 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            PterodactylWings wings = new PterodactylWings();
            CretaceousCombo combo = new CretaceousCombo(wings);
            if(DataContext is Order order)
            {
                order.Add(combo);
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        void SelectBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            Brontowurst wurst = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(wurst);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        void SelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            DinoNuggets nuggets = new DinoNuggets();
            CretaceousCombo combo = new CretaceousCombo(nuggets);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(pbj);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }


        void SelectSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }


        void SelectTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            TRexKingBurger tr = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(tr);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }


        void SelectVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            CretaceousCombo combo = new CretaceousCombo(wrap);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
      
    }
}
