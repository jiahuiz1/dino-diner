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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// private field to store an object of TRexKingBurger
        /// </summary>
        private TRexKingBurger TRburger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TRburger">an object of TRexKingBurger</param>
        public CustomizeTRexKingBurger(TRexKingBurger TRburger)
        {
            InitializeComponent();
            this.TRburger = TRburger;
        }

        /// <summary>
        /// Event handler for Hold Bun button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            TRburger.HoldBun();
        }

        /// <summary>
        /// Event handler for Hold Lettuce button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            TRburger.HoldLettuce();
        }

        /// <summary>
        /// Event handler for Hold Tomato button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            TRburger.HoldTomato();
        }

        /// <summary>
        /// Event handler for Hold Onion button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            TRburger.HoldOnion();
        }

        /// <summary>
        /// Event handler for Hold Pickle button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            TRburger.HoldPickle();
        }

        /// <summary>
        /// Event handler for Hold Ketchup button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetChup(object sender, RoutedEventArgs args)
        {
            TRburger.HoldKetchup();
        }

        /// <summary>
        /// Event handler for Hold Mustard button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            TRburger.HoldMustard();
        }

        /// <summary>
        /// Event handler for Hold Mayo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            TRburger.HoldMayo();
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
