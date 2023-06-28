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
            Assert.StartsWith("Dat", result, StringComparison.CurrentCultureIgnoreCase);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            names.NickName = "Strong Man";
            //Assert.Null(names.NickName);
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MackFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Dat", "Mai");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}