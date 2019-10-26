using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Create a order class to represent a new customer order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
      

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Items added to the order
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

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

        public Order()
        {
            items = new List<IOrderItem>();       
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }
        
        public bool Remove(IOrderItem item)
        {
            bool remove = items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
            return remove;
        }

    }
}
