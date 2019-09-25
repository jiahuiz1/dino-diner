using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : DrinkBaseClass
    {
        private Size size;

        public override Size Size
        {
            get { return size; }
            set
            {
                if(size == Size.Small || size == Size.Medium || size == Size.Large)
                {
                    Price = 0.10;
                    Calories = 0;
                }
            }
        }

        public override List<string> Ingredients
        {
            get { return ingredients; }
        }

        public bool Lemon { get; set; } = false;

        public bool AddLemon()
        {
            Lemon = true;
            return Lemon;
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;
            ingredients.Add("Water");
            if (Lemon)
            {
                ingredients.Add("Lemon");
            }
        }
    }
}
