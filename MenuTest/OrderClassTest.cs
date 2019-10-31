using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderClassTest
    {     
        [Fact]
        public void SubTotalCostShouldBeCorrect()
        {
            Order order = new Order();
            MockDrink md = new MockDrink(5);
            MockEntree me = new MockEntree(2.5);
            MockSide ms = new MockSide(2.5);         
            order.Add(md);
            order.Add(me);
            order.Add(ms);
            Assert.Equal<double>(10, order.SubtotalCost);
        }


        [Fact]
        public void SubTotalShouldNeverBeNegative()
        {
            Order order = new Order();
            MockDrink md = new MockDrink(-69);
            MockEntree me = new MockEntree(-5);
            MockSide ms = new MockSide(1);         
            order.Add(md);
            order.Add(me);
            order.Add(ms);
            Assert.Equal<double>(0, order.SubtotalCost);
        }

        [Fact]
        public void SalesTaxCostShouldBeCorrect()
        {
            Order order = new Order();
            MockDrink md = new MockDrink(8.5);
            MockEntree me = new MockEntree(0.5);
            MockSide ms = new MockSide(1);
            order.Add(md);
            order.Add(me);
            order.Add(ms);
            double salesTaxCost = order.SalesTaxRate * 10;
            Assert.Equal<double>(salesTaxCost, order.SalesTaxCost);
        }

        [Fact]
        public void TotalCostShouldBeCorrect()
        {
            Order order = new Order();
            MockDrink md = new MockDrink(8);
            MockEntree me = new MockEntree(1);
            MockSide ms = new MockSide(1);
            order.Add(md);
            order.Add(me);
            order.Add(ms);
            double salesTaxCost = order.SalesTaxRate * 10;
            double total = salesTaxCost + 10;
            Assert.Equal<double>(total, order.TotalCost);
        }
    }
}
