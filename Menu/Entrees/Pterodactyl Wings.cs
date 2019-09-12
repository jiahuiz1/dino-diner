﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class PterodactylWings
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken and Wing Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}