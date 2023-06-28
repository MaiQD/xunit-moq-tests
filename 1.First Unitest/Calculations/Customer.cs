namespace Calculations
{
    public class Customer
    {
        public int Age => 25;

        public int GetOrdersByName(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }
            return 100;
        }
    }
}