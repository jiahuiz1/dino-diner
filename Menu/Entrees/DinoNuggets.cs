/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The DinoNuggets(six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets : EntreeBaseClass
    {
        /// <summary>
        /// The number of how many chicken nuggets in the entree
        /// </summary>
        private int count = 6;


        /// <summary>
        /// The ingredients of the DinoNuggets(only chicken nugget)
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories of the DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Add an additional chicken nugget, also update the price and calories
        /// </summary>
        public void AddNugget()
        {
            count += 1;
            Price = this.Price + 0.25;
            Calories = this.Calories + 59;
        }
    }
}
