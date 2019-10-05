using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// The Test for the JurrasicJava
    /// </summary>
    public class JurassicJavaTest
    {
        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        //The correct default calories
        [Fact]
        public void ShouldhHaveCorrectDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        //The correct default Ice set up
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }

        //The correct default size 
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        //The correct default roomforcream set up
        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }

        //The correct default decaf
        [Fact]
        public void ShouldHaveDefaultDecaf()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Decaf);
        }

        //The correct price after setting the size to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);
        }

        //The correct price after setting the size to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);
        }

        //The correct price after setting the size to large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSizeToLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        //The correct calories after setting the size to small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        //The correct calories after setting the size to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        //The correct calories after setting the size to large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSizeToLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldInvokeAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true
        [Fact]
        public void ShouldInvokeLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }


        //The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }


    }
}
