using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModule02
{
    [TestClass]
    public class UTLab04
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 =5;
            long Expected_K = 3;
            long Expected_S = 6;
            long Sum = methodLibrary.Sum(s0, out long s);
            Assert.AreEqual(Expected_K, Sum);

            Assert.AreEqual(Expected_S, s);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = -10;
            long Expected_K = 1;
            long Expected_S = 1;
            long Sum = methodLibrary.Sum(s0, out long s);
            Assert.AreEqual(Expected_K, Sum);

            Assert.AreEqual(Expected_S, s);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = 0;
            long Expected_K = 1;
            long Expected_S = 1;
            long Sum = methodLibrary.Sum(s0, out long s);
            Assert.AreEqual(Expected_K, Sum);

            Assert.AreEqual(Expected_S, s);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = 1;
            long Expected_K = 2;
            long Expected_S = 3;
            long Sum = methodLibrary.Sum(s0, out long s);
            Assert.AreEqual(Expected_K, Sum);

            Assert.AreEqual(Expected_S, s);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = -1;
            long Expected_K = 1;
            long Expected_S = 1;
            long Sum = methodLibrary.Sum(s0, out long s);
            Assert.AreEqual(Expected_K, Sum);

            Assert.AreEqual(Expected_S, s);
        }
    }
}
