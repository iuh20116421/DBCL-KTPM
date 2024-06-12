using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModule02
{
    [TestClass]
    public class UTLab02
    {
        public TestContext TestContext { get; set; }

        [TestMethod, DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                                "|DataDirectory|\\UTLab02_TestData.csv", "UTLab02_TestData#csv", DataAccessMethod.Sequential),
                                DeploymentItem("UTLab02_TestData.csv")
]
        public void TestMethod1()
        {

            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int a = Int32.Parse(TestContext.DataRow[0].ToString()); ;
            int b = Int32.Parse(TestContext.DataRow[1].ToString()); ;
            int c = Int32.Parse(TestContext.DataRow[2].ToString()); ;
            float Expected_X1 = float.Parse(TestContext.DataRow[3].ToString()); ;

            float Expected_X2 = float.Parse(TestContext.DataRow[4].ToString()); ;
            String Expected = TestContext.DataRow[5].ToString(); ;
            String SolveQuadratic = methodLibrary.SolveQuadratic(a, b, c, out float x1, out float x2);
            string ExpectedUTF8 = Encoding.UTF8.GetString(Encoding.Default.GetBytes(Expected));
            Assert.AreEqual(ExpectedUTF8, SolveQuadratic);
            Assert.AreEqual(Expected_X1, x1);
            Assert.AreEqual(Expected_X2, x2);
        }
    }
}
