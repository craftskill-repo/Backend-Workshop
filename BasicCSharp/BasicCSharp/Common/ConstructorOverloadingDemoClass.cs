using System.Text;

namespace BasicCSharp.Common
{
    public class ConstructorOverloadingDemoClass
    {
        private readonly StringBuilder myReportBuilder = new StringBuilder();

        public ConstructorOverloadingDemoClass()
        {
            myReportBuilder.AppendLine("Ctor()");
        }

        public ConstructorOverloadingDemoClass(string arg) 
            : this()
        {
            myReportBuilder.AppendLine("Ctor(string)");
        }

        public string ConstructorCallSequence
        {
            get { return myReportBuilder.ToString(); }
        }
    }
}