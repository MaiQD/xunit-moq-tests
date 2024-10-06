using System.Reflection;
using Xunit.Sdk;

namespace DataDrivenTests.Tests
{
    public class IsOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, true };
            yield return new object[] { 200, false };
            yield return new object[] { 9992, false };
        }
    }
}