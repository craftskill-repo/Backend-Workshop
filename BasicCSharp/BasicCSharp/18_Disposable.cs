using System.Text;
using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class Disposable
    {
        [Fact]
        public void should_call_dispose_anyway_using_try_finally()
        {
            var tracer = new StringBuilder();
            DisposableWithTracingDemoClass demoDisposable = null;

            try
            {
                demoDisposable = new DisposableWithTracingDemoClass(tracer);
            }
            finally
            {
                if (demoDisposable != null)
                {
                    demoDisposable.Dispose();
                }
            }

            // change variable value to fix test.
            const string expectedTracingMessage = "";

            Assert.Equal(expectedTracingMessage, tracer.ToString());
        }

        [Fact]
        public void should_use_using_statement_for_simplicity()
        {
            var tracer = new StringBuilder();

            using (var demoDisposable = new DisposableWithTracingDemoClass(tracer))
            {
                // blah, blah, ...
            }

            // change the variable value to fix the test.
            const string expectedTracingMessage = "";

            Assert.Equal(expectedTracingMessage, tracer.ToString());
        }
    }
}