using System.Text;

namespace BasicCSharp.Common
{
    internal abstract class InheritanceConstructorCallDemoClassBase
    {
        protected readonly StringBuilder myMessageBuffer = new StringBuilder();

        public string ConstructorCallMessage
        {
            get { return myMessageBuffer.ToString(); }
        }

        protected InheritanceConstructorCallDemoClassBase()
        {
            myMessageBuffer.AppendLine("InheritanceConstructorCallDemoClassBase::Ctor()");
        }

        protected InheritanceConstructorCallDemoClassBase(int arg)
        {
            myMessageBuffer.AppendLine("InheritanceConstructorCallDemoClassBase::Ctor(int)");
        }
    }

    internal class InheritanceConstructorCallDemoClass
        : InheritanceConstructorCallDemoClassBase
    {
        public InheritanceConstructorCallDemoClass()
        {
            myMessageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor()");      
        }

        public InheritanceConstructorCallDemoClass(int arg)
        {
            myMessageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor(int)");
        }

        public InheritanceConstructorCallDemoClass(string arg)
            : base(int.Parse(arg))
        {
            myMessageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor(string)");
        }

        public InheritanceConstructorCallDemoClass(int intArg, string strArg)
            : this(intArg)
        {
            myMessageBuffer.AppendLine("InheritanceConstructorCallDemoClass::Ctor(int, string)");
        }
    }
}