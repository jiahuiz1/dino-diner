/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Veloci wrap(A chicken ceasar wrap)
    /// </summary>
    public class VelociWrap : Entree
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
        /// The ingredients of the VelociWrap(flour tortilla, chicken breast, romaine lettuce, ceasar dressing, parmesan cheese)
        /// </summary>
        public override List<string> Ingredients
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
                if (!dressing)
                {
                    special.Add("Hold Dressing");
                }
                if (!lettuce)
                {
                    special.Add("Hold Lettuce");
                }
                if (!cheese)
                {
                    special.Add("Hold Cheese");
                }
                return special.ToArray();
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
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the lettuce from the VelociWrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the cheese from the VelociWrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
