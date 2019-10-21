/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The DinoNuggets(six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets : Entree, IOrderItem
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
        /// Gets the description
        /// </summary>
        public override string Description
        {
            get
            {
                return ToString();
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
                int temp = count;
                if(temp - 6 > 0)
                {
                    special.Add(temp-6 + " Extra Nuggets");                  
                }
                return special.ToArray();
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
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Override the ToString method to return the description
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
