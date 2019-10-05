using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The MezzorellaSticks side(Fried Breaded Mozzarella Sticks)
    /// </summary>
    public class MezzorellaSticks : Side
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

        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;          
        }

        public override String ToString()
        {
            return $"{size.ToString()} Mezzorella Sticks";
        }
    }
}
