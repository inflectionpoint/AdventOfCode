using System;
using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay05
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day05 D05 = new(true);

            //Act
            int result = D05.ComputeIntersections(false);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day05 D05 = new(true);

            //Act
            int result = D05.ComputeIntersections(true);

            //Assert
            Assert.Equal(12, result);
        }
    }
}
