namespace Calculations
{
    public class Customer
    {
        public int Age => 25;

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public virtual int GetOrdersByName(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }
            return 100;
        }
    }

    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }

        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string? name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            return orderCount < 100 ? new Customer() : new LoyalCustomer();
        }
    }
}