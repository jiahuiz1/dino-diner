using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public abstract class EntreeBaseClass
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public virtual List<string> Ingredients { get; }
    }
}
