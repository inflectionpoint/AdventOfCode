using System;
using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay01
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day01 D01 = new();
            D01.Soundings = DataLoader.D01Sample();

            //Act
            int result = D01.ComputeCountIncreaseSimple();

            //Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day01 D01 = new();
            D01.Soundings = DataLoader.D01Sample();

            //Act
            int result = D01.ComputeCountIncreaseWindow();

            //Assert
            Assert.Equal(5, result);
        }
    }
}
