using System;

namespace BasicCSharp.Common
{
    internal class CustomizeEventArgsDemoClass
    {
        public event EventHandler<GreetingEventArgs> Greeting;

        public void Greet(string name)
        {
            OnGreeting("Hello " + name);
        }

        private void OnGreeting(string content)
        {
            EventHandler<GreetingEventArgs> handler = Greeting;
            if (handler != null)
            {
                handler(this, new GreetingEventArgs(content));
            }
        }
    }

    internal class GreetingEventArgs : EventArgs
    {
        private readonly string myGreetingContent;

        public GreetingEventArgs(string greetingContent)
        {
            myGreetingContent = greetingContent;
        }

        public string GreetingContent
        {
            get { return myGreetingContent; }
        }
    }
}