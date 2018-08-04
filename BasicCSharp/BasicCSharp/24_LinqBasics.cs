using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BasicCSharp.Common;
using Xunit;
/**
 * LinQ
 */
namespace BasicCSharp
{
    public class Linq2ObjectBasics
    {
        /**
         * where 条件查询
         */
        [Fact]
        public void should_filtering_elements_using_where()
        {
            string[] sequence =
            {
                "a", "quick", "brown", "fox", "jumps", "over", "a", "lazy", "dog"
            };

            IEnumerable<string> filteredResult = sequence.Where(item => item.Length == 5);

            // please update variable value to fix the test.
            IEnumerable<string> expectedResult =
                new[] {"quick", "brown", "jumps"};

            Assert.Equal(expectedResult, filteredResult);
        }
        /**
         * select??
         */
        [Fact]
        public void should_project_elements_using_select()
        {
            var sequence = new[]
            {
                new Name("Edogawa", "Conan"),
                new Name("Ogiso", "Setsuna"),
                new Name("Kirigaya", "Katsuto")
            };

            IEnumerable<string> projection = sequence.Select(item => item.ToString());

            // please update variable value to fix the test.
            IEnumerable<string> expectedResult =
                new[] {"Edogawa Conan", "Ogiso Setsuna","Kirigaya Katsuto"};

            Assert.Equal(expectedResult, projection);
        }
        /**
         * 取数组中的前n个元素
         */
        [Fact]
        public void should_take_first_n_elements_using_take()
        {
            var sequence = new[] {1, 2, 3, 4, 5};

            IEnumerable<int> filteredElements = sequence.Take(3);

            // please update variable value to fix the test.
            IEnumerable<int> expectedResult = new[] {1, 2, 3};

            Assert.Equal(expectedResult, filteredElements);
        }
        /**
         * 跳过数组中的前n个元素
         */
        [Fact]
        public void should_skip_first_n_elements_using_skip()
        {
            var sequence = new[] {1, 2, 3, 4, 5};

            IEnumerable<int> filteredElements = sequence.Skip(3);

            // please update variable value to fix the test.
            IEnumerable<int> expectedResult = new[] {4, 5};

            Assert.Equal(expectedResult, filteredElements);
        }
        /**
         * 
         */
        [Fact]
        public void should_get_first_element_using_first()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            int firstElement = sequence.First();
            int firstEvenNumber = sequence.First(item => item % 2 == 0);

            // please update variable values for the following 2 lines to fix the test.
            const int expectedFirstElement = 1;
            const int expectedFirstEvenNumber = 2;

            Assert.Equal(expectedFirstElement, firstElement);
            Assert.Equal(expectedFirstEvenNumber, firstEvenNumber);
        }

        [Fact]
        public void should_get_last_element_using_last()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            int lastElement = sequence.Last();
            int lastEvenNumber = sequence.Last(item => item % 2 == 0);

            // please update variable values for the following 2 lines to fix the test.
            const int expectedLastElement = 5;
            const int expectedLastEvenNumber = 4;

