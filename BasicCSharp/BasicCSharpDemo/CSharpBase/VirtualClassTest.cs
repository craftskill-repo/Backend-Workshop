using System;

namespace BasicCSharpDemo.CSharpBase
{
    public class VirtualClassTest
    {
        protected virtual void test()
        {
            Console.WriteLine("base class virtual test");
        }
    }




    class VirtualClassTestable : VirtualClassTest
    {
        protected override void test()
        {
            Console.WriteLine("subClasss override test");
        }
    }
}