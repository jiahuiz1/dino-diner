using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// The Fryceritops side(French Fries) 
    /// </summary>
    public class Fryceritops : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The size of the Fryceritops
        /// </summary>
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Determine the size of the Fryceritops and set its price and calories, and also gets the size
        /// </summary>
        public override Size Size
        {
            get { return size; }

            set
            {
                size = value;
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the ingredients of the Fryceritops
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> _ingredients = new List<string>();
                _ingredients.Add("Potato");
                _ingredients.Add("Salt");
                _ingredients.Add("Vegetable Oil");
                return _ingredients;
            }
        }

        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        /// <summary>
        /// The constructor that sets the default price, calories and ingredients
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
        }

        public override String ToString()
        {
            return $"{size.ToString()} Friceritops";
        }
    }
}
