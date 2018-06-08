namespace BasicCSharp.Common
{
    internal class HideMemberDemoClassBase
    {
        public string MethodToHide()
        {
            return "HideMemberDemoClassBase::MethodToHide()";
        }
    }

    internal class HideMemberDemoClass : HideMemberDemoClassBase
    {
        public new string MethodToHide()
        {
            return "HideMemberDemoClass::MethodToHide()";
        }
    }
}