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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// private field to store an object of PrehistoricPBJ
        /// </summary>
        private PrehistoricPBJ pbj;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pbj">an object of Prehistoric</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Event handler for Hold Peanut button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldPeanutButter();
        }

        /// <summary>
        /// Event handler for Hold Jelly button
        /// </summary>
        /// <param name="sende"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sende, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            //go back to the previous page
            NavigationService.GoBack();
        }
    }
}
