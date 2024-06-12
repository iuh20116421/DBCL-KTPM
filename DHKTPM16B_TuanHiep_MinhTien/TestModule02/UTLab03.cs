using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestModule02
{
    [TestClass]
    public class UTLab03
    {
        public TestContext TestContext { get; set; }

        [TestMethod, DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                                "|DataDirectory|\\UTLab03_TestData.csv", "UTLab03_TestData#csv", DataAccessMethod.Sequential),
                                DeploymentItem("UTLab03_TestData.csv")
]
        public void TestMethod1()
        {

            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = Int32.Parse(TestContext.DataRow[0].ToString()); ;
            int chiSoMoi = Int32.Parse(TestContext.DataRow[1].ToString()); ;
            double Expected = Double.Parse(TestContext.DataRow[2].ToString());
            double TinhTienDien = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);
            Assert.AreEqual(Expected, TinhTienDien, 0.001);
        }
    }
}
