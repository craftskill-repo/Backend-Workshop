using System;
using System.Collections;
using System.Collections.Generic;
using BasicCSharp.Common;
using BasicCSharp.Extensions;
using Xunit;

namespace BasicCSharp
{
    public class EnumerationRelated
    {
        [Fact]
        public void should_always_call_move_next_before_using_dereferenced_value()
        {
            var collection = new[] {1, 2, 3};

            IEnumerator enumerator = collection.GetEnumerator();
            Action getCurrentValueWithoutMoveNext = () =>
            {
                object value = enumerator.Current;
            };

            Exception error = getCurrentValueWithoutMoveNext.RunAndGetUnhandledException();

            // change the variable value to fix the test.
            Type expectedExceptionType = typeof(Exception);

            Assert.Equal(expectedExceptionType, error.GetType());
        }

        [Fact]
        public void should_return_true_if_not_iterating_to_the_end()
        {
            var collection = new List<string> {"good", "morning"};

            List<string>.Enumerator enumerator = collection.GetEnumerator();

            bool notEndOfIteration = enumerator.MoveNext();

            // change the variable value to fix the test.
            const bool expected = false;

            Assert.Equal(expected, notEndOfIteration);
        }

        [Fact]
        public void should_get_value_using_current_property()
        {
            var collection = new LinkedList<int>(new[] {1, 2, 3});

            LinkedList<int>.Enumerator enumerator = collection.GetEnumerator();

            enumerator.MoveNext();

            int currentValue = enumerator.Current;

            // change the variable value to fix the test.
            const int expectedCurrentValue = 2;

            Assert.Equal(expectedCurrentValue, currentValue);
        }

        [Fact]
        public void should_iterate_through_collection()
        {
            var collection = new SortedSet<int> {10, 2, 3, 5};

            var copyOfCollection = new List<int>();

            using (SortedSet<int>.Enumerator enumerator = collection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    copyOfCollection.Add(enumerator.Current);
                }
            }

            // change the variable value to fix the test.
            var expectedCopyResult = new List<int> {10, 2, 3, 5};

            Assert.Equal(expectedCopyResult, copyOfCollection);
        }

        [Fact]
        public void should_be_simplified_using_for_each()
        {
            var collection = new SortedSet<int> { 10, 2, 3, 5 };
            var copyOfCollection = new List<int>();

            foreach (int valueInCollection in collection)
            {
                copyOfCollection.Add(valueInCollection);
            }

            // change the variable value to fix the test.
            var expectedCopyResult = new List<int> { 10, 2, 3, 5 };

            Assert.Equal(expectedCopyResult, copyOfCollection);
        }

        [Fact]
        public void should_implement_iterator_using_yield()
        {
            var demoObject = new ImplIteratorUsingYieldDemoClass();
            var numberStorage = new List<int>();

            foreach (int number in demoObject.GetOneToTen())
            {
                numberStorage.Add(number);
            }

            // change the variable value to fix the test.
            var expectedNumberStorage = new List<int> {1, 2};

            Assert.Equal(expectedNumberStorage, numberStorage);
        }

        [Fact]
        public void should_treat_yield_as_part_of_the_iteration_stream()
        {
            var demoObject = new ImplIteratorUsingYieldDemoClass();
            var numberStorage = new List<int>();

            foreach (int number in demoObject.GetOneToThreeWithMultipleYields())
            {
                numberStorage.Add(number);
            }

            // change the variable value to fix the test.
            var expectedNumberStorage = new List<int> {1};

            Assert.Equal(expectedNumberStorage, numberStorage);
        }

        [Fact]
        public void should_using_yield_break_to_stop_iterating_early()
        {
            var demoObject = new ImplIteratorUsingYieldDemoClass();
            var numberStorage = new List<int>();

            foreach (int number in demoObject.GetOnToThreeButBreakingAtTwo())
            {
                numberStorage.Add(number);
            }

            // change the variable value to fix the test.
            var expectedNumberStorage = new List<int> { 1, 2, 3 };

            Assert.Equal(expectedNumberStorage, numberStorage);
        }

        [Fact]
        public void should_composing_iterating_sequences()
        {
            var demoObject = new ImplIteratorUsingYieldDemoClass();
            var numberStorage = new List<int>();

            foreach (int number in demoObject.GetEvenNumber(demoObject.GetOneToTen()))
            {
                numberStorage.Add(number);
            }

            // change the variable value to fix the test.
            var expectedNumberStorage = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Equal(expectedNumberStorage, numberStorage);
        }
    }
}