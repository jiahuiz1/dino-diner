using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The PrehistoricPBJ(A peanut butter & jelly sandwich)
    /// </summary>
    public class PrehistoricPBJ
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
        /// The price of the PrehistoricPBJ
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The calories of the PrehistoricPBJ
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients of the PrehistoricPBJ, include the bread, peanutbutter and jelly
        /// </summary>
        public List<string> Ingredients
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
        }

        /// <summary>
        /// Remove the jelly from the PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
