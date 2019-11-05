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
            if(DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                CretaceousCombo combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        void SelectBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            
            if (DataContext is Order order)
            {
                Brontowurst wurst = new Brontowurst();
                CretaceousCombo combo = new CretaceousCombo(wurst);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }          
        }

        void SelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggets = new DinoNuggets();
                CretaceousCombo combo = new CretaceousCombo(nuggets);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                CretaceousCombo combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }          
        }


        void SelectSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {           
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }


        void SelectTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger tr = new TRexKingBurger();
                CretaceousCombo combo = new CretaceousCombo(tr);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }


        void SelectVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                CretaceousCombo combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
      
    }
}
