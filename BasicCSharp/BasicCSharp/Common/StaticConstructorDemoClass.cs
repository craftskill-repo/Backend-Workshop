namespace BasicCSharp.Common
{
    public class StaticConstructorDemoClass
    {
        private static string myStaticField;

        static StaticConstructorDemoClass()
        {
            myStaticField = "You are so cute!";
        }

        public static string StaticField
        {
            get { return myStaticField; }
        }
    }
}