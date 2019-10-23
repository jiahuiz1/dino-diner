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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
           
          
        }

        /// <summary>
        /// Inherit the datacontext from the Windows(OrderUI) to the child(page)
        /// </summary>
        private void PassDataContentToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }     

        private void OnLoadCompleted(object sender, NavigationEventArgs agrs)
        {
            PassDataContentToPage();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
    }
}
