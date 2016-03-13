using System;

namespace OOLow
{
    public class Base
    {
        public Base(IBaseVirtualMethods virtualMethods, string baseData)
        {
            this.CallVirt = virtualMethods;
            this.BaseData = baseData;
        }

        public IBaseVirtualMethods CallVirt { get; private set; }

        public string BaseData { get; private set; }
    }

    public interface IBaseVirtualMethods
    {
        string AbstractMethod(Base obj);

        string VirtualMethod(Base obj);
    }

    public class BaseMethods : IBaseVirtualMethods
    {
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
