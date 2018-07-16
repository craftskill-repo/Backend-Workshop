using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BasicCSharp.Common;
using Xunit;
/**
 * 这个测试类作用：？？？
 */
namespace BasicCSharp
{
    public class ExtensionMethod
    {
        [Fact]
        public void should_treat_first_parameter_as_this_for_extension_method()
        {
            const string message = "Hello!";
            
            string returnValue = message.OhGodItLooksAsIfIWasAMemberOfString();

            // please update variable value to fix the test.
            const string expectedReturnValue = "Hello!";

            Assert.Equal(expectedReturnValue, returnValue);
        }

        [Fact]
        public void should_extend_interface()
        {
            var numberList = new List<int> {1, 2, 3};

            IEnumerable<string> transformedResult = 
                numberList.MySelect(number => number.ToString(CultureInfo.InvariantCulture));

            // please update variable value to fix the test.
            IEnumerable<string> expectedResult = new[] {"1","2","3"};

            Assert.Equal(expectedResult, transformedResult);
        }
    }
}