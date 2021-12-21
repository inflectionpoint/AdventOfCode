using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay02
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day02 D02 = new();
            D02.Movements = DataLoader.D02Sample();

            //Act
            int result = D02.ComputeMovementSimple();

            //Assert
            Assert.Equal(150, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day02 D02 = new();
            D02.Movements = DataLoader.D02Sample();

            //Act
            int result = D02.ComputeMovementComplex();

            //Assert
            Assert.Equal(900, result);
        }
    }
}
