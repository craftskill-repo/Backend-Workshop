using System;
using System.Text;
using Xunit;

namespace BasicCSharp
{
    public class StringAndCharOperations
    {
        [Fact]
        public void should_concat_string()
        {
            const string title = "Mr. ";
            const string name = "Hall";

            // change "default(string)" to correct value.
            const string expectedResult = "Mr. Hall";

            Assert.Equal(expectedResult, (title + name));
        }

        [Fact]
        public void should_using_stringbuilder_to_concat_string_efficiently()
        {
            const string title = "Mr. ";
            const string name = "Hall";

            var builder = new StringBuilder();
            // add at most 2 lines of code here concating variable "title" and "name".
            builder.Append(title);
            builder.Append(name);
            Assert.Equal("Mr. Hall", builder.ToString());
        }

        [Fact]
        public void should_create_a_new_string_for_replace_operation()
        {
            string originalString = "Original String";
            string replacement = originalString.Replace("Str", "W");

            // change "" in the following 2 lines to correct values.
            const string expectedOrignalString = "Original String";
            const string expectedReplacement = "Original Wing";
            
            Assert.Equal(expectedOrignalString, originalString);
            Assert.Equal(expectedReplacement, replacement);
        }

        [Fact]
        public void should_use_string_builder_for_inplace_string_replacement()
        {
            var builder = new StringBuilder("Original String");
            builder.Replace("Str", "W");

            // change "" in the following line to correct value.
            const string expectedResult = "Original Wing";

            Assert.Equal(expectedResult, builder.ToString());
        }

        [Fact]
        public void should_locate_certain_character_using_indexer()
        {
            const string originalString = "Original String";
            char characterAtIndex2 = originalString[2];

            // change "default(char)" to correct value.
            const char expectedResult = 'i';

            Assert.Equal(expectedResult, characterAtIndex2);
        }

        [Fact]
        public void should_compare_string_value()
        {
            const string str = "Original String";
            string equivalent = "Original" + " String";

            // change "default(bool)" to correct value.
            const bool expectedResult =true;

            Assert.Equal(expectedResult, (str == equivalent));
        }

        [Fact]
        public void should_use_equal_method_to_test_equaility_in_a_more_flexible_way()
        {
            const string originalString = "Original String";
            const string inDifferentCase = "oRiginal String";

            // change the variable values in the following 2 lines.
            var caseSensitiveComparison = StringComparison.CurrentCulture;//区分大小写
            var caseInsensitiveComparison = StringComparison.CurrentCultureIgnoreCase;//不区分大小写

            Assert.False(originalString.Equals(inDifferentCase, caseSensitiveComparison));
            Assert.True(originalString.Equals(inDifferentCase, caseInsensitiveComparison));
        }
    }
}