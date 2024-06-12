using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestModule02
{
    [TestClass]
    public class UTLab08
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 3, 2, 9, 4 };
            obj.QuickSort(inputArray,1, 4 );

            int[] expectedResult = { 6, 2, 3, 4, 9 };
            CollectionAssert.AreEqual(expectedResult, inputArray);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = {};
            obj.QuickSort(inputArray, 4, 6);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, 4, 3);

            int[] expectedResult = { 6, 2, 3, 9, 4 };

            CollectionAssert.AreEqual(expectedResult, inputArray);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, -2, 3);

        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, 1, 6);

        }
        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, 0, 4);

            int[] expectedResult = { 2, 3, 4, 6, 9 };

            CollectionAssert.AreEqual(expectedResult, inputArray);
        }
        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, 3, 4);

            int[] expectedResult = { 6, 2, 3, 4, 9 };

            CollectionAssert.AreEqual(expectedResult, inputArray);
        }
        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, -1, 4);

        }
        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, 4, 4);

            int[] expectedResult = { 6, 2, 3, 9, 4 };

            CollectionAssert.AreEqual(expectedResult, inputArray);
        }
        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] inputArray = { 6, 2, 3, 9, 4 };
            obj.QuickSort(inputArray, 0, 5);

        }

    }
}
