using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size{
        Small,
        Medium,
        Large
    }
    public abstract class DrinkBaseClass
    {
        private Size size = Size.Small;
        private bool ice = false;

        protected List<string> ingredients = new List<string>();

        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public virtual Size Size { get; set; }

        public bool Ice { get; set; }

        public bool HoldIce()
        {
            Ice = false;
            return Ice;
        }

        //is this true to use a constructor to set up the default value
        public DrinkBaseClass()
        {
            Size = Size.Small;
            Ice = false;
        }
    }
}
