using System;
using System.Drawing;

namespace BasicCSharpDemo
{
    [Flags]
    internal enum CarOptions
    {
        // The flag for SunRoof is 0001.
        SunRoof = 0x01,
        // The flag for Spoiler is 0010.
        Spoiler = 0x02,
        // The flag for FogLights is 0100.
        FogLights = 0x04,
        // The flag for TintedWindows is 1000.
        TintedWindows = 0x08,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The bitwise OR of 0001 and 0100 is 0101.
     /*
            CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;
            Console.WriteLine(options);
            Console.WriteLine((int)options);
       */
            Point p = new Point(2,5);
            Console.WriteLine("{0},{1}",p.X,p.Y);

            Point p1;
            p1.X = 5;
            p1.Y = 5;
            Console.WriteLine("{0},{1}",p1.X,p1.Y);
        }
    }
}