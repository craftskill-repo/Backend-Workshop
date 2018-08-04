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
            Console.WriteLine("test git checkout test dev1 confliect");
            Console.WriteLine("test git checkout   dev1 confliect");
            Console.WriteLine("dev1 confliect!ddddd");


            Console.WriteLine("dev2 commit1");
            Console.WriteLine("dev2 commit2");


            Console.WriteLine("master branch commit 1");
            Console.WriteLine("master branch commit 2");       

            Console.WriteLine("dev1 branch commit 1");

            Console.WriteLine("dev1 branch commit 2");
            
            Console.WriteLine("dev2 branch commit 3");

            Console.WriteLine("master branch commit 3");
        }

    }
    
}