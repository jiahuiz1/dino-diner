using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {    
        public ObservableCollection<IOrderItem> Items { get; set; }
        
        //check this method
        public double SubtotalCost
        {
            get
            {
                double subTotalCost = 0;
                foreach(IOrderItem i in Items)
                {
                    if(subTotalCost > 0)
                    {
                        subTotalCost += i.Price;
                    }                   
                }
                return subTotalCost;
            }
        }

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
