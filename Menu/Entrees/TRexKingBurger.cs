/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The T-Rex King Burger(A triple 1/2 steakburger with all the fixings)
    /// </summary>
    public class TRexKingBurger : EntreeBaseClass
    {
        /// <summary>
        /// The number of how many steakburger patties 
        /// </summary>
        private int count = 3;

        /// <summary>
        /// Whether the TRexKingBurger has bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether the TRexKingBurger has lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether the TRexKingBurger has tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Whether the TRexKingBurger has onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Whether the TRexKingBurger has pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Whether the TRexKingBurger has ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Whether the TRexKingBurger has mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Whether the TRexKingBurger has mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// The ingredients of the TRexKingBurger(three streakburger patties, a whole wheat bun, lettuce, tomato, onion, pickle, ketchup, mustard, mayo)
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < count; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }

                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Remove the bun from the TRexKingBurger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Remove the lettuce from the TRexKingBurger
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Remove the tomato from the TRexKingBurger
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Remove the onion from the TRexKingBurger
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Remove the pickle from the TRexKingBurger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Remove the ketchup from the TRexKingBurger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Remove the mustard from the TRexKingBurger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Remove the mayo from the TRexKingBurger
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
