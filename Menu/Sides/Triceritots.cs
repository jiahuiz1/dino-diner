﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The Triceritots of Side(Tater tots)
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// The size of Triceritots
        /// </summary>
        private Size size;

        /// <summary>
        /// Determine the size of Triceritots and set the price and calories, and also gets the size 
        /// </summary>
        public override Size Size
        {
            get { return size; }

            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the ingredients of Triceritots
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }
        }

        /// <summary>
        /// The constructor that sets the default price, calories and ingredients
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }
    }
}