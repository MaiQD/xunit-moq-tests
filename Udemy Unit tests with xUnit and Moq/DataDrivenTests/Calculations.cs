namespace DataDrivenTests
{
    public class Calculations
    {
        public List<int> FiboNumbers => new() { 1, 1, 2, 3, 5, 8, 13, 21 };

        public bool IsOdd(int value) => value % 2 == 1;
    }
}