using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderClassTest
    {
        //how to use mock classes to test, like this?
        [Fact]
        public void SubTotalCostShouldBeCorrect()
        {
            Order order = new Order();
            MockDrink md = new MockDrink();
            MockEntree me = new MockEntree();
            MockSide ms = new MockSide();
            order.Items
        }

        //how to check the negative case for subtotal, give it a negative price?
    }
}
