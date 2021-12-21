using System;
using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay04
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day04 D04 = new();
            (D04.Drawings, D04.Boards) = DataLoader.D04Load(true);

            //Act
            int result = D04.ComputeFirstToWinBoard();

            //Assert
            Assert.Equal(4512, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day04 D04 = new();
            (D04.Drawings, D04.Boards) = DataLoader.D04Load(true);

            //Act
            int result = D04.ComputeLastToWinBoard();

            //Assert
            Assert.Equal(1924, result);
        }
    }
}
