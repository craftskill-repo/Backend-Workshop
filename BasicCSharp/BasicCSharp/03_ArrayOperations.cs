using System;
using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class ArrayOperations
    {
        [Fact]
        public void should_access_certain_element_by_position()
        {
            var array = new[] {'a', 'e', 'i', 'o', 'u'};
            char elementAtIndex2 = array[2];

            // change "default(char)" to correct value.
            const char expectedResult = 'i';

            Assert.Equal(expectedResult, elementAtIndex2);
        }

        [Fact]
        public void should_throw_if_index_is_out_of_range()
        {
            var array = new[] { 'a', 'e', 'i', 'o', 'u' };

            // change "typeof(FormatException)" to correct value.
            Type expectedExceptionType = typeof(IndexOutOfRangeException);
            
            Assert.NotEqual(typeof(ArgumentException), expectedExceptionType);
            Assert.NotEqual(typeof(SystemException), expectedExceptionType);
            Assert.NotEqual(typeof(Exception), expectedExceptionType);

            Assert.Throws(expectedExceptionType, () => array[99]);
        }

        [Fact]
        public void should_return_index_number_if_found()
        {
            var array = new[] { 'a', 'e', 'i', 'o', 'u' };
            int indexOfCharacterO = Array.IndexOf(array, 'o');

            // change "default(char)" to correct value.
            const int expectedResult = 3;

            Assert.Equal(expectedResult, indexOfCharacterO);
        }

        [Fact]
        public void should_initialize_to_default_value()
        {
            var arrayWithValueType = new int[10];
            var arrayWithRefType = new string[10];

            // change the variable values in the following 2 lines to correct value.
            const int intAtPostion3 = 0;
            const string stringAtPosition3 = null;

            Assert.Equal(intAtPostion3, arrayWithValueType[3]);
            Assert.Equal(stringAtPosition3, arrayWithRefType[3]);
        }

        [Fact]
        public void should_return_shallow_copy_of_an_array_using_clone()
        {
            var array = new[] {new RefTypeClass(1)};
            var cloned = (RefTypeClass[])array.Clone();

            array[0].Value = 5;

            // change the variable value to correct one.
            const int expectedResult = 5;

            Assert.Equal(expectedResult, cloned[0].Value);
        }
    }
}