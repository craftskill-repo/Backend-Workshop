using System;
using System.Text;

namespace BasicCSharp.Common
{
    public class DisposableWithTracingDemoClass : IDisposable
    {
        private readonly StringBuilder tracer = new StringBuilder();

        public DisposableWithTracingDemoClass()
        {
            this.tracer.AppendLine("constructor called.");
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