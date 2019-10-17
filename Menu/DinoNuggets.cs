/* Author: Jiahui Zhao
 * Project1: menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The DinoNuggets(six crispy fried breaded chicken nuggets)
    /// </summary>
    public class DinoNuggets : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The number of how many chicken nuggets in the entree
        /// </summary>
        private int count = 6;

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// The ingredients of the DinoNuggets(only chicken nugget)
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public override string Description
        {
            get
            {
                return ToString();
            }
        }

        //check
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                int i = count;
                while(i - 6 > 0)
                {
                    special.Add("Chicken Nugget");
                    i--;
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// The constructor that initializes the price and calories of the DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Add an additional chicken nugget, also update the price and calories
        /// </summary>
        public void AddNugget()
        {
            count += 1;
            Price = this.Price + 0.25;
            Calories = this.Calories + 59;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public override String ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
