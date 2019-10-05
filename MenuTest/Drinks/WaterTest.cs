using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// The Test for the Water class
    /// </summary>
    public class WaterTest
    {
        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        //The correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<double>(0, w.Calories);
        }

        //The correct default Ice set up 
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        //The correct default size
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        //The correct default lemon set up
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        //The correct price after setting the size to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
        }

        //The correct price after setting the size to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
        }


        //The correct price after setting the size to large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
        }

        //The correct calories after setting the size to small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        //The correct calories after setting the size to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        //The correct calories after setting the size to large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldInvokeHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true
        [Fact]
        public void ShouldInvokeAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        //The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            w.AddLemon();

            if (w.Lemon)
            {
                Assert.Contains<string>("Lemon", w.Ingredients);
            }
        }

    }
}
