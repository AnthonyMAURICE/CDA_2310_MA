namespace TestPrimeNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool premier = PrimeNumber.Program.IsPrime(2);
            Assert.IsTrue(premier);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool premier = PrimeNumber.Program.IsPrime(17);
            Assert.IsTrue(premier);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool premier = PrimeNumber.Program.IsPrime(1);
            Assert.IsFalse(premier);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool premier = PrimeNumber.Program.IsPrime(22);
            Assert.IsFalse(premier);
        }
    }
}