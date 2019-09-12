using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class DinoNuggets
    {

        public double Price { get; set; }

        public uint Calories { get; set; }

        public string Ingredients
        {
            get
            {
                return "6 chicken nuggets";
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            Price = this.Price + 0.25;
            Calories = this.Calories + 59;
        }
    }
}
