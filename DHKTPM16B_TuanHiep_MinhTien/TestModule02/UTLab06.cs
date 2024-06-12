using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModule02
{
    [TestClass]
    public class UTLab06
    {
        public TestContext TestContext { get; set; }

        [TestMethod, DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                                "|DataDirectory|\\UTLab06_TestData.csv", "UTLab06_TestData#csv", DataAccessMethod.Sequential),
                                DeploymentItem("UTLab06_TestData.csv")
]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s1 =  TestContext.DataRow[0].ToString(); ;
            String s2 =  TestContext.DataRow[1].ToString(); ;
            String s3 =  TestContext.DataRow[2].ToString(); ;
            String Expected = TestContext.DataRow[3].ToString(); ;
            String kq = methodLibrary.ThayThe(s1, s2, s3);
            Assert.AreEqual(Expected, kq);
        }
    }
}
