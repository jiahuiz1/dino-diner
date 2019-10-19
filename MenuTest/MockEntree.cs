using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockEntree: Entree
    {
        public override double Price { get; set; } = 5;

        //for others properties needed to override, do i just give the default implementation
        public override List<string> Ingredients => throw new NotImplementedException();

        public override string Description => throw new NotImplementedException();

        public override string[] Special => throw new NotImplementedException();
    }
}
