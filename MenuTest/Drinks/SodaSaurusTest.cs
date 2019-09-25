using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
        //The [Fact] means to tell the TestExplorer, this code is a test 
        //The ability tot set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.Cherry;
            //check if the expected value is euqal to the actual value, first one is expectd value, second is actual value, <SodaSaurusFlavor> is the type of the two value(if it is not this type, automatically cast it to this type)
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.Cola;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.Orange;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.Vanilla;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.Chocolate;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBear()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.RootBeer;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodaSaurusFlavor.Lime;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Lime, soda.Flavor);
        }
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        //The correct price and calories after changing to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        
        //The correct price and calories after changing to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        //The correct price and calories after changing to Large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }


        //That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        //That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldInvokeHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
    }
}
