using System;
using System.Collections.Generic;

namespace BasicCSharp.Common
{
    internal static class ExtensionMethodDemoClass
    {
        public static string OhGodItLooksAsIfIWasAMemberOfString(
            this string reference)
        {
            return reference;
        }

        public static IEnumerable<TResult> MySelect<TResult, TInput>(
            this IEnumerable<TInput> collection,
            Func<TInput, TResult> transformer)
        {
            foreach (TInput input in collection)
            {
                yield return transformer(input);
            }
        }
    }
}