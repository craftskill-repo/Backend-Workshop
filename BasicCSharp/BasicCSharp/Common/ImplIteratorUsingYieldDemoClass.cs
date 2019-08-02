using System.Collections.Generic;

namespace BasicCSharp.Common
{
    internal class ImplIteratorUsingYieldDemoClass
    {
        public IEnumerable<int> GetOneToTen()
        {
            for (int i = 1; i <= 10; ++i)
            {
                yield return i;
            }
        }

        public IEnumerable<int> GetOneToThreeWithMultipleYields()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        public IEnumerable<int> GetOnToThreeButBreakingAtTwo()
        {
            yield return 1;
            yield return 2;
            yield break;
            #pragma warning disable 0162 // suppress compiler warning about unreachable code
            yield return 3;
            #pragma warning restore 0162
        }

        public IEnumerable<int> GetEvenNumber(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}