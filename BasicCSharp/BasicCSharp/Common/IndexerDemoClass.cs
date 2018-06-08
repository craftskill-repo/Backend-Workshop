namespace BasicCSharp.Common
{
    public class IndexerDemoClass
    {
        public string this[int integerArgument]
        {
            get { return "You are accessing indexer " + integerArgument; }
        }

        public string this[string stringArgument]
        {
            get { return "You are accessing indexer " + stringArgument; }
        }

        public string this[int firstArgument, string secondArgument]
        {
            get
            {
                return string.Format(
                    "You are accessing indexer with first argument {0} and second argument {1}",
                    firstArgument,
                    secondArgument);
            }
        }
    }
}