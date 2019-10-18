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
    public class SteakosaurusBurger : Entree, IOrderItem
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

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun)
                {
                    special.Add("Hold Bun");
                }
                if (!pickle)
                {
                    special.Add("Hold Pickle");
                }
                if (!ketchup)
                {
                    special.Add("Hold Ket Chup");
                }
                if (!mustard)
                {
                    special.Add("Hold Mustard");
                }
                return special.ToArray();
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
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the pickle from the Steakosaurus Burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the ketchup from the Steakosaurus Burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the mustard from the Steakosaurus Burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
