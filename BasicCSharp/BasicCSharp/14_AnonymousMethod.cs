using System;
using Xunit;

namespace BasicCSharp
{
    public class AnonymousMethod
    {
        [Fact]
        public void should_write_anonymous_inplace()
        {
            Func<int, int> doubleTransform = delegate(int x)
            {
                return x * 2;
            };

            int transformResult = doubleTransform(2);

            // change variable value to fix test.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, transformResult);
        }

        [Fact]
        public void should_write_anonymous_method_in_a_more_simple_way()
        {
            Func<int, int> doubleTransform = x => x * 2;

            int transformResult = doubleTransform(2);

            // change variable value to fix test.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, transformResult);
        }
    }
}