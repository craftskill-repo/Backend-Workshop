using BasicCSharp.Common;
using BasicCSharp.Extensions;
using Xunit;

namespace BasicCSharp
{
    public class Interfaces
    {
        /**
         * 接口调用
         */
        [Fact]
        public void should_implement_more_than_one_interface()
        {
            var duck = new Duck();
            var castToMoveable = (IMoveable) duck;
            var castToTalkable = (ITalkable) duck;

            castToMoveable.MoveTo(2, 3);

            string duckPosition = duck.WhereAmI;
            string duckTalk = castToTalkable.Talk();

            // change the variable values for the following 2 lines to fix the test.
            const string expectedDuckPosition = "You are at (2, 3)";
            const string expectedTalk = "Ga, ga, ...";

            Assert.Equal(expectedDuckPosition, duckPosition);
            Assert.Equal(expectedTalk, duckTalk);
        }
    /**
     * ???
     */
        [Fact]
        public void should_use_explict_interface_impl_if_you_want_to_hide_something_for_certain_type()
        {
            var readOnlyStreamWithWriteExplicitlyImpl = new ReadOnlyStream();
            
            var hasWriteMethod = readOnlyStreamWithWriteExplicitlyImpl.HasInstanceMethod(
                "Write",
                new[] {typeof(string)});

            // change the variable value to fix the test.
            const bool expectedHasWriteMethod = false;

            Assert.Equal(expectedHasWriteMethod, hasWriteMethod);
        }

        [Fact]
        public void should_invoke_explicitly_implemented_method_by_original_interface()
        {
            var readOnlyStreamWithWriteExplicitlyImpl = new ReadOnlyStream();
            var castedToInterface = (ITextStream) readOnlyStreamWithWriteExplicitlyImpl;

            castedToInterface.Write("Hehe");
            var readResult = readOnlyStreamWithWriteExplicitlyImpl.Read();

            // change the variable value to fix the test.
            const string expectedReadResult = "Hehe";

            Assert.Equal(expectedReadResult, readResult);
        }
    }
}