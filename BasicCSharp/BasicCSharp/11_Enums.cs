using System;
using BasicCSharp.Common;
using Xunit;
/**
 * 枚举
 */
namespace BasicCSharp
{
    public class Enums
    {
        [Fact]
        public void should_be_able_to_compare_enums()
        {
            const bool bottomEqualsLeft = BorderSide.Bottom == BorderSide.Left;
            const bool rightEqualsRight = BorderSide.Right == BorderSide.Right;

            // change the variable value for following 2 lines to fix the test.
            const bool expectedResultForBottomEqualsLeft = false;
            const bool expectedResultForRightEqualsRight = true;

            Assert.Equal(expectedResultForBottomEqualsLeft, bottomEqualsLeft);
            Assert.Equal(expectedResultForRightEqualsRight, rightEqualsRight);
        }
        /**
         * 枚举：每个符号代表一个值，默认情况下第一个值为0，后面一次递增
         */
        [Fact]
        public void should_increase_the_integer_automatically()
        {
            // change the variable value for following 4 lines to fix the test.
            const int leftValue = 0;
            const int rightValue = 1;
            const int topValue = 2;
            const int bottomValue = 3;

            Assert.True((BorderSide) leftValue == BorderSide.Left);
            Assert.True((BorderSide) rightValue == BorderSide.Right);
            Assert.True((BorderSide) topValue == BorderSide.Top);
            Assert.True((BorderSide) bottomValue == BorderSide.Bottom);
        }
        /**
         * 枚举：每个符号显式赋值
         */
        [Fact]
        public void should_specify_explicity_integer_value_for_each_member()
        {
            // change the variable value for following 4 lines to fix the test.
            const int leftValue = 12;
            const int rightValue = 34;
            const int topValue = 56;
            const int bottomValue = 78;

            Assert.True((BorderSideExplicity)leftValue == BorderSideExplicity.Left);
            Assert.True((BorderSideExplicity)rightValue == BorderSideExplicity.Right);
            Assert.True((BorderSideExplicity)topValue == BorderSideExplicity.Top);
            Assert.True((BorderSideExplicity)bottomValue == BorderSideExplicity.Bottom);
        }

        [Fact]
        public void should_only_compare_values()
        {
            const bool differentDeclareWithSameValueCompareResult = 
                BorderSideExplicity.Left == BorderSideExplicity.LeftEquivalent;

            // change the variable value to fix the test.
            const bool expectedCompareResult = true;

            Assert.Equal(expectedCompareResult, differentDeclareWithSameValueCompareResult);
        }
        /**
         * 枚举：每个符号显式赋值，如果没有值则进行递增+1
         */
        [Fact]
        public void should_increase_the_integer_according_to_layout()
        {
            // change the variable value for following 4 lines to fix the test.
            const int leftValue = 12;
            const int rightValue = 13;
            const int topValue = 78;
            const int bottomValue = 79;

            Assert.True((BorderSideLayout)leftValue == BorderSideLayout.Left);
            Assert.True((BorderSideLayout)rightValue == BorderSideLayout.Right);
            Assert.True((BorderSideLayout)topValue == BorderSideLayout.Top);
            Assert.True((BorderSideLayout)bottomValue == BorderSideLayout.Bottom);
        }
        /**
         * 枚举：Enum.parse(type,string);根据枚举名字解析出枚举类型
         */
        [Fact]
        public void should_be_able_to_parse_enum_by_name()
        {
            var parsedBottomEnumValue = (BorderSide)Enum.Parse(typeof(BorderSide), "Bottom");

            // change the variable value to fix the test.
            const BorderSide expectedEnumValue = BorderSide.Bottom;

            Assert.Equal(expectedEnumValue, parsedBottomEnumValue);
        }
        /**
         * Enum.parse(type,string);根据枚举值解析出枚举类型
         */
        [Fact]
        public void should_be_able_to_parse_enum_by_value()
        {
            var parsedBottomEnumValue = (BorderSide)Enum.Parse(typeof(BorderSide), "3");

            // change the variable value to fix the test.
            const BorderSide expectedEnumValue = BorderSide.Bottom;

            Assert.Equal(expectedEnumValue, parsedBottomEnumValue);
        }
        /**
         * 
         */
        [Fact]
        public void should_declare_flag_when_enum_values_can_be_combined()
        {
            const BorderSideFlag leftAndRight = BorderSideFlag.LeftAndRight;

            const bool includeLeft = (leftAndRight & BorderSideFlag.Left) != 0;
            
            // change the variable value to fix the test.
            const bool expectedIncludeLeft = true;

            Assert.Equal(expectedIncludeLeft, includeLeft);
        }
    }
}