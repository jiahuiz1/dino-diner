using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : DrinkBaseClass
    {
        private Size size;

        public bool Sweet { get; set; } = false;

        public bool Lemon { get; set; } = false;

        public override Size Size
        {
            get { return size; }

            set
            {
               if(size == Size.Small)
                {
                    Price = 0.99;
                    Calories = 8;
                    if (Sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
               else if(size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                    if (Sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
               else if(size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    if (Sweet)
                    {
                        Calories = Calories * 2;
                    }
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
            Price = 0.99;
            Calories = 8;
            Ice = true;          
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
