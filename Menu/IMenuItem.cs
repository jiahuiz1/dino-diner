using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface that contains the Price, Calories and Ingredients properties
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// The Price property
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The Calories property
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The Ingredients property that returns a List of string
        /// </summary>
        List<string> Ingredients { get; }
    }
}
