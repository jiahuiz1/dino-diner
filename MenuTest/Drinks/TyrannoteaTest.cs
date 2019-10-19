using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// The Test for the Tyrannotea
    /// </summary>
    public class TyrannoteaTest
    {

        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        //The correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        //The correct default Ice set up
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        //The correct default size
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        //The correct default lemon set up
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        //The correct default sweet set up
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        //The correct price after setting the size to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        //The correct price after setting the size to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        //The correct price after setting the size to large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        //The correct calories after setting the size to small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        //The correct calories after setting the size to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        //The correct calories after setting the size to large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldInvokeHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true
        [Fact]
        public void ShouldInvokeAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        //The correct calories after setting the size to small and sweet to true
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }

        //The correct calories after setting the size to medium and sweet to true
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //The correct calories after setting the size to large and sweet to true
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }


        //The correct calories after setting sweet to true and then set it back to false for the small size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetBackForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        ////The correct calories after setting sweet to true and then set it back to false for the medium size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetBackForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        ////The correct calories after setting sweet to true and then set it back to false for the large size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetBackForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //The correct ingrediens are given
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            tea.AddLemon();
            tea.Sweet = true;
            if (tea.Lemon)
            {
                Assert.Contains<string>("Lemon", tea.Ingredients);
            }
            if (tea.Sweet)
            {
                Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            }
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceAndAddLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special, 
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
                );
        }

        [Fact]
        public void HoldingIceShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }

        [Fact]
        public void AddingLemonShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }

        [Fact]
        public void ChangingSweetShouldNotifyDescriptionChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Sweet = true;
            });
        }



        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifySizeChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyPriceChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyDescriptionChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Size = size;
            });
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal($"{tea.Size.ToString()} Tyrannotea", tea.Description);
        }
        [Fact]
        public void SweetDescriptionShouldBeCorrect()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            if (tea.Sweet)
            {
                Assert.Equal($"{tea.Size.ToString()} Sweet Tyrannotea", tea.Description);
            }

        }
    }
    
}
