﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "brautwurst" };
                if (bun) ingredients.Add("whole-wheat bun");
                if (peppers) ingredients.Add("peppers");
                if (onions) ingredients.Add("onions");

                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnions()
        {
            this.onions = false;
        }
    }
}
