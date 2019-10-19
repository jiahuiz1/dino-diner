using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// The MockSide class added to the order
    /// </summary>
    public class MockSide : Side
    {

        public override List<string> Ingredients { get; }

        public override Size Size { get; set; }

        public override string Description { get; }

        public override string[] Special { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">price of the side</param>
        public MockSide(double value)
        {
            this.Price = value;
        }
    }
}
