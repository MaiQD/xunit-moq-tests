namespace DataDrivenTests.Tests
{
    public class CalculationsTests
    {
        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(1);
            //Assert
            Assert.True(res);
        }

        [Fact]
        public void IsOdd_GivenEvenValue_ReturnsFalse()
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(2);
            //Assert
            Assert.False(res);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(value);
            //Assert
            Assert.Equal(expected, res);
        }
    }
}