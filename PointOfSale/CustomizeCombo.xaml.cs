﻿using System;
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

        private Entree entree { get; set; }

        private Side side { get; set; } = new Fryceritops();

        private Drink drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// The constructor
        /// </summary>
        public CustomizeCombo(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// Navigate to the side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(side));
        }

        /// <summary>
        /// Navigate to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(drink));
        }

        /// <summary>
        /// Navigate to the entree selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectEntree(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (entree is Brontowurst bw)
                {
                    order.Add(bw);
                    NavigationService.Navigate(new CustomizeBrontowurst(bw));
                }
                else if (entree is DinoNuggets nuggets)
                {
                    order.Add(nuggets);
                    NavigationService.Navigate(new CustomizeDinoNuggets(nuggets));
                }
                else if(entree is PrehistoricPBJ pbj)
                {
                    order.Add(pbj);
                    NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
                }
                else if(entree is PterodactylWings wings)
                {
                    order.Add(wings);                  
                }
                else if(entree is SteakosaurusBurger burger)
                {
                    order.Add(burger);
                    NavigationService.Navigate(new CustomizeSteakosaurusBurger(burger));
                }
                else if(entree is TRexKingBurger TRburger)
                {
                    order.Add(TRburger);
                    NavigationService.Navigate(new CustomizeTRexKingBurger(TRburger));
                }
                else if(entree is VelociWrap wrap)
                {
                    order.Add(wrap);
                    NavigationService.Navigate(new CustomizeVelociWrap(wrap));
                }
            }
        }

        private void ChangeComboSizeSmall(object sender, RoutedEventArgs args)
        {
            side.Size = DDSize.Small;
            drink.Size = DDSize.Small;
        }    
        
        private void ChangeComboSizeMedium(object sender, RoutedEventArgs args)
        {
            side.Size = DDSize.Medium;
            drink.Size = DDSize.Medium;
        }

        private void ChangeComboSizeLarge(object sender, RoutedEventArgs args)
        {
            side.Size = DDSize.Large;
            drink.Size = DDSize.Large;
        }
    }
}
