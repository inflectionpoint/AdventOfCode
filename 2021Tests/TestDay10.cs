using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay10
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day10 D10 = new();
            D10.Syntaxes = DataLoader.Day10Sample();

            //Act
            long result = D10.CorruptScore;

            //Assert
            Assert.Equal(26397, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day10 D10 = new();
            D10.Syntaxes = DataLoader.Day10Sample();

            //Act
            long result = D10.IncompleteScore;

            //Assert
            Assert.Equal(288957, result);
        }
    }
}
