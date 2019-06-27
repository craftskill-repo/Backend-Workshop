using System;
using BasicCSharp.Common;
using Xunit;

namespace BasicCSharp
{
    public class Enums
    {
        [Fact]
        public void should_be_able_to_compare_enums()
        {
            const bool bottomEqualsLeft = BorderSide.Bottom == BorderSide.Left;
            #pragma warning disable 1718 // suppress compiler warning about comparing same variable
            const bool rightEqualsRight = BorderSide.Right == BorderSide.Right;
            #pragma warning restore 1718

            // change the variable value for following 2 lines to fix the test.
            const bool expectedResultForBottomEqualsLeft = true;
            const bool expectedResultForRightEqualsRight = false;

            Assert.Equal(expectedResultForBottomEqualsLeft, bottomEqualsLeft);
            Assert.Equal(expectedResultForRightEqualsRight, rightEqualsRight);
        }

        [Fact]
        public void should_increase_the_integer_automatically()
        {
            // change the variable value for following 4 lines to fix the test.
            const int leftValue = int.MinValue;
            const int rightValue = int.MinValue;
            const int topValue = int.MinValue;
            const int bottomValue = int.MinValue;

            Assert.True((BorderSide) leftValue == BorderSide.Left);
            Assert.True((BorderSide) rightValue == BorderSide.Right);
            Assert.True((BorderSide) topValue == BorderSide.Top);
            Assert.True((BorderSide) bottomValue == BorderSide.Bottom);
        }

        [Fact]
        public void should_specify_explicity_integer_value_for_each_member()
        {
            // change the variable value for following 4 lines to fix the test.
            const int leftValue = int.MinValue;
            const int rightValue = int.MinValue;
            const int topValue = int.MinValue;
            const int bottomValue = int.MinValue;

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
            const bool expectedCompareResult = false;

            Assert.Equal(expectedCompareResult, differentDeclareWithSameValueCompareResult);
        }

        [Fact]
        public void should_increase_the_integer_according_to_layout()
        {
            // change the variable value for following 4 lines to fix the test.
            const int leftValue = int.MinValue;
            const int rightValue = int.MinValue;
            const int topValue = int.MinValue;
            const int bottomValue = int.MinValue;

            Assert.True((BorderSideLayout)leftValue == BorderSideLayout.Left);
            Assert.True((BorderSideLayout)rightValue == BorderSideLayout.Right);
            Assert.True((BorderSideLayout)topValue == BorderSideLayout.Top);
            Assert.True((BorderSideLayout)bottomValue == BorderSideLayout.Bottom);
        }

        [Fact]
        public void should_be_able_to_parse_enum_by_name()
        {
            var parsedBottomEnumValue = (BorderSide)Enum.Parse(typeof(BorderSide), "Bottom");

            // change the variable value to fix the test.
            const BorderSide expectedEnumValue = BorderSide.Left;

            Assert.Equal(expectedEnumValue, parsedBottomEnumValue);
        }

        [Fact]
        public void should_be_able_to_parse_enum_by_value()
        {
            var parsedBottomEnumValue = (BorderSide)Enum.Parse(typeof(BorderSide), "3");

            // change the variable value to fix the test.
            const BorderSide expectedEnumValue = BorderSide.Left;

            Assert.Equal(expectedEnumValue, parsedBottomEnumValue);
        }

        [Fact]
        public void should_declare_flag_when_enum_values_can_be_combined()
        {
            const BorderSideFlag leftAndRight = BorderSideFlag.LeftAndRight;

            const bool includeLeft = (leftAndRight & BorderSideFlag.Left) != 0;
            
            // change the variable value to fix the test.
            const bool expectedIncludeLeft = false;

            Assert.Equal(expectedIncludeLeft, includeLeft);
        }
    }
}