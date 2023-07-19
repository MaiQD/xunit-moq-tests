using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    public class CalculationsTest
    {
        [Fact]
        [Trait("Category","Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Calculations();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0,n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            var calc = new Calculations();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var calc = new Calculations();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void Fibo_CheckCollection()
        {
            var expetedCollection = new List<int> {1, 1, 2, 3, 5, 8, 13, 21};
            var calc = new Calculations();
            Assert.Equal(expetedCollection, calc.FiboNumbers);
        }
    }
}
