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
        /// combo to store drinks
        /// </summary>
        private CretaceousCombo combo { get; set; }
        
        /// <summary>
        /// current drink
        /// </summary>
        private Drink drink { get; set; }

        /// <summary>
        /// current size
        /// </summary>
        private DDSize size { get; set; }

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
        /// Another constructor that passes an object of drink
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            SweetDecafFlavor.IsEnabled = false;
            AddLemon.IsEnabled = false;
            HoldIce.IsEnabled = false;
            this.drink = combo.Drink;
            this.size = combo.Drink.Size;
            this.combo = combo;
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
                if(combo != null)
                {
                    combo.Drink = new JurassicJava();
                    SweetDecafFlavor.IsEnabled = true;
                    AddLemon.IsEnabled = false;
                    HoldIce.IsEnabled = false;
                }
                else
                {
                    drink = new JurassicJava();
                    drink.Size = size;
                    order.Add(drink);
                    SweetDecafFlavor.IsEnabled = true;
                    AddLemon.IsEnabled = false;
                    HoldIce.IsEnabled = false;
                }                 
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
                if(combo != null)
                {
                    combo.Drink = new Sodasaurus();
                    SweetDecafFlavor.IsEnabled = true;
                    HoldIce.IsEnabled = true;
                    AddLemon.IsEnabled = false;
                }
                else
                {
                    drink = new Sodasaurus();
                    drink.Size = size;
                    order.Add(drink);
                    SweetDecafFlavor.IsEnabled = true;
                    HoldIce.IsEnabled = true;
                    AddLemon.IsEnabled = false;
                }              
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
                if(combo != null)
                {
                    combo.Drink = new Tyrannotea();
                    SweetDecafFlavor.IsEnabled = true;
                    HoldIce.IsEnabled = true;
                    AddLemon.IsEnabled = true;
                }
                else
                {
                    drink = new Tyrannotea();
                    drink.Size = size;
                    order.Add(drink);
                    SweetDecafFlavor.IsEnabled = true;
                    HoldIce.IsEnabled = true;
                    AddLemon.IsEnabled = true;

                }               
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
                if(combo != null)
                {
                    combo.Drink = new Water();
                    SweetDecafFlavor.IsEnabled = false;
                    HoldIce.IsEnabled = true;
                    AddLemon.IsEnabled = true;
                }
                else
                {
                    drink = new Water();
                    drink.Size = size;
                    order.Add(drink);
                    SweetDecafFlavor.IsEnabled = false;
                    HoldIce.IsEnabled = true;
                    AddLemon.IsEnabled = true;
                }                
            }
        }

        /// <summary>
        /// The size button is pressed, apply the size to the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if(combo == null)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
                else
                {
                    combo.Drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
                
            }
        }

        /// <summary>
        /// Event handler for Hold Ice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldIceChange(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                drink.HoldIce();
            }
        }
       
        /// <summary>
        /// Event handler for SweetDecafFlavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
                    if(combo == null)
                    {
                        NavigationService.Navigate(new FlavorSelection(soda));
                    }
                    else
                    {
                        NavigationService.Navigate(new FlavorSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for Add Lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// Event handler for Hold Ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
     
        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void BackToMenu(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for backing to combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void BackToCombo(object sender, RoutedEventArgs args)
        {
            if(combo == null)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
            {
                NavigationService?.Navigate(new CustomizeCombo(combo));
            }
           
        }
    }
}
