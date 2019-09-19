/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Veloci wrap(A chicken ceasar wrap)
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// Whether the VelociWrap has dressing
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Whether the VelociWrap has lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether the VelociWrap has cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// The price of the VelociWrap
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The calories of the VelociWrap
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients of the VelociWrap(flour tortilla, chicken breast, romaine lettuce, ceasar dressing, parmesan cheese)
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Flour Tortilla" };
                ingredients.Add("Chicken Breast");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Remove the dressing from the VelociWrap
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Remove the lettuce from the VelociWrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Remove the cheese from the VelociWrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
