using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "three steakburger patties" };
                if (bun) ingredients.Add("whole wheat bun");
                if (lettuce) ingredients.Add("lettuce");
                if (tomato) ingredients.Add("tomato");
                if (onion) ingredients.Add("onion");
                if (pickle) ingredients.Add("pickle");
                if (ketchup) ingredients.Add("ketchup");
                if (mustard) ingredients.Add("mustard");
                if (mayo) ingredients.Add("mayo");
                return ingredients;
            }
        }
    }
}
