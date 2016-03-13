namespace OOLow
{
    public class Derived : Base
    {
        public Derived(string baseData, string derivedData) : base(baseData)
        {
            base.CallVirt = DerivedMethods.Instance;
            this.DerivedData = derivedData;
        }

        public new IDerivedVirtualMethods CallVirt { get { return (IDerivedVirtualMethods)base.CallVirt; } }

        public string DerivedData { get; private set; }
    }

    public interface IDerivedVirtualMethods : IBaseVirtualMethods
    {
        string NewVirtualMethod(Derived obj);
    }

    public class DerivedMethods : IDerivedVirtualMethods
    {
        private static DerivedMethods instance = new DerivedMethods(BaseMethods.Instance);
        public static DerivedMethods Instance { get { return instance; } }

        private readonly IBaseVirtualMethods baseVirtualMethods;

        public DerivedMethods(IBaseVirtualMethods baseVirtualMethods)
        {
            this.baseVirtualMethods = baseVirtualMethods;
        }

        public string AbstractMethod(Base obj)
        {
            return "AbstractMethod result (from Derived class)";
        }

        public string VirtualMethod(Base obj)
        {
            return baseVirtualMethods.VirtualMethod(obj) + " (from Derived class)";
        }

        public static string NewSimpleMethod(Derived obj)
        {
            return "NewSimpleMethod result";
        }

        public string NewVirtualMethod(Derived obj)
        {
            return "NewVirtualMethod result";
        }
    }
}
