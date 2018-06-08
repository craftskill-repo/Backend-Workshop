using System;
using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class DelegatesRelated
    {
        private static int EquivalentTransformation(int x)
        {
            return x;
        }

        private static int DoubleTransformation(int x)
        {
            return x * 2;
        }

        private static int PassingDelegateAsArgument(TransformerDelegateDemo transformer)
        {
            return transformer(2) + 1;
        }

        [Fact]
        public void delegate_is_a_type_wrapping_method_call()
        {
            TransformerDelegateDemo transformer = EquivalentTransformation;

            // change variable value to fix test.
            const string expectedDelegateType = "";

            Assert.Equal(expectedDelegateType, typeof(TransformerDelegateDemo).Name);
            Assert.True(transformer is Delegate);
        }

        [Fact]
        public void should_call_original_method_when_invoking_delegate()
        {
            TransformerDelegateDemo transformer = EquivalentTransformation;

            int transformResult = transformer(2);

            // change variable value to fix test.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, transformResult);
        }

        [Fact]
        public void should_pass_delegate_instance_as_normal_variable()
        {
            TransformerDelegateDemo transformer = DoubleTransformation;

            int actualResult = PassingDelegateAsArgument(transformer);

            // change variable value to fix test.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void should_multicast_delegate()
        {
            var demoObject = new MulticastDelegateDemoClass();

            Action theDelegate = demoObject.OneMethod;
            theDelegate += demoObject.AnotherMethod;

            theDelegate();

            // change variable value to fix test.
            var expectedTrace = new string[] {};

            Assert.Equal(expectedTrace, demoObject.Trace);
        }

        [Fact]
        public void should_unbind_multicast_delegate()
        {
            var demoObject = new MulticastDelegateDemoClass();

            Action theDelegate = demoObject.OneMethod;
            theDelegate += demoObject.AnotherMethod;
            theDelegate -= demoObject.OneMethod;

            theDelegate();

            // change variable value to fix test.
            var expectedTrace = new string[] { };

            Assert.Equal(expectedTrace, demoObject.Trace);
        }

        [Fact]
        public void should_be_immutable_and_create_new_delegate_on_substraction_change()
        {
            var demoObject = new MulticastDelegateDemoClass();

            Action theDelegate = demoObject.OneMethod;
            Action copy = theDelegate;

            theDelegate += demoObject.AnotherMethod;

            // change variable value to fix test.
            const bool areReferenceEqual = true;

            Assert.Equal(areReferenceEqual, ReferenceEquals(theDelegate, copy));
        }

        [Fact]
        public void should_be_list_subtraction_rather_than_scalar_substraction()
        {
            var demoObject = new DelegateSubtractionDemoClass();

            Action a = demoObject.A;
            Action b = demoObject.B;
            Action c = demoObject.C;

            ((a + b + c) - (a + c))();

            // change variable value to fix test.
            const string expectedOutput = "B";

            Assert.Equal(expectedOutput, demoObject.ToString());
        }

        [Fact]
        public void should_get_result_of_last_called_function()
        {
            var demoObject = new MulticastFuncDelegateDemoClass();

            Func<int> returnsOne = demoObject.ReturnsOne;
            Func<int> returnsTwo = demoObject.ReturnsTwo;
            Func<int> returnsThree = demoObject.ReturnsThree;

            int returnedResult = (returnsOne + returnsThree + returnsTwo)();

            // change variable value to fix test.
            const int expectedResult = 6;

            Assert.Equal(expectedResult, returnedResult);
        }

        [Fact]
        public void should_be_return_type_covariance()
        {
            var demoObject = new DelegateTypeVarianceDemoClass();

            Func<object> delegateReturnsObject = demoObject.ReturnsMoreSpecificType;

            object returnedValue = delegateReturnsObject();

            // change variable value to fix test.
            object expectedValue = null;

            Assert.Equal(expectedValue, returnedValue);
        }

        [Fact]
        public void should_be_parameter_contravariance()
        {
            var demoObject = new DelegateTypeVarianceDemoClass();

            Func<object, string> delegateAcceptsObject = demoObject.InputMoreGeneralType;
            Func<string, string> delegateAcceptsString = delegateAcceptsObject;

            string returnedValue = delegateAcceptsString("Good");

            // change variable value to fix test.
            const string expectedValue = "";

            Assert.Equal(expectedValue, returnedValue);
        }
    }
}