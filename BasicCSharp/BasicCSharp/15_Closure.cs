using System;
using System.Collections.Generic;
using Xunit;

namespace BasicCSharp
{
    public class Closure
    {
        [Fact]
        public void should_capture_outer_variable()
        {
            int variableDeclaredOutsideAnonymousMethod = 1;

            Func<int> methodCapturingVariable = () => variableDeclaredOutsideAnonymousMethod;

            int returnedValue = methodCapturingVariable();

            // change variable value to correct test.
            const int expectedReturnedValue = 1;

            Assert.Equal(expectedReturnedValue, returnedValue);
        }

        [Fact]
        public void should_modify_outer_variable()
        {
            int outerVariable = 1;
            //lambda 函数：匿名函数的使用
            Action methodChangeVariableValue = () => outerVariable += 1;
            methodChangeVariableValue();

            // change variable value to correct test.
            const int expectedOuterVariableValue = 2;

            Assert.Equal(expectedOuterVariableValue, outerVariable);
        }

/**
 * Func???
 */
        [Fact]
        public void should_use_caution_when_capturing_outer_variable_in_loop()
        {
            var functionList = new List<Func<int>>();

            for (int i = 0; i < 3; ++i)
            {
                functionList.Add(() => i);
            }

            int sum = 0;
            foreach (Func<int> func in functionList)
            {
                sum += func();
            }

            const int expectedSum = 9;

            Assert.Equal(expectedSum, sum);
        }
    }
}