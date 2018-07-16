using System;
using System.Globalization;
using BasicCSharp.Extensions;
using Xunit;
/**
 * 可空类型nullable
 */
namespace BasicCSharp
{
    public class NullableTypes
    {
        [Fact]
        public void should_be_clear_that_a_nullable_type_is_a_value_type()
        {
            Type nullableType = typeof(Nullable<int>);

            bool isValueType = nullableType.IsValueType;

            // change the variable value to fix the test.            
            const bool expectedIsValueType = true;

            Assert.Equal(expectedIsValueType, isValueType);
        }

        [Fact]
        public void should_use_nullable_type_in_case_you_need_null_for_value_type_anyway()
        {
            Nullable<int> nullableInt = null;

            // change the variable value to fix the test.
            const bool expectedEquals = true;

            Assert.Equal(expectedEquals, nullableInt == null);
        }

        [Fact]
        public void should_use_simplified_syntax_for_nullable_type()
        {
            int? nullableInt = null;//声明可空类型

            // change the variable value to fix the test.
            const bool expectedEquals = true;

            Assert.Equal(expectedEquals, nullableInt == null);
        }

        [Fact]
        public void should_use_has_value_to_determine_if_a_nullable_type_has_value_type_instance()
        {
            int? nullableIntWithoutValue = null;
            int? nullableIntWithValue = 2;

            bool hasValueForWithoutValue = nullableIntWithoutValue.HasValue;
            bool hasValueForWithValue = nullableIntWithValue.HasValue;

            // change the variable values for the following 2 lines to fix test.
            const bool expectedHasValueForWithoutValue = false;
            const bool expectedHasValueForWithValue = true;
            
            Assert.Equal(expectedHasValueForWithoutValue, hasValueForWithoutValue);
            Assert.Equal(expectedHasValueForWithValue, hasValueForWithValue);
        }

        [Fact]
        public void should_throw_if_you_use_value_without_checking()
        {
            int? nullableIntWithoutValue = null;

            Action useValueWithoutChecking =
                () => nullableIntWithoutValue.Value.ToString(CultureInfo.InvariantCulture);

            Exception unhandledException = useValueWithoutChecking.RunAndGetUnhandledException();

            // change the variable value to fix the test.
            Type expectedExceptionType = typeof(InvalidOperationException);

            Assert.IsType(expectedExceptionType, unhandledException);
        }

        [Fact]
        public void should_be_able_to_explicitly_cast_to_target_value_type()
        {
            int? nullableIntWithValue = 2;
            var valueForNullableInstance = (int) nullableIntWithValue;

            // change the variable value to fix the test.
            const int expectedValue = 2;

            Assert.Equal(expectedValue, valueForNullableInstance);
        }

        [Fact]
        public void should_bring_operators_for_underlaying_type()
        {
            int? larger = 5;
            int? smaller = 1;

            // change the variable value to fix the test.
            const bool expectedCompareResult = true;

            Assert.Equal(expectedCompareResult, larger > smaller);
        }

        [Fact]
        public void should_returns_false_if_one_of_the_nullable_instance_has_no_value_when_doing_operator_lifting()
        {
            // change the variable values for the following 4 lines to fix the test.
            const bool expectedResultFor5IsLargerThanNull = false;
            const bool expectedResultFor5IsSmallerThanNull = false;
            const bool expectedResultForNullIsLargerThanNull = false;

            Assert.Equal(expectedResultFor5IsLargerThanNull, (int?) 5 > (int?) null);
            Assert.Equal(expectedResultFor5IsSmallerThanNull, (int?) 5 < (int?) null);
            Assert.Equal(expectedResultForNullIsLargerThanNull, (int?) null > (int?) null);
        }

        [Fact]
        public void should_tell_equlity_for_nullable_types()
        {
            // change the variable values for the following 2 lines to fix the test.
            const bool expectedResultForNullToNull = true;
            const bool expectedResultFor5To5 = true;

            Assert.Equal(expectedResultForNullToNull, (int?) null == (int?) null);
            Assert.Equal(expectedResultFor5To5, (int?) 5 == (int?) 5);
        }
    }
}