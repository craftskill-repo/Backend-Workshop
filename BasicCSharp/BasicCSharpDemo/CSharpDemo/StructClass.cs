using System;

namespace BasicCSharpDemo.CSharpDemo
{
    internal struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class StructClass
    {
        public static void devTest()
       {
            Console.WriteLine("dev test");
        }

        public void dev2Branch()
        {
            Console.WriteLine("dev2 branch commit 5");
        }
    }
}