using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The MeteorMacAndCheese side(Macaroni and Cheese with Sausages)
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// The size of MeteorMacAndCheese
        /// </summary>
        private Size size;

        /// <summary>
        /// Determine the size of the MeteorMacAndCheese and set the price and calories, and also gets the size
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the ingredients of the MeteorMacAndCheeese
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
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");
        }
    }
}
