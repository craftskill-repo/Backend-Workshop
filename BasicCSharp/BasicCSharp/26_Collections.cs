using System.Collections.Generic;
using System.Linq;
using System;
using Xunit;

namespace BasicCSharp
{
    public class Collections
    {
        [Fact]
        public void should_use_set_for_unique_elements()
        {
            ISet<string> mySet = new HashSet<string>();

            mySet.Add("one");
            mySet.Add("two");
            mySet.Add("one");

            // please update variable value to fix the test
            var expectedNumberOfElements = 3;

            Assert.Equal(expectedNumberOfElements, mySet.Count);
        }

        [Fact]
        public void should_use_collection_initializer_when_possible()
        {
            ISet<string> mySet = new HashSet<string> { "one", "two", "three" };

            // please update variable value to fix the test
            var expectedNumberOfElements = 0;

            Assert.Equal(expectedNumberOfElements, mySet.Count);
        }

        [Fact]
        public void should_not_rely_on_order_in_hashset()
        {
            ISet<int> mySet = new HashSet<int>() { 1, 2, 3, 4, 5 };

            // please update if statement fix the test.
            Action<int> elementValidator = (x) => { if (true) throw new ArgumentOutOfRangeException("unexpected element"); };

            Assert.All(mySet, elementValidator);
            Assert.Equal(5, mySet.Count);
        }

        [Fact]
        public void should_use_sortedSet_when_looking_for_specific_order()
        {
            ISet<int> mySet = new SortedSet<int>() { 1, 5, 3, 4, 2 };

            // please update variable value to fix the test.
            IList<int> expectedOrderOfElements = new List<int> { 1, 5, 3, 4, 2 };

            Assert.Equal(expectedOrderOfElements, mySet.ToList());
        }

        [Fact]
        public void should_be_able_to_access_elements_by_key()
        {
            IDictionary<string, string> myDictionary = new Dictionary<string, string> {
                {"chris", "Chris' address"},
                {"jo", "Jo's address"},
                {"kim", "Kim's address"}
            };

            // please update variable value to fix the test
            var expectedAddressOfJo = "don't know";


            Assert.Equal(expectedAddressOfJo, myDictionary["jo"]);
        }

        [Fact]
        public void should_be_using_sortedList_when_looking_for_sorted_key_value_datastructure()
        {
            SortedList<int, string> myDictionary = new SortedList<int, string> {
                {2, "one"},
                {3, "two"},
                {1, "three"}
            };

            // please update variable value to fix the test
            var expectedKeyOrder = new List<int> { 2, 3, 1 };

            Assert.Equal(expectedKeyOrder, myDictionary.Keys);
        }

        [Fact]
        public void should_be_able_to_access_ordered_elements_through_an_index_and_allow_duplicate_items()
        {
            IList<string> myList = new List<string> { "one", "two", "one" };

            // please update variable value to fix the test
            var expectedSecondElement = "not one";
            var expectedElementCount = 2;

            Assert.Equal(expectedSecondElement, myList[1]);
            Assert.Equal(expectedElementCount, myList.Count);
        }

        [Fact]
        public void should_be_able_to_access_items_sequentially()
        {
            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddLast("three");
            myLinkedList.AddAfter(myLinkedList.First, "four");
            myLinkedList.AddBefore(myLinkedList.First, "two");
            myLinkedList.AddFirst("one");

            // please update variable value to fix the test
            var expectedLinkedListContent = new List<string> { "", "", "", "" };

            Assert.Equal(expectedLinkedListContent, myLinkedList.ToList());
        }

        [Fact]
        public void should_have_a_datatype_for_first_in_last_out()
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("first");
            myStack.Push("middle");
            myStack.Push("last");

            var expectedFirstElementToRetrieve = "first";

            Assert.Equal(expectedFirstElementToRetrieve, myStack.Pop());
        }

        [Fact]
        public void should_have_a_datatype_for_first_in_first_out()
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("first");
            myQueue.Enqueue("middle");
            myQueue.Enqueue("last");

            var expectedFirstElementToRetrieve = "last";

            Assert.Equal(expectedFirstElementToRetrieve, myQueue.Dequeue());
        }
    }
}
