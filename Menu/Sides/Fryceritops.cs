using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The Fryceritops side(French Fries) 
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// The size of the Fryceritops
        /// </summary>
        private Size size;

        /// <summary>
        /// Determine the size of the Fryceritops and set its price and calories, and also gets the size
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the ingredients of the Fryceritops
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
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }
    }
}
