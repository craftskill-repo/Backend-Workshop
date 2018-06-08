using System;
using System.Text;

namespace BasicCSharp.Common
{
    public class DisposableWithTracingDemoClass : IDisposable
    {
        private readonly StringBuilder myTracer;

        public DisposableWithTracingDemoClass(StringBuilder tracer)
        {
            myTracer = tracer;
            myTracer.AppendLine("constructor called.");
        }

        public void Dispose()
        {
            myTracer.AppendLine("dispose called.");
        }
    }
}