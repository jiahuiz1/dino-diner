using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The PterodactylWings(Chicken wings glazed with a signature hot sauce)
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// The price of the PterodactylWings
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// /The calories of the PterodactylWings
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients of the PterodactylWings, include chicken and wing sauce
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
