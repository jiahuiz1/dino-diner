using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
  
    public abstract class DrinkBaseClass
    {
       

        protected List<string> ingredients = new List<string>();

        public double Price { get; set; }

        public uint Calories { get; set; }

        public virtual List<string> Ingredients { get; }

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
        }
    }
}