            Assert.Equal(expectedLastElement, lastElement);
            Assert.Equal(expectedLastEvenNumber, lastEvenNumber);
        }

        [Fact]
        public void should_get_nth_element_using_element_at()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            int thirdElement = sequence.ElementAt(2);

            // please update variable value to fix the test.
            const int expectedThirdElement = 3;

            Assert.Equal(expectedThirdElement, thirdElement);
        }

        [Fact]
        public void should_get_element_element_using_count()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            int totalNumber = sequence.Count();
            int numberOfEvenNumbers = sequence.Count(item => item % 2 == 0);

            // please update variable value to fix the test.
            const int expectedTotalNumber = 5;
            const int expectedNumberOfEvenNumbers = 2;

            Assert.Equal(expectedTotalNumber, totalNumber);
            Assert.Equal(expectedNumberOfEvenNumbers, numberOfEvenNumbers);
        }

        [Fact]
        public void should_get_minimum_element_using_min()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            int minNumber = sequence.Min();

            // please update variable value to fix the test.
            const int expectedMinNumber = 1;

            Assert.Equal(expectedMinNumber, minNumber);
        }

        [Fact]
        public void should_get_maximum_element_using_max()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            int maxNumber = sequence.Max();

            // please update variable value to fix the test.
            const int expectedMaxNumber = 5;

            Assert.Equal(expectedMaxNumber, maxNumber);
        }

        [Fact]
        public void should_check_if_sequence_contains_element()
        {
            var sequence = new[] {1, 2, 3, 4, 5};

            bool containsTwo = sequence.Contains(2);
            bool containsTen = sequence.Contains(10);

            // please update variable values of the following 2 lines to fix the test.
            const bool expectedContainsTwo = true;
            const bool expectedContainsTen = false;

            Assert.Equal(expectedContainsTwo, containsTwo);
            Assert.Equal(expectedContainsTen, containsTen);
        }

        [Fact]
        public void should_check_if_sequence_has_more_than_zero_elements()
        {
            var sequence = new[] { 1, 2, 3, 4, 5 };

            bool sequenceNotEmpty = sequence.Any();
            bool modThreeNotEmpty = sequence.Any(item => item % 3 == 0);

            // please update variable values of the following 2 lines to fix the test.
            const bool expectedSequenceNotEmpty = true;
            const bool expectedModThreeNotEmpty = true;

            Assert.Equal(expectedSequenceNotEmpty, sequenceNotEmpty);
            Assert.Equal(expectedModThreeNotEmpty, modThreeNotEmpty);
        }

        [Fact]
        public void should_check_if_each_and_every_item_in_sequence_match_prediction()
        {
            var sequence = new[] { 2, 4, 6, 8, 10 };

            bool allEvenNumbers = sequence.All(item => item % 2 == 0);

            // please update variable value to fix the test.
            const bool expectedAllEvenNumbers = true;

            Assert.Equal(expectedAllEvenNumbers, allEvenNumbers);
        }

        [Fact]
        public void should_concat_sequences()
        {
            var left = new[] {1, 2, 3};
            var right = new[] {4, 5};

            IEnumerable<int> concat = left.Concat(right);

            // please update variable value to fix the test.
            IEnumerable<int> expectedConcatResult = new[] {1, 2, 3,4,5};

            Assert.Equal(expectedConcatResult, concat);
        }

        [Fact]
        public void should_union_sequences()
        {
            var left = new[] {1, 2, 3};
            var right = new[] {4, 3, 5};

            IEnumerable<int> unionResult = left.Union(right);

            // please update variable value to fix the test.
            IEnumerable<int> expectedUnionResult = new[] { 1, 2, 3,4,5};

            Assert.Equal(expectedUnionResult, unionResult);
        }

        [Fact]
        public void should_get_sequences_intersection()
        {
            var firstSequence = new[] { 1, 2, 3 };
            var secondSequence = new[] { 4, 3, 5 };

            IEnumerable<int> intersection = firstSequence.Intersect(secondSequence);

            // please update variable value to fix the test.
            IEnumerable<int> expectedIntersection = new[] { 3 };

            Assert.Equal(expectedIntersection, intersection);
        }

        [Fact]
        public void should_get_sequence_excpetions()
        {
            var firstSequence = new[] { 1, 2, 3 };
            var secondSequence = new[] { 4, 3, 5 };

            IEnumerable<int> except = firstSequence.Except(secondSequence);

            // please update variable value to fix the test.
            IEnumerable<int> expectedIntersection = new[] { 1, 2};

            Assert.Equal(expectedIntersection, except);
        }

        [Fact]
        public void should_get_ordered_sequence()
        {
            var sequence = new[] {4, 2, 1, 3, 5};

            IOrderedEnumerable<int> orderedResult = sequence.OrderBy(item => item);

            // please update variable value to fix the test.
            IEnumerable<int> expectedOrderedResult = new[] {1, 2, 3, 4,5};

            Assert.Equal(expectedOrderedResult, orderedResult);
        }
        /**
         * 以一种延迟方式进行迭代
         */
        [Fact]
        public void should_execute_in_a_deferred_way_for_iteration_operation()
        {
            var sequence = new List<int> {1};

            IEnumerable<string> projection =
                sequence.Select(item => item.ToString(CultureInfo.InvariantCulture));

            sequence.Add(2);

            // please update variable value to fix the test.
            IEnumerable<string> expectedProjection = new[] { "1" ,"2"};

            Assert.Equal(expectedProjection, projection);
        }
    }
}