using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldhHaveCorrectDefaultCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.RoomForCream);
        }

        [Fact]
        public void ShouldHaveDefaultDecaf()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.Decaf);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        [Fact]
        public void ShouldInvokeAddIce()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        [Fact]
        public void ShouldInvokeLeaveRoomForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }
       

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }


    }
}
