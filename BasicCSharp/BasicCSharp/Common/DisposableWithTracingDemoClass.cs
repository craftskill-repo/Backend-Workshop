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
            tracer.AppendLine("dispose called.");
        }

        public string TracerContent()
        {
            return tracer.ToString();
        }
    }
}