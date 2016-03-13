using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO;
using System.Collections.Generic;

namespace OOLowTest
{
    [TestClass]
    public class OOTest
    {
        [TestMethod]
        public void OO_Derived_BaseData_ReturnsBaseData()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.BaseData;
            Assert.AreEqual("Base", result);
        }

        [TestMethod]
        public void OO_Derived_DerivedData_ReturnsDerivedData()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.DerivedData;
            Assert.AreEqual("Derived", result);
        }

        [TestMethod]
        public void OO_Derived_SimpleMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.SimpleMethod();
            Assert.AreEqual("SimpleMethod result", result);
        }

        [TestMethod]
        public void OO_Derived_AbstractMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.AbstractMethod();
            Assert.AreEqual("AbstractMethod result (from Derived class)", result);
        }

        [TestMethod]
        public void OO_Derived_VirtualMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.VirtualMethod();
            Assert.AreEqual("VirtualMethod result (from Derived class)", result);
        }

        [TestMethod]
        public void OO_Derived_NewSimpleMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.NewSimpleMethod();
            Assert.AreEqual("NewSimpleMethod result", result);
        }

        [TestMethod]
        public void OO_Derived_NewVirtualMethod_ReturnsExpectedString()
        {
            var derivedObject = GetInitializedDerivedObject();
            var result = derivedObject.NewVirtualMethod();
            Assert.AreEqual("NewVirtualMethod result", result);
        }

        private Derived GetInitializedDerivedObject()
        {
            return new Derived("Base", "Derived");
        }
    }
}
