using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockSide: Side
    {
        public override double Price { get; set; } = 4;

        public override List<string> Ingredients => throw new NotImplementedException();

        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Description => throw new NotImplementedException();

        public override string[] Special => throw new NotImplementedException();
    }
}
