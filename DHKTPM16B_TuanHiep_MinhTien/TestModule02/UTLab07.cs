using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModule02
{
    [TestClass]
    public class UTLab07
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] list = {5,4};
            int Lagest = methodLibrary.Largest(list);
            int Expected = 5;
            Assert.AreEqual(Expected, Lagest);

        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] list = {  };
            int Lagest = methodLibrary.Largest(list);
            int Expected = Int32.MaxValue;
            Assert.AreEqual(Expected, Lagest);

        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] list = { 9};
            int Lagest = methodLibrary.Largest(list);
            int Expected = 9;
            Assert.AreEqual(Expected, Lagest);

        }
    }
}
