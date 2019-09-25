using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{

    public class Sodasaurus : DrinkBaseClass
    {     

        private SodaSaurusFlavor flavor;
        private Size size;

        public SodaSaurusFlavor Flavor
        {
            get
            { return flavor; }
            set
            { flavor = value; }
        }

       public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if(size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
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
            Ice = true;
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flvaors");
            ingredients.Add("Cane Sugar");          
        }
    }
}
