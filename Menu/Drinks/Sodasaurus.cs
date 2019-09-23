using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    public class Sodasaurus : DrinkBaseClass
    {
        private Size size;

        public SodasaurusFlavor Flavor { get; set; }

        public override Size Size
        {
            get { return size; }

            set
            {
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 12;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public Sodasaurus()
        {
            ingredients.Add("Water");
            ingredients.Add("Natural Flvaors");
            ingredients.Add("Cane Sugar");          
        }
    }
}
