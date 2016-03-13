namespace OO
{
    public class Derived : Base
    {
        public Derived(string baseData, string derivedData) : base(baseData)
        {
            DerivedData = derivedData;
        }

        public string DerivedData
        {
            get;
            private set;
        }

        public override string AbstractMethod()
        {
            return "AbstractMethod result (from Derived class)";
        }

        public override string VirtualMethod()
        {
            return base.VirtualMethod() + " (from Derived class)";
        }

        public string NewSimpleMethod()
        {
            return "NewSimpleMethod result";
        }

        public virtual string NewVirtualMethod()
        {
            return "NewVirtualMethod result";
        }
    }
}
