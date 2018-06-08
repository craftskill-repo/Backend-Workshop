using System;
using System.Text;
using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class TryStatement
    {
        [Fact]
        public void should_catch_nothing_if_no_exception_is_thrown()
        {
            bool isCatchBlockCovered = false;

            try
            {
                new TryCatchDemoClass().WillNotThrowException();
            }
            catch (Exception)
            {
                isCatchBlockCovered = true;
            }

            // change the variable value to fix the test.
            const bool expectedCatchBlockCovered = true;

            Assert.Equal(expectedCatchBlockCovered, isCatchBlockCovered);
        }

        [Fact]
        public void should_catch_matched_exception()
        {
            bool isCatchBlockCovered = false;

            try
            {
                new TryCatchDemoClass().WillThrowFormatException();
            }
            catch (FormatException)
            {
                isCatchBlockCovered = true;
            }

            // change the variable value to fix the test.
            const bool expectedCatchBlockCovered = false;

            Assert.Equal(expectedCatchBlockCovered, isCatchBlockCovered);
        }

        [Fact]
        public void should_only_catch_mostly_matched_exception()
        {
            bool isFormatExceptionCatched = false;
            bool isExceptionCatched = false;

            try
            {
                new TryCatchDemoClass().WillThrowFormatException();
            }
            catch (FormatException)
            {
                isFormatExceptionCatched = true;
            }
            catch (Exception)
            {
                isExceptionCatched = true;
            }

            // change the variable values for the following 2 lines to fix the test.
            const bool expectedFormatExceptionCatched = false;
            const bool expectedExceptionCatched = true;

            Assert.Equal(expectedFormatExceptionCatched, isFormatExceptionCatched);
            Assert.Equal(expectedExceptionCatched, isExceptionCatched);
        }

        [Fact]
        public void should_find_matched_catch_clause_through_inherit_chain()
        {
            bool isCatchBlockCovered = false;

            try
            {
                new TryCatchDemoClass().WillThrowFormatException();
            }
            catch (SystemException)
            {
                isCatchBlockCovered = true;
            }

            // change the variable value to fix the test.
            const bool expectedCatchBlockCovered = false;

            Assert.Equal(expectedCatchBlockCovered, isCatchBlockCovered);
        }

        [Fact]
        public void should_throw_exception_if_no_catch_matched()
        {
            Action noCatchMatched = () =>
            {
                try
                {
                    new TryCatchDemoClass().WillThrowFormatException();
                }
                catch (ArgumentException)
                {
                }
            };

            // change the variable value to fix the test.
            Type expectedExceptionType = typeof(Exception);

            Assert.Throws(expectedExceptionType, () => noCatchMatched());
        }

        [Fact]
        public void should_run_finally_block_anyway()
        {
            var tracer = new StringBuilder();

            try
            {
                tracer.AppendLine("try block executed.");
                throw new FormatException();
            }
            catch (FormatException)
            {
                tracer.AppendLine("FormatException catched.");
            }
            finally
            {
                tracer.AppendLine("finally blocked executed.");
            }

            // change the variable value to fix the test.            
            const string expectedTracingMessage = "";

            Assert.Equal(expectedTracingMessage, tracer.ToString());
        }
    }
}