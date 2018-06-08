namespace BasicCSharp.Common
{
    internal class MethodOverloadBaseClass
    {
    }

    internal class MethodOverloadDerivedClass : MethodOverloadBaseClass
    {
    }

    internal class MethodOverloadDemoClass
    {
        public string Foo()
        {
            return "Foo()";
        }

        public string Foo(int a)
        {
            return "Foo(int)";
        }

        public string Foo(object a)
        {
            return "Foo(object)";
        }

        public string Foo(long a)
        {
            return "Foo(long)";
        }

        public string Foo(MethodOverloadBaseClass baseClassObject)
        {
            return "Foo(MethodOverloadBaseClass)";
        }

        public string Foo(MethodOverloadDerivedClass derivedClassObject)
        {
            return "Foo(MethodOverloadDerivedClass)";
        }
    }
}