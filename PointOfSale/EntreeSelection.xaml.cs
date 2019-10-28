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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree { get; set; }

        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        private void OnSelectBrontoWurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }
        }

        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }
        }

        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
            }
        }

        private void OnSelectPterdactyIWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
        }

        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
        }

        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
        }

        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
        }

        void OnAddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }
    }
}
