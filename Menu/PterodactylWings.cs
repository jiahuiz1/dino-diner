﻿/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The PterodactylWings(Chicken wings glazed with a signature hot sauce)
    /// </summary>
    public class PterodactylWings : Entree, IOrderItem
    {
        
        /// <summary>
        /// The ingredients of the PterodactylWings, include chicken and wing sauce
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken" };
                ingredients.Add("Wing Sauce");
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
                return special.ToArray();
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

        public override String ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
