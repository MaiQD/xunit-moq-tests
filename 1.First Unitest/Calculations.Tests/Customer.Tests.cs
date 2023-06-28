using Xunit;

namespace Calculations.Tests
{
    public class CustomerTest
    {
        

        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age,25,40);
        }
        [Fact]
        public void GetOrderByNameNotNull()
        {
            var customer = new Customer();
            var exception  = Assert.Throws<ArgumentException>(()=>customer.GetOrdersByName(null));
            Assert.Equal("name",exception.Message);
        }
    }
}