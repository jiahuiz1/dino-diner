using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
  
    /// <summary>
    /// The base class of Drinks
    /// </summary>
    public abstract class Drink: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
       
        /// <summary>
        /// The Priec of the drink
        /// </summary>
        public abstract double Price { get; set; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients of the drink
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; } 

        /// <summary>
        /// Whether the drink has ice
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Get the description of the drink
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Get the special instructions of the drink
        /// </summary>
        public abstract string[] Special { get; }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Hold Ice to the drink
        /// </summary>
        /// <returns></returns>
        public bool HoldIce()
        {
            Ice = false;
            return Ice;
        }

        /// <summary>
        /// The constructor
        /// </summary>
        public Drink()
        {
            Size = Size.Small;
        }

    }
}
