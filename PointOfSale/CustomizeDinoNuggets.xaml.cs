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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// private field to store an object of DinoNuggets
        /// </summary>
        private DinoNuggets nuggets;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nuggets">an object of DinoNuggets</param>
        public CustomizeDinoNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nuggets = nuggets;
        }

        /// <summary>
        /// Event handler for extra nugget button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnExtraNugget(object sender, RoutedEventArgs args)
        {
            nuggets.AddNugget();
        }

        /// <summary>
        /// Event handler for done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
