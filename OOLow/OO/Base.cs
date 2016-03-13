namespace OO
{
    public abstract class Base
    {
        public Base(string baseData)
        {
            BaseData = baseData;
        }

        public string BaseData { get; private set; }

        public string SimpleMethod()
        {
            return "SimpleMethod result";
        }

        public abstract string AbstractMethod();

        public virtual string VirtualMethod()
        {
            return "VirtualMethod result";
        }
    }
}
