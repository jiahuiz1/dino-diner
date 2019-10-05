using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// The sodasaurus class derived from DrinkBaseClass
    /// </summary>
    public class Sodasaurus : Drink
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
            { flavor = value; }
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
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if(size == Size.Large)
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
        /// The construtor, set the default values
        /// </summary>
        public Sodasaurus()
        {
            Ice = true;
            Price = 1.50;
            Calories = 112;               
        }

        public override String ToString()
        {
            return $"{size.ToString()} {flavor.ToString()} Sodasaurus";
        }
    }
}
