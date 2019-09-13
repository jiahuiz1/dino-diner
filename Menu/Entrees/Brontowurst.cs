using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Brontowurst(with peppers and onions in a bun)
/// </summary>
namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
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
        /// The price of the Brontowurst
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The calories of the Brontowurst
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients of the Brontowurst, include brautwurst, whole wheat bun, peppers and onions
        /// </summary>
        public List<string> Ingredients
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
        }

        /// <summary>
        /// The method to remove peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// The method to remove onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
