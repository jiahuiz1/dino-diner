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
        /// <summary>
        /// The ingredients of the side
        /// </summary>
        public override List<string> Ingredients { get; }

        /// <summary>
        /// The size of the side
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// The description of the side
        /// </summary>
        public override string Description { get; }

        /// <summary>
        /// The special list of the side
        /// </summary>
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
