using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class CustomerDetailsTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            
            Assert.Equal("Dat Mai", _customerFixture.Cust.GetFullName("Dat", "Mai"));
        }
    }
}