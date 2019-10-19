using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockDrink : Drink
    {
        //Should I create the Mock class for the base class like drink and give it a possible number for price or I should create Mock class for every drink
        public override double Price { get; set; } = 2;

        public override string Description => throw new NotImplementedException();

        public override string[] Special => throw new NotImplementedException();
    }
}
