using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Create a order class to represent a new customer order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        
        /// <summary>
        /// The subtotal of all the items in the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subTotalCost = 0;
                foreach(IOrderItem i in Items)
                {
                    subTotalCost += i.Price;     
                }
                if(subTotalCost < 0)
                {
                    return 0;
                }
                return subTotalCost;
            }
        }

        /// <summary>
        /// The tax rate 
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// The tax rate times the cost of the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// The total cost after the rate calculation
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
