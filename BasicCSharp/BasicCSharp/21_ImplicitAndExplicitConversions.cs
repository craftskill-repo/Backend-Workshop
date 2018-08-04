using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class ImplicitAndExplicitConversions
    {
        [Fact]
        public void should_implicitly_convert_to_target_type()
        {
            Name name = "Bill Gates";

            // please update variable value to fix the test.
            const string expectedName = "Bill Gates";

            Assert.Equal(expectedName, name.ToString());
        }

        [Fact]
        public void should_explicity_convert_to_target_type()
        {
            Name name = "Bill Gates";

            // please update variable value to fix the test.
            const string expectedName = "Bill Gates";

            Assert.Equal(expectedName, (string)name);            
        }
    }
}