using Xunit;

namespace Calculations.Tests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullName_GivenStringValues_ReturnString()
        {
            var names = new Names();
            var result = names.MakeFullName("Dat", "Mai");
            Assert.Equal("Dat Mai", result, ignoreCase: true);
            Assert.Contains(" mai", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("Dat", result,StringComparison.CurrentCultureIgnoreCase);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }
    }
}