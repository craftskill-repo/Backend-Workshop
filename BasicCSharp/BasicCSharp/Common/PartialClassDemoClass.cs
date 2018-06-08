namespace BasicCSharp.Common
{
    public partial class PartialClassDemoClass
    {
        public string Name { get; set; }
    }

    partial class PartialClassDemoClass
    {
        public string Title { get; set; }

        public override string ToString()
        {
            return Title + " " + Name;
        }
    }
}