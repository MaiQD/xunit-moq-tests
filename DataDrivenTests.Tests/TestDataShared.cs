namespace DataDrivenTests.Tests
{
    public static class TestDataShared
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
            }
        }

        public static IEnumerable<object[]> IsOddOrEvenExternalData
        {
            get
            {
                var allLines = File.ReadAllLines("IsOddOrEvenTestData.txt");
                return allLines.Select(p =>
                {
                    var line = p.Split(',');
                    return new object[] { int.Parse(line[0]), bool.Parse(line[1]) };
                });
            }
        }
    }
}