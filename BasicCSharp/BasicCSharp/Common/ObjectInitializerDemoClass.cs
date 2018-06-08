namespace BasicCSharp.Common
{
    public class ObjectInitializerDemoClass
    {
        public ObjectInitializerDemoClass()
        {
        }

        public ObjectInitializerDemoClass(string propertyA)
        {
            PropertyA = propertyA;
        }

        public string PropertyA { get; set; }
        public string PropertyB { get; set; }
    }
}