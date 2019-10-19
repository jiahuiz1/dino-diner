using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// User order MenuItme, should provide a Price property, a Description property, a Special property
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Get the price of the MenuItem
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Get the description of the MenuItem
        /// </summary>
        string Description { get; }


        /// <summary>
        /// Get the special instructions of the MenuItem
        /// </summary>
        string[] Special { get; }
    }
}
