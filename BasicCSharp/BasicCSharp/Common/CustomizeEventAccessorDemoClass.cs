using System;

namespace BasicCSharp.Common
{
    internal class CustomizeEventAccessorDemoClass
    {
        private EventHandler myEvent;

        public event EventHandler Event
        {
            add
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                myEvent += value;
            }

            remove { myEvent -= value; }
        }

        private void OnTiggered()
        {
            var handler = myEvent;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Tigger()
        {
            OnTiggered();
        }
    }
}