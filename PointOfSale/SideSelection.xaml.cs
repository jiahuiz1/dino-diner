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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// current side
        /// </summary>
        private Side side { get; set; }

        /// <summary>
        /// The constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The other constructor
        /// </summary>
        /// <param name="side">a side</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        private void Button_Click(object sender, RoutedEventArgs args)
        {

        }

        /// <summary>
        /// Add Fryceritops to the OrderList if the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
                NavigationService.Navigate(new CustomizeCombo());
            } 
        }

        /// <summary>
        /// Add MeterMacAndCheeese to the OrderList if the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        /// <summary>
        /// Add MezzorellaSticks to the OrderList if the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        /// <summary>
        /// Add Triceritots to the OrderList if the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(side);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        /// <summary>
        /// Apply the change of size to the description of the side if the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService?.Navigate(new MenuCategorySelection());
            }
        }
    }
}
