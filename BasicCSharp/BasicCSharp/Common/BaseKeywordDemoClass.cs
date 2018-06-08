namespace BasicCSharp.Common
{
    internal abstract class BaseKeywordDemoClassBase
    {
        protected string Ending
        {
            get { return "."; }
        }

        public virtual string Name
        {
            get { return "BaseClass"; }
        }
    }

    internal class BaseKeywordDemoClass : BaseKeywordDemoClassBase
    {
        public override string Name
        {
            get { return base.Name + "'s derived class" + base.Ending; }
        }
    }
}