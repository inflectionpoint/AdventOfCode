using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay07
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day07 D07 = new();
            D07.HorizontalPositions = DataLoader.Day07Sample();

            //Act
            int result = D07.ComputeFuelConsumptionConst();

            //Assert
            Assert.Equal(37, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day07 D07 = new();
            D07.HorizontalPositions = DataLoader.Day07Sample();

            //Act
            int result = D07.ComputeFuelConsumptionLinear();

            //Assert
            Assert.Equal(168, result);
        }
    }
}
