namespace BasicCSharp.Common
{
    public class PolymorphismDemoClassBase
    {
        public virtual string VirtualMethod()
        {
            return "BaseClass";
        }
    }

    public class PolymorphismDemoClass : PolymorphismDemoClassBase
    {
        public override string VirtualMethod()
        {
            return "DerivedClass";
        }
    }
}