using Xunit;

namespace Calculations.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age,25,40);
        }
    }
}