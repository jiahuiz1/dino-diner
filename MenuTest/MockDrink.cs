using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// Mock Drink class added to the order
    /// </summary>
    public class MockDrink : Drink
    {

        /// <summary>
        /// The description of the drink
        /// </summary>
        public override string Description { get; }

        public override string[] Special { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">price of the drink</param>
        public MockDrink(double value)
        {
            this.Price = value;
        }
    }
}
