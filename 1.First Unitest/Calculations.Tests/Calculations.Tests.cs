using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class CalculationFixture : IDisposable
    {
        public Calculations Calc => new();

        public void Dispose()
        {
            //Clean
        }
    }

    public class CalculationsTest : IClassFixture<CalculationFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculationFixture _calculationFixture;
        private readonly MemoryStream _memoryStream;

        public CalculationsTest(ITestOutputHelper testOutputHelper, CalculationFixture calculationFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculationFixture = calculationFixture;

            _testOutputHelper.WriteLine("Construction");
            _memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
            var calc = _calculationFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            _testOutputHelper.WriteLine("FiboInclude13");
            var calc = _calculationFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            _testOutputHelper.WriteLine("FiboDoesNotInclude4");
            var calc = _calculationFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void Fibo_CheckCollection()
        {
            _testOutputHelper.WriteLine("Fibo_CheckCollection");
            var expetedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
            var calc = _calculationFixture.Calc;
            Assert.Equal(expetedCollection, calc.FiboNumbers);
        }
    }
}