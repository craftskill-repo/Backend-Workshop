namespace BasicCSharp.Common
{
    internal class DelegateTypeVarianceDemoClass
    {
        public string ReturnsMoreSpecificType()
        {
            return "Hello";
        }

        public string InputMoreGeneralType(object inputObject)
        {
            return inputObject.ToString();
        }
    }
}