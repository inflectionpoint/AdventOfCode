using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay03
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day03 D03 = new();
            D03.Diagnostics = DataLoader.D03Sample();

            //Act
            D03.ComputePowerConsumption();
            int result = D03.PowerConsumption;

            //Assert
            Assert.Equal(198, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day03 D03 = new();
            D03.Diagnostics = DataLoader.D03Sample();

            //Act
            D03.ComputeLifeSupportRating();
            int result = D03.LifeSupportRating;

            //Assert
            Assert.Equal(230, result);
        }
    }
}
