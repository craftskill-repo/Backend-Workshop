using System.Collections.Generic;

namespace BasicCSharp.Common
{
    internal class DelegateSubtractionDemoClass
    {
        private readonly List<string> myTrace = new List<string>();

        public void A()
        {
            myTrace.Add("A");
        }

        public void B()
        {
            myTrace.Add("B");
        }

        public void C()
        {
            myTrace.Add("C");
        }

        public override string ToString()
        {
            return string.Join(",", myTrace.ToArray());
        }
    }
}