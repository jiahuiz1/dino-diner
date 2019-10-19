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


        [Fact]
        public void LeaveRooomForCreamShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void AddIceForShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamAndAddIceShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            jj.AddIce();
            Assert.Collection<string>(jj.Special,
            item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            },
            item =>
            {
                Assert.Equal("Add Ice", item);
            }
            );
        }

        [Fact]
        public void LeavingRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.LeaveRoomForCream();
            });
        }

        [Fact]
        public void AddingIceShouldNotifySpecialChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.AddIce();
            });
        }

        [Fact]
        public void ChangingDecafShouldNotifyDescriptionChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Decaf = true;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySizeChange(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Size", () =>
            {
                jj.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyPriceChange(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Price", () =>
            {
                jj.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyDescriptionChange(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Size = size;
            });
        }

        [Fact]
        public void DescriptonShouldBeCorrect()
        {
            JurassicJava jj = new JurassicJava();           
            Assert.Equal($"{jj.Size.ToString()} Jurassic Java", jj.Description);
        }

        [Fact]
        public void DecafDescriptionShouldBeCorrect()
        {
            JurassicJava jj = new JurassicJava();
            jj.Decaf = true;
            if (jj.Decaf)
            {
                Assert.Equal($"{jj.Size.ToString()} Decaf Jurassic Java", jj.Description);
            }
        }

    }
}
