using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The water class that derived from the DrinkBaseClass
    /// </summary>
    public class Water : Drink
    {       
        /// <summary>
        /// The size of the drink
        /// </summary>
        private Size size;       

        /// <summary>
        /// Gets or sets the size of the drink(all size have same price and calories)
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

                if(size == Size.Small || size == Size.Medium || size == Size.Large)
                {
                    Price = 0.10;
                    Calories = 0;
                }
            }
        }

        /// <summary>
        /// The ingredients of the drink that returns the protected field
        /// </summary>
        public override List<string> Ingredients
        {
            get {
                List<string> ingredients = new List<string>();
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                ingredients.Add("Water");
                return ingredients; }
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
                if (Lemon)
                {
                    special.Add("Add Lemon");
                }
                if (!Ice)
                {
                    special.Add("Hold Ice");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Whether the drink has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Add lemon to the drink
        /// </summary>
        /// <returns>boolean</returns>
        public bool AddLemon()
        {
            Lemon = true;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");         
            return Lemon;
        }

        /// <summary>
        /// The constructor, sets the default values
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;           
        }

        /// <summary>
        /// Override the ToString method to return the description
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return $"{size.ToString()} Water";
        }
    }
}
