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
    //done for the drink page

    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// current drink
        /// </summary>
        private Drink drink { get; set; }

        /// <summary>
        /// The constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            SweetDecafFlavor.IsEnabled = false;
            AddLemon.IsEnabled = false;
            HoldIce.IsEnabled = false;
        }

        /// <summary>
        /// The JurrasicJava Button is pressed, enable its associated buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurrasicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
                SweetDecafFlavor.IsEnabled = true;
                AddLemon.IsEnabled = false;
                HoldIce.IsEnabled = false;         
            }
        }

        /// <summary>
        /// The sodasarus Button is pressed, enable its associated buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodaSaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
                SweetDecafFlavor.IsEnabled = true;
                HoldIce.IsEnabled = true;
                AddLemon.IsEnabled = false;
            }
        }

        /// <summary>
        /// The Tyrannotea Button is pressed, enable its associated buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
                SweetDecafFlavor.IsEnabled = true;
                HoldIce.IsEnabled = true;
                AddLemon.IsEnabled = true;
            }
        }

        /// <summary>
        /// The water Button is pressed, enable its associated buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
                SweetDecafFlavor.IsEnabled = false;
                HoldIce.IsEnabled = true;
                AddLemon.IsEnabled = true;
            }
        }

        /// <summary>
        /// The size button is pressed, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());                           
            }
        }

        private void HoldIceChange(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                drink.HoldIce();
            }
        }
       
        private void ChangeSweetDecafFlavorButton(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                if(drink is JurassicJava jj)
                {
                    jj.Decaf = true;
                }
                else if (drink is Tyrannotea tea)
                {                  
                    tea.Sweet = true;
                }
                else if(drink is Sodasaurus soda)
                {
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
            }
        }

        private void ChangeAddLemonButton(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if(drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else if(drink is Water water)
                {
                    water.AddLemon();
                }
            }
        }

        private void ChangeHoldIceButton(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                if(drink is Sodasaurus soda)
                {
                    soda.HoldIce();
                }
                else if(drink is Tyrannotea tea)
                {
                    tea.HoldIce();
                }
                else if(drink is Water water)
                {
                    water.HoldIce();
                }
            }
        }
     

        private void BackToMenu(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }
    }
}
