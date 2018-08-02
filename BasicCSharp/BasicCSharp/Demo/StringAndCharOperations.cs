using System;
using BasicCSharpDemo.CSharpDemo;
using Xunit;

namespace BasicCSharp.Demo
{
    /*
     * 测试internal修饰符
     * 当internal修饰符只能在一个工程中使用，不能跨工程
     */
     public class StringAndCharOperations
    {
         public void test()
        {
            Console.WriteLine("hello world!");
            //Assert.Equal(true,true);
            VisitModifier vm =new VisitModifier();
            int a =VisitModifier.b;
            
            Console.WriteLine("test git checkout");
            Console.WriteLine("dev2 push to master");
            Console.WriteLine("git commit --amend");
            Console.WriteLine("test git sfafasdfadsfagfdagfdgsdtashdfasfasfadsf");
        }

    }
    
}