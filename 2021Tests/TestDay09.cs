using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay09
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day09 D09 = new();
            D09.HeightMap = DataLoader.Day09Sample();

            //Act
            int result = D09.ComputeRiskLevelSum();

            //Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day09 D09 = new();
            D09.HeightMap = DataLoader.Day09Sample();

            //Act
            int result = D09.ComputeBasinValue();

            //Assert
            Assert.Equal(1134, result);
        }
    }
}
