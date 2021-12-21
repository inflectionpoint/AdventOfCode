using Xunit;
using Y2021;

namespace TestSampleData
{
    public class TestDay08
    {
        [Fact]
        public void ValidatePartA()
        {
            //Arrange
            Day08 D08 = new();
            (D08.InputSignals, D08.OutputSignals) = DataLoader.Day08Load(true);

            //Act
            int result = D08.CountOutputDigits();

            //Assert
            Assert.Equal(26, result);
        }

        [Fact]
        public void ValidatePartB()
        {
            //Arrange
            Day08 D08 = new();
            (D08.InputSignals, D08.OutputSignals) = DataLoader.Day08Load(true);

            //Act
            int result = D08.SumDecodedOutputs();

            //Assert
            Assert.Equal(61229, result);
        }
    }
}
