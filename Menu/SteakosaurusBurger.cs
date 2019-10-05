/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Steakosaurus Burger(A 1/2 pound steakburger)
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Whether the Steakosaurus Burger has bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Wheter the Steakosaurus Burger has pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Whether the Steakosaurus Burger has ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Whether the Steakosaurus Burger has mustard
        /// </summary>
        private bool mustard = true;


        /// <summary>
        /// The ingredients of the Steakosaurus Burger(StreakBurger pattie, whole wheat bun, pickle, ketchup, mustard)
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");             
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");

                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Remove the bun from the Steakosaurus Burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Remove the pickle from the Steakosaurus Burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Remove the ketchup from the Steakosaurus Burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Remove the mustard from the Steakosaurus Burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
