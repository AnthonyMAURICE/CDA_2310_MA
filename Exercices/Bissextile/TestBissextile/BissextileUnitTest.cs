using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestBissextile
{
    [TestClass]
    public class BissextileUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool bissextile = Bissextile.Program.Bissextile(2024);
            Assert.IsTrue(bissextile);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool bissextile = Bissextile.Program.Bissextile(1999);
            Assert.IsFalse(bissextile);
        }
    }
}