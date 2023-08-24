using Xunit;

namespace Calculations.Tests
{
    [Collection("Customer")]
    public class CustomerTest
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = _customerFixture.Cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrderByNameNotNull()
        {
            var customer = _customerFixture.Cust;
            var exception = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal("name", exception.Message);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
            Assert.Equal(101, loyalCustomer.GetOrdersByName(null));
        }
    }
}