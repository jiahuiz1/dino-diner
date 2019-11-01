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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// private field to store an object of VelociWrap
        /// </summary>
        private VelociWrap wrap; 

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="wrap">an object of VelociWrap</param>
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// Event handler for Hold Dressing button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="agrs"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs agrs)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// Event handler for Hold Lettuce button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="agrs"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs agrs)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// Event hanlder for Hold Cheese button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="agrs"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs agrs)
        {
            wrap.HoldCheese();
        }

        /// <summary>
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="agrs"></param>
        private void OnDone(object sender, RoutedEventArgs agrs)
        {
            NavigationService.GoBack();
        }
    }
}
