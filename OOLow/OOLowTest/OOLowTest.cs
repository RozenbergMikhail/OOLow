using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOLow;
using System.Collections.Generic;

namespace OOLowTest
{
    [TestClass]
    public class OOLowTest
    {
        [TestMethod]
        public void OOLow_Derived_BaseData_ReturnsBaseData()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.BaseData;
            Assert.AreEqual("Base", result);
        }

        [TestMethod]
        public void OOLow_Derived_DerivedData_ReturnsDerivedData()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.DerivedData;
            Assert.AreEqual("Derived", result);
        }

        [TestMethod]
        public void OOLow_Derived_SimpleMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = BaseMethods.SimpleMethod(derivedObject);
            Assert.AreEqual("SimpleMethod result", result);
        }

        [TestMethod]
        public void OOLow_Derived_AbstractMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.CallVirt.AbstractMethod(derivedObject);
            Assert.AreEqual("AbstractMethod result (from Derived class)", result);
        }

        [TestMethod]
        public void OOLow_Derived_VirtualMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.CallVirt.VirtualMethod(derivedObject);
            Assert.AreEqual("VirtualMethod result (from Derived class)", result);
        }

        [TestMethod]
        public void OOLow_Derived_NewSimpleMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = DerivedMethods.NewSimpleMethod(derivedObject);
            Assert.AreEqual("NewSimpleMethod result", result);
        }

        [TestMethod]
        public void OOLow_Derived_NewVirtualMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.CallVirt.NewVirtualMethod(derivedObject);
            Assert.AreEqual("NewVirtualMethod result", result);
        }

        [TestMethod]
        public void OOLow_VirtualMethod_ReturnsDifferentValuesForBaseAndDerived()
        {
            List<Base> objects = new List<Base>() { GetInitializedBaseObject(), GetInitializedDerivedObject() };

            var baseResult = objects[0].CallVirt.VirtualMethod(objects[0]);
            var derivedResult = objects[1].CallVirt.VirtualMethod(objects[1]);
            
            Assert.AreNotEqual(baseResult, derivedResult);
        }

        private Derived GetInitializedDerivedObject()
        {
            return new Derived(new DerivedMethods(new BaseMethods()), "Base", "Derived");
        }

        private Base GetInitializedBaseObject()
        {
            return new Base(new BaseMethods(), "Base");
        }
    }
}
