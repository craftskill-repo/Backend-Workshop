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
            DisposableWithTracingDemoClass demoDisposable = null;

            try
            {
                demoDisposable = new DisposableWithTracingDemoClass();
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

            Assert.Equal(expectedTracingMessage, demoDisposable.TracerContent());
        }

        [Fact]
        public void should_use_using_statement_for_simplicity()
        {
            var tracerContent = "nothing";
            using (var demoDisposable = new DisposableWithTracingDemoClass())
            {
                tracerContent = demoDisposable.TracerContent();
            }

            // change the variable value to fix the test.
            const string expectedTracingMessage = "";

            Assert.Equal(expectedTracingMessage, tracerContent);
        }
    }
}