using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay06
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day06 D06 = new();
            D06.FishAges = DataLoader.Day06Sample();

            //Act
            long result = D06.SimulatePopulation(80);

            //Assert
            Assert.Equal(5934, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day06 D06 = new();
            D06.FishAges = DataLoader.Day06Sample();

            //Act
            long result = D06.SimulatePopulation(256);

            //Assert
            Assert.Equal(26984457539, result);
        }
    }
}
