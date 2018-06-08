namespace BasicCSharp.Common
{
    internal interface ITextStream
    {
        string Read();
        void Write(string text);
    }

    internal class ReadOnlyStream : ITextStream
    {
        private string myStorage = "This is the result";

        public string Read()
        {
            return myStorage;
        }

        void ITextStream.Write(string text)
        {
            myStorage = text;
        }
    }
}