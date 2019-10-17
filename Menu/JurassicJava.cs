﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The JurrasicJava class that drived from DrinkBaseClass
    /// </summary>
    public class JurassicJava: Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        private Size size;


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets or sets the size of the drink(different size has different price and calories)
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
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

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream)
                {
                    special.Add("Leave Room For Cream");
                }
                if (Ice)
                {
                    special.Add("Add Ice");
                }                
                return special.ToArray();
            }
        }

        /// <summary>
        /// The ingredients of JurrasicJava that returns the protected field 
        /// </summary>
        public override List<string> Ingredients
        {
            get {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
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
            NotifyPropertyChanged("Room For Cream");
            return RoomForCream;
        }

        /// <summary>
        /// Add Ice to the drink
        /// </summary>
        /// <returns></returns>
        public bool AddIce()
        {
            Ice = true;
            NotifyPropertyChanged("Ice");          
            return Ice;
        }

        /// <summary>
        /// The constructor, set default values
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;           
        }

        public override String ToString()
        {
            if (Decaf)
            {
                return $"{size.ToString()} Decaf Jurassic Java";
            }
            else
            {
                return $"{size.ToString()} Jurassic Java";
            }
        }
    }
}
