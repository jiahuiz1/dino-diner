﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The MezzorellaSticks side(Fried Breaded Mozzarella Sticks)
    /// </summary>
    public class MezzorellaSticks : Side, IOrderItem
    {
        /// <summary>
        /// The size of MezzorellaSticks
        /// </summary>
        private Size size;
       

        /// <summary>
        /// Determine the size of MezzorellaSticks and sets the price and calories, and also gets the size
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
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }

        /// <summary>
        /// Return the ingredienst of the MezzorellaSicks
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegetable Oil");
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
                return special.ToArray();
            }
        }

        /// <summary>
        /// The constructor
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;          
        }

        /// <summary>
        /// Override the ToString method to return the description
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return $"{size.ToString()} Mezzorella Sticks";
        }
    }
}
