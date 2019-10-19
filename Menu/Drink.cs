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
        public double Price { get; set; }

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

        /// <summary>
        /// The event that represents a property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that the property of the class changed
        /// </summary>
        /// <param name="propertyName">the property name</param>
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
            NotifyPropertyChanged("Special");
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
