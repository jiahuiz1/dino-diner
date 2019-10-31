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
        private TRexKingBurger TRburger;

        public CustomizeTRexKingBurger(TRexKingBurger TRburger)
        {
            InitializeComponent();
            this.TRburger = TRburger;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            TRburger.HoldBun();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            TRburger.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            TRburger.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            TRburger.HoldOnion();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            TRburger.HoldPickle();
        }

        private void OnHoldKetChup(object sender, RoutedEventArgs args)
        {
            TRburger.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            TRburger.HoldMustard();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            TRburger.HoldMayo();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
