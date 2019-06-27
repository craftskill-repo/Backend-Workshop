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
            const string expectedResult = default(string);

            Assert.Equal(expectedResult, (title + name));
        }

        [Fact]
        public void should_using_stringbuilder_to_concat_string_efficiently()
        {
            #pragma warning disable 0219 // suppress compiler warning about unused variables

            const string title = "Mr. ";
            const string name = "Hall";
            
            #pragma warning restore 0219

            var builder = new StringBuilder();
            // add at most 2 lines of code here concating variable "title" and "name".

            Assert.Equal("Mr. Hall", builder.ToString());
        }

        [Fact]
        public void should_create_a_new_string_for_replace_operation()
        {
            string originalString = "Original String";
            string replacement = originalString.Replace("Str", "W");

            // change "" in the following 2 lines to correct values.
            const string expectedOrignalString = "";
            const string expectedReplacement = "";
            
            Assert.Equal(expectedOrignalString, originalString);
            Assert.Equal(expectedReplacement, replacement);
        }

        [Fact]
        public void should_use_string_builder_for_inplace_string_replacement()
        {
            var builder = new StringBuilder("Original String");
            builder.Replace("Str", "W");

            // change "" in the following line to correct value.
            const string expectedResult = "";

            Assert.Equal(expectedResult, builder.ToString());
        }

        [Fact]
        public void should_locate_certain_character_using_indexer()
        {
            const string originalString = "Original String";
            char characterAtIndex2 = originalString[2];

            // change "default(char)" to correct value.
            const char expectedResult = default (char);

            Assert.Equal(expectedResult, characterAtIndex2);
        }

        [Fact]
        public void should_compare_string_value()
        {
            const string str = "Original String";
            string equivalent = "Original" + " String";

            // change "default(bool)" to correct value.
            const bool expectedResult = default(bool);

            Assert.Equal(expectedResult, (str == equivalent));
        }

        [Fact]
        public void should_use_equal_method_to_test_equaility_in_a_more_flexible_way()
        {
            const string originalString = "Original String";
            const string inDifferentCase = "oRiginal String";

            // change the variable values in the following 2 lines.
            var caseSensitiveComparison = StringComparison.InvariantCultureIgnoreCase;
            var caseInsensitiveComparison = StringComparison.InvariantCulture;

            Assert.False(originalString.Equals(inDifferentCase, caseSensitiveComparison));
            Assert.True(originalString.Equals(inDifferentCase, caseInsensitiveComparison));
        }
    }
}