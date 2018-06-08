namespace BasicCSharp.Common
{
    internal interface IMoveable
    {
        void MoveTo(int x, int y);
        string WhereAmI { get; }
    }

    internal interface ITalkable
    {
        string Talk();
    }

    internal class Duck : IMoveable, ITalkable
    {
        private int myX;
        private int myY;

        public void MoveTo(int x, int y)
        {
            myX = x;
            myY = y;
        }

        public string WhereAmI
        {
            get { return string.Format("You are at ({0}, {1})", myX, myY); }
        }

        public string Talk()
        {
            return "Ga, ga, ...";
        }
    }
}