using System.Collections.Generic;

namespace BasicCSharp.Common
{
    internal class MulticastDelegateDemoClass
    {
        private readonly List<string> myTrace = new List<string>();

        public void OneMethod()
        {
            myTrace.Add("MulticastDelegateDemoClass.OneMethod() called");
        }

        public void AnotherMethod()
        {
            myTrace.Add("MulticastDelegateDemoClass.AnotherMethod() called");
        }

        public string[] Trace
        {
            get { return myTrace.ToArray(); }
        }
    }
}