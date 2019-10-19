/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Brontowurst(with peppers and onions in a bun)
/// </summary>
namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, IOrderItem
    {
        /// <summary>
        /// Whether the Brontowurst has a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether the Brontowurst has peppers
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Whether the Brontowurst has onions
        /// </summary>
        private bool onions = true;
      

        /// <summary>
        /// The ingredients of the Brontowurst, include brautwurst, whole wheat bun, peppers and onions
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");

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
                if (!bun)
                {
                    special.Add("Hold Bun");
                }
                if (!peppers)
                {
                    special.Add("Hold Peppers");
                }
                if (!onions)
                {
                    special.Add("Hold Onion");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// The method to remove the bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// The method to remove peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// The method to remove onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public override String ToString()
        {
            return "Brontowurst";
        }
    }
}
