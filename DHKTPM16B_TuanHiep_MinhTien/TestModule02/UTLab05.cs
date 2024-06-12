using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModule02
{
    [TestClass]
    public class UTLab05
    {

        public TestContext TestContext { get; set; }

        [TestMethod, DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                                "|DataDirectory|\\UTLab05_TestData.csv", "UTLab05_TestData#csv", DataAccessMethod.Sequential),
                                DeploymentItem("UTLab05_TestData.csv")
]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s = TestContext.DataRow[0].ToString(); ;
            int n = Int32.Parse(TestContext.DataRow[2].ToString()); ;
            int p = Int32.Parse(TestContext.DataRow[1].ToString()); ;
            String Expected = TestContext.DataRow[3].ToString(); ;
            String kq = methodLibrary.HuyChuoi(s, n, p);
            Assert.AreEqual(Expected, kq);
        }
        

    }
}
