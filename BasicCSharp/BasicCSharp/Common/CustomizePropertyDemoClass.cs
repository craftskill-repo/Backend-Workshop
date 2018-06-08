namespace BasicCSharp.Common
{
    public class CustomizePropertyDemoClass
    {
        private string myName;

        public string Name
        {
            get { return "Your Name Is " + myName; }
            set { myName = value; }
        } 
    }
}