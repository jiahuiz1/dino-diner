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
        /// combo to store the side, drink and entree
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// current side
        /// </summary>
        private Side side { get; set; }


        /// <summary>
        /// current size
        /// </summary>
        private DDSize size { get; set; }

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
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
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
            if (DataContext is Order order)
            {
                if(combo != null)
                {
                    combo.Side = new Fryceritops();
                    side = combo.Side;
                }
                else
                {
                    side = new Fryceritops();
                    side.Size = size;
                    order.Add(side);
                }
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
                if(combo != null)
                {
                    combo.Side = new MeteorMacAndCheese();
                    side = combo.Side;
                }
                else
                {
                    side = new MeteorMacAndCheese();
                    side.Size = size;
                    order.Add(side);
                }              
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
                if(combo != null)
                {
                    combo.Side = new MezzorellaSticks();
                    side = combo.Side;
                }
                else
                {
                    side = new MezzorellaSticks();
                    side.Size = size;
                    order.Add(side);
                }                
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
                if(combo != null)
                {
                    combo.Side = new Triceritots();
                    side = combo.Side;
                }
                else
                {
                    side = new Triceritots();
                    side.Size = size;
                    order.Add(side);
                }             
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
                if(combo == null)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
                else
                {
                    combo.Side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
            }
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
