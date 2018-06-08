using System;

namespace BasicCSharp.Common
{
    internal enum BorderSide
    {
        Left,
        Right,
        Top,
        Bottom
    }

    internal enum BorderSideExplicity
    {
        Left = 12,
        Right = 34,
        Top = 56,
        Bottom = 78,
        LeftEquivalent = 12
    }

    internal enum BorderSideLayout
    {
        Left = 12,
        Right,
        Top = 78,
        Bottom
    }

    [Flags]
    internal enum BorderSideFlag
    {
        Left = 1,
        Right = 2,
        Top = 4,
        Bottom = 8,
        LeftAndRight = Left | Right,
        TopAndBottom = Top | Bottom,
        All = Left | Right | Top | Bottom
    }
}