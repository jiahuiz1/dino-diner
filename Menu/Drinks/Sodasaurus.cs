using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The sodasaurus class derived from DrinkBaseClass
    /// </summary>
    public class Sodasaurus : DrinkBaseClass
    {     
        /// <summary>
        /// The flavor of the drink
        /// </summary>
        private SodaSaurusFlavor flavor;

        /// <summary>
        /// The size of the drink
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets the flavor or set up the flavor of the drink
        /// </summary>
        public SodaSaurusFlavor Flavor
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
            ingredients.Add("Water");
            ingredients.Add("Natural Flvaors");
            ingredients.Add("Cane Sugar");          
        }
    }
}
