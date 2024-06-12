using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModule02
{
    [TestClass]
    public class UTLab01
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(45, 25, 30);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(30, 45, 25);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(30, 25, 45);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(45, 45, 30);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(45, 25, 45);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(30, 45, 45);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(45, 45, 45);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod8()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(-10, 45, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod9()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(56, 45, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod10()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, -10, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod11()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 56, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod12()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 45, -10);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod13()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 45, 56);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(1, 1, 1);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int max = methodLibrary.Max(50, 50, 50);
            int Expected = 45;
            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestMethod16()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(0, 45, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod17()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(51, 45, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod18()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 0, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod19()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 51, 45);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod20()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 45, 0);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod21()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int max = methodLibrary.Max(45, 45, 51);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);

        }
    }
}
