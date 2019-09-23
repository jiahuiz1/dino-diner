using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : DrinkBaseClass
    {
        private Size size;

        public bool Sweet { get; set; }

        public bool Lemon { get; set; }

        public override Size Size
        {
            get { return size; }

            set
            {
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        if (Sweet)
                        {
                            Calories = 2 * Calories;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet)
                        {
                            Calories = 2 * Calories;
                        }
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet)
                        {
                            Calories = 2 * Calories;
                        }
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

        public bool AddLemon()
        {
            Lemon = true;
            return Lemon;
        }

        public Tyrannotea()
        {
            Sweet = false;
            Lemon = false;
            ingredients.Add("Water");
            ingredients.Add("Tea");
            if (Lemon)
            {
                ingredients.Add("Lemon");
            }
            if (Sweet)
            {
                ingredients.Add("Cane Sugar");
            }
        }
    }
}
