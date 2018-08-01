using System;

namespace BasicCSharpDemo.CSharpDemo
{
    /**
     * 访问修饰符：public，private,protected,internal
     * internal:访问受限于当前程序集(程序集可以理解为一个工程项目，internal修饰符修饰的类或者属性只能在一个工程内部被使用)
     * 六个访问级别：上面四个+protected internal；private protected
     */
    internal class VisitModifier
    {
        internal static int a = 10;
        public static int b = 10;
        private static int c = 0;
    }

    public class TestAccess
    {
        public static void test()
        {
            VisitModifier vm = new VisitModifier();
            int c = VisitModifier.a;
        }
    }
}