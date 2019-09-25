using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava: DrinkBaseClass
    {
        private Size size;

        public override Size Size
        {
            get { return size; }
            set
            {
                if(size == Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                }
                else if(size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                else if(size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        public override List<string> Ingredients
        {
            get { return ingredients; }
        }

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        public bool LeaveRoomForCream()
        {
            RoomForCream = true;
            return RoomForCream;
        }

        public bool AddIce()
        {
            Ice = true;
            return Ice;
        }

        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
    }
}
