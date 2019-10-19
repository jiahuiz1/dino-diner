using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
   
    /// <summary>
    /// The base clas of Sides
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

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
    }
}
