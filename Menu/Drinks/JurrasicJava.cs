﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The JurrasicJava class that drived from DrinkBaseClass
    /// </summary>
    public class JurrasicJava: DrinkBaseClass
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets or sets the size of the drink(different size has different price and calories)
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if(size == Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                }
                else if(size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                else if(size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// The ingredients of JurrasicJava that returns the protected field 
        /// </summary>
        public override List<string> Ingredients
        {
            get { return ingredients; }
        }

        /// <summary>
        /// Whether there is room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether the drink is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Leave some room for cream
        /// </summary>
        /// <returns></returns>
        public bool LeaveRoomForCream()
        {
            RoomForCream = true;
            return RoomForCream;
        }

        /// <summary>
        /// Add Ice to the drink
        /// </summary>
        /// <returns></returns>
        public bool AddIce()
        {
            Ice = true;
            return Ice;
        }

        /// <summary>
        /// The constructor, set default values
        /// </summary>
        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
    }
}
