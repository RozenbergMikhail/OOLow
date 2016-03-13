using System;

namespace OOLow
{
    public class Base
    {
        public Base(string baseData)
        {
            this.CallVirt = BaseMethods.Instance;
            this.BaseData = baseData;
        }

        public IBaseVirtualMethods CallVirt { get; protected set; }

        public string BaseData { get; private set; }
    }

    public interface IBaseVirtualMethods
    {
        string AbstractMethod(Base obj);

        string VirtualMethod(Base obj);
    }

    public class BaseMethods : IBaseVirtualMethods
    {
        private static BaseMethods instance = new BaseMethods();
        public static BaseMethods Instance { get { return instance; } }

        public static string SimpleMethod(Base obj)
        {
            return "SimpleMethod result";
        }

        public string AbstractMethod(Base obj)
        {
            throw new NotImplementedException();
        }

        public string VirtualMethod(Base obj)
        {
            return "VirtualMethod result";
        }
    }
}
