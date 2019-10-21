using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// The MockEntree class added to the order
    /// </summary>
    public class MockEntree: Entree
    {    
        
        /// <summary>
        /// The ingredients of the entree
        /// </summary>
        public override List<string> Ingredients { get; }

        /// <summary>
        /// The description of the entree
        /// </summary>
        public override string Description { get; }

        /// <summary>
        /// The special list of the entree
        /// </summary>
        public override string[] Special { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">the price of the entree</param>
        public MockEntree(double value)
        {
            this.Price = value;
        }
    }
}
