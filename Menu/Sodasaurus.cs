﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The sodasaurus class derived from DrinkBaseClass
    /// </summary>
    public class Sodasaurus : Drink, IOrderItem
    {
        /// <summary>
        /// The flavor of the drink
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// The size of the drink
        /// </summary>
        private Size size;
     

        /// <summary>
        /// Gets the flavor or set up the flavor of the drink
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            { return flavor; }
            set
            {
                flavor = value;
                NotifyPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets the size or set up the size of the drink(different size has different price and calories)
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Description");
                if (size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }


        /// <summary>
        /// The ingredients that return the protected filed
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flvaors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special items
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice)
                {
                    special.Add("Hold Ice");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// The construtor, set the default values
        /// </summary>
        public Sodasaurus()
        {
            Ice = true;
            Price = 1.50;
            Calories = 112;               
        }

        /// <summary>
        /// Override the ToString method to return the description
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return $"{size.ToString()} {flavor.ToString()} Sodasaurus";
        }
    }
}
