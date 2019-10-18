using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The MeteorMacAndCheese side(Macaroni and Cheese with Sausages)
    /// </summary>
    public class MeteorMacAndCheese : Side, IOrderItem
    {
        /// <summary>
        /// The size of MeteorMacAndCheese
        /// </summary>
        private Size size;
      

        /// <summary>
        /// Determine the size of the MeteorMacAndCheese and set the price and calories, and also gets the size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Description");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the ingredients of the MeteorMacAndCheeese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
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
        /// The constructor that sets the default price, calories and ingredients
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;            
        }

        public override String ToString()
        {
            return $"{size.ToString()} Meteor Mac and Cheese";
        }
    }
}
