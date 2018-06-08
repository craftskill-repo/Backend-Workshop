namespace BasicCSharp.Common
{
    internal class ValueTypeRestrictedGenericDemoClass<T>
        where T : struct 
    {
        public ValueTypeRestrictedGenericDemoClass()
        {
            // since all struct declared type has default constructor.
            Value = default(T);
        }

        public T Value { get; set; }
    }

    internal class RefTypeRestrictedGenericDemoClass<T>
        where T : class
    {
        public RefTypeRestrictedGenericDemoClass()
        {
            Value = default(T);
        }

        public T Value { get; set; }
    }

    internal class DefaultCtorRestrictedGenericDemoClass<T>
        where T : new()
    {
        public DefaultCtorRestrictedGenericDemoClass()
        {
            Value = new T();
        }

        public T Value { get; set; }
    }

    internal class InterfaceRestrictedGenericDemoClass<T>
        where T : ITalkable, new()
    {
        public override string ToString()
        {
            var talkable = new T();
            return talkable.Talk();
        }
    }

    internal class SayHelloByDefault
    {
        private readonly string m_value;

        public SayHelloByDefault()
        {
            m_value = "Hello";
        }

        public override string ToString()
        {
            return m_value;
        }
    }
}