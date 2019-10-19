/* Author: Jiahui Zhao
 * Project1: menu
 */
using System.Collections.Generic;
using System;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The PrehistoricPBJ(A peanut butter & jelly sandwich)
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Whether the PrehistoricPBJ has peanutbutter
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Whether the PrehistoricPBJ has jelly
        /// </summary>
        private bool jelly = true;
        

        /// <summary>
        /// The ingredients of the PrehistoricPBJ, include the bread, peanutbutter and jelly
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Remove the peanutbutter from the PrehistoricPBJ
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the jelly from the PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets the list of special items
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter)
                {
                    special.Add("Hold Peanut Butter");
                }
                if (!jelly)
                {
                    special.Add("Hold Jelly");
                }
                return special.ToArray();
            }
        }

        public override String ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
