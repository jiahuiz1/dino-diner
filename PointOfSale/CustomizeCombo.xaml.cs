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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// The constructor
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigate to the side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Navigate to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
