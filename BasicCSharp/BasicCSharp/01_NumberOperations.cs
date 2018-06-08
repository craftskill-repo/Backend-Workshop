using System;
using Xunit;

namespace BasicCSharp
{
    public class NumberOperations
    {
        [Fact]
        public void should_get_minimum_value_of_a_number_type()
        {
            // change "default(sbyte)" to correct value. You should not explicitly write -128.
            //sbyte minimum = default(sbyte);
            sbyte minimum = sbyte.MinValue;

            Assert.Equal(-128, minimum);
        }

        [Fact]
        public void should_get_maximum_value_of_a_number_type()
        {
            // change "default(int)" to correct value. You should not explicitly write 2147483647.
            int maximum = default(int);

            Assert.Equal(2147483647, maximum);
        }

        [Fact]
        public void should_get_correct_type_for_floating_point_number_without_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(string);

            Assert.Equal(guessTheType, 1.0.GetType());
            Assert.Equal(guessTheType, 1E3.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_integer_without_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(string);

            Assert.Equal(guessTheType, 1.GetType());
            Assert.Equal(guessTheType, 0x123.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_M_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(string);

            Assert.Equal(guessTheType, 1M.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_L_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(string);

            Assert.Equal(guessTheType, 5L.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_F_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(string);

            Assert.Equal(guessTheType, 5F.GetType());
        }

        [Fact]
        public void should_cast_between_numeric_types()
        {
            int originNumber = 12345;
            long longNumber = originNumber;

            // change "default(long)" to correct value.
            const long expectedResult = default(long);

            Assert.Equal(expectedResult, longNumber);
        }

        [Fact]
        public void should_cast_between_numeric_types_safely()
        {
            int originNumber = 12345;
            var shortNumber = (short)originNumber;

            // change "default(short)" to correct value.
            const short expectedResult = default(short);

            Assert.Equal(expectedResult, shortNumber);
        }

        [Fact]
        public void should_truncate_value_when_cast_overflow()
        {
            int originNumber = 0x1234;
            var byteNumber = (byte)originNumber;

            // change "default(byte)" to correct value.
            const byte expectedResult = default(byte);

            Assert.Equal(expectedResult, byteNumber);
        }

        [Fact]
        public void should_never_count_on_integer_floating_number_casting()
        {
            int originalNumber = 100000001;
            float floatingPointNumber = originalNumber;
            var castedBackNumber = (int)floatingPointNumber;

            // change "default(int)" to correct value.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, castedBackNumber);
        }

        [Fact]
        public void should_use_fix_point_number_to_do_safe_casting_in_valid_range()
        {
            int originalNumber = 100000001;
            decimal decimalNumber = originalNumber;
            var castedBackNumber = (int)decimalNumber;

            // change "default(int)" to correct value.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, castedBackNumber);
        }

        [Fact]
        public void should_return_original_value_using_suffix_incremental()
        {
            int numberToIncrement = 1;
            int suffixIncrementalReturnValue = numberToIncrement++;

            // change "default(int)" to correct value.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, suffixIncrementalReturnValue);
        }

        [Fact]
        public void should_return_incremented_value_using_prefix_incremental()
        {
            int numberToIncrement = 1;
            int prefixIncrementalReturnValue = ++numberToIncrement;

            // change "default(int)" to correct value.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, prefixIncrementalReturnValue);
        }

        [Fact]
        public void should_throw_exception_if_integer_divided_by_zero()
        {
            int numerator = 1;
            int denominator = 0;

            // change "typeof(ArgumentException)" to correct exception type.
            Type desiredExceptionType = typeof(ArgumentException);

            Assert.NotEqual(typeof(ArithmeticException), desiredExceptionType);
            Assert.NotEqual(typeof(SystemException), desiredExceptionType);
            Assert.NotEqual(typeof(Exception), desiredExceptionType);
            Assert.Throws(desiredExceptionType, () => numerator / denominator);
        }

        [Fact]
        public void should_overflow_sciently_for_integer_operation()
        {
            int minimumValue = int.MinValue;
            --minimumValue;

            // change "default(int)" to correct value.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, minimumValue);
        }

        [Fact]
        public void should_throw_on_checked_overflow()
        {
            int minimumValue = int.MinValue;

            // change "typeof(ArgumentException)" to correct exception type.
            Type desiredExceptionType = typeof(ArgumentException);

            Assert.NotEqual(typeof(ArithmeticException), desiredExceptionType);
            Assert.NotEqual(typeof(SystemException), desiredExceptionType);
            Assert.NotEqual(typeof(Exception), desiredExceptionType);

            Assert.Throws(desiredExceptionType, () => { checked { --minimumValue; } });
        }

        [Fact]
        public void should_do_complement_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, ~0xf);
        }

        [Fact]
        public void should_do_and_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, (0xf0 & 0x33));
        }

        [Fact]
        public void should_do_or_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, (0xf0 | 0x33));
        }

        [Fact]
        public void should_do_exclusive_or_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, (0xff00 ^ 0x0ff0));
        }

        [Fact]
        public void should_do_shift_left_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, (0x20 << 2));
        }

        [Fact]
        public void should_do_shift_right_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = default(int);

            Assert.Equal(expectedResult, (0x20 >> 1));
        }

        [Fact]
        public void should_change_type_for_8_and_16_bit_number_arithmetic_operators()
        {
            const short shortNumber = 1;
            const short anotherShortNumber = 1;
            Type arithmeticOperatorResultType = (shortNumber + anotherShortNumber).GetType();

            // change "typeof(short)" to correct type.
            Type expectedResult = typeof(short);

            Assert.Equal(expectedResult, arithmeticOperatorResultType);
        }

        [Fact]
        public void should_get_infinite_value_when_divide_by_zero_for_floating_point_number()
        {
            const double numerator = 1.0;
            const double denominator = 0.0;

            // change "default(double)" to correct value.
            const double expectedResult = default(double);

            Assert.Equal(expectedResult, (numerator / denominator));
        }

        [Fact]
        public void should_get_nan_when_doing_certain_operation_for_floating_point_number()
        {
            const double numerator = 0;
            const double denominator = 0;

            const double expectedResult = default(double);

            Assert.Equal(expectedResult, (numerator / denominator));
        }
    }
}
