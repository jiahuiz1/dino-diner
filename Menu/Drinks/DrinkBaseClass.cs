using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
  
    /// <summary>
    /// The base class of Drinks
    /// </summary>
    public abstract class DrinkBaseClass
    {
       
        /// <summary>
        /// The protected ingredients that we will use in other drived classes
        /// </summary>
        protected List<string> ingredients = new List<string>();

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
        public DrinkBaseClass()
        {
            Size = Size.Small;
        }
    }
}
