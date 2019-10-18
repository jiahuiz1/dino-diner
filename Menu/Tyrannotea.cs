using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// The tyrannotea class that derived from the DrinkBaseClass
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        private Size size;

        /// <summary>
        /// Whether the drink is sweet
        /// </summary>
        private bool sweet = false;
       
        /// <summary>
        /// Gets or sets the sweet of the drink
        /// </summary>
        public bool Sweet {
            get { return sweet; }
            set
            {
                sweet = value;               
            }
        }

        /// <summary>
        /// Whether the drink has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

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
                    Price = 0.99;
                    Calories = 8;
                    if (Sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
               else if(size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                    if (Sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
               else if(size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    if (Sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
            }
        }

        /// <summary>
        /// The ingredients of the drink that returns the protected field
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                if (sweet == true)
                {

                    ingredients.Add("Cane Sugar");
                }
                ingredients.Add("Water");
                ingredients.Add("Tea");
                return ingredients;
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
                if (Lemon)
                {
                    special.Add("Add Lemon");
                }
                return special.ToArray();
            }
        }

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
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            Ice = true;                                   
        }

        public override String ToString()
        {
            if (sweet)
            {
                return $"{size.ToString()} Sweet Tyrannotea";
            }
            else
            {
                return $"{size.ToString()} Tyrannotea";
            }
        }
    }
}
