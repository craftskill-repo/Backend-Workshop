namespace BasicCSharp.Common
{
    internal interface ICovariantGetDemo<out T>
    {
        T Get();
    }

    internal interface IContravariantSetDemo<in T>
    {
        void Put(T value);
    }

    internal class CovariantContravariantDemoClass<T> : 
        ICovariantGetDemo<T>, IContravariantSetDemo<T>
    {
        private T myValue;

        public CovariantContravariantDemoClass(T value)
        {
            myValue = value;
        }

        public T Get()
        {
            return myValue;
        }

        public void Put(T value)
        {
            myValue = value;
        }
    }
}